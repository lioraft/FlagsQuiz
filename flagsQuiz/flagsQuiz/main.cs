using Newtonsoft.Json.Linq;

namespace flagsQuiz
{
    public partial class main : Form
    {
        // a dictionary of <country code, country name>
        Dictionary<string, string> code_country = new Dictionary<string, string>();

        // a list of country codes
        List<string> country = new List<string>();

        // current score
        int score = 0;

        // best score
        string bestScore;

        // save the current correct button
        int currentCorrectButton;

        // boolean for if the user has answered the question
        bool answered = true;

        public main()
        {
            InitializeComponent();

            // get best score
            try
            {
                bestScore = File.ReadAllLines("best_score.txt")[0];
                bestscoreTB.Text = bestScore;
            }
            catch (Exception ex)
            {
                // if there was an error, show it to user and continure with score = 0
                MessageBox.Show("Error: Couldn't get best score. Initialized to 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bestscoreTB.Text = "0";
            }

            // read file of country codes and names
            string[] lines = File.ReadAllLines("country_codes.txt");

            // get the code and name of each country and add them to list and dictionary
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string code = parts[0].Trim().ToLower();
                string name = parts[1].Trim();
                code_country[code] = name;
                country.Add(code);
            }

            // subscribe to the CheckedChanged event for each radio button
            option1.CheckedChanged += selectAnswer;
            option2.CheckedChanged += selectAnswer;
            option3.CheckedChanged += selectAnswer;
            option4.CheckedChanged += selectAnswer;
        }

        // function to check if the answer is correct
        private void selectAnswer(object sender, EventArgs e)
        {
            // get the selected radio button
            RadioButton selectedButton = sender as RadioButton;
            if (selectedButton != null && selectedButton.Checked)
            {
                // check if correct answer was chosen
                if ((selectedButton == option1 && currentCorrectButton == 1) ||
            (selectedButton == option2 && currentCorrectButton == 2) ||
            (selectedButton == option3 && currentCorrectButton == 3) ||
            (selectedButton == option4 && currentCorrectButton == 4))
                {
                    // increase score
                    score++;
                    // display score
                    points.Text = score.ToString();
                    // check if broke record
                    if (score > int.Parse(bestScore))
                    {
                        // if so, update best score in file and textbox
                        bestScore = score.ToString();
                        bestscoreTB.Text = bestScore;
                        File.WriteAllText("best_score.txt", bestScore);
                        // show message to user
                        recordLbl.Visible = true;
                    }
                    // clear the selected radio button
                    selectedButton.Checked = false;
                    // show next question
                    newQuestion();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Game is over. your score is " + score + ". Would you like to start a new game?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // if user wants new game, reset score and show new question
                    if (result == DialogResult.Yes)
                    {
                        // reset score
                        score = 0;
                        // display score
                        points.Text = score.ToString();
                        // clear the selected radio button
                        selectedButton.Checked = false;
                        // show next question
                        newQuestion();
                    }
                    else
                    {
                        // if user doesn't want new game, exit
                        MessageBox.Show("Thank you for playing!", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spiralGlobePic.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            // make all the controls invisible
            flag.Visible = false;
            question.Visible = false;
            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            option4.Visible = false;
            points.Visible = false;
            answersLbl.Visible = false;
            recordLbl.Visible = false;
            timer1.Start(); // start spiral globe
        }

        // function for generating a new question
        private void newQuestion()
        {
            // choose 4 random countries from the list
            Random random = new Random();
            List<string> randomCountries = new List<string>();
            while (randomCountries.Count < 4)
            {
                // random index
                int index = random.Next(country.Count);
                // get the country code at that index
                string code = country[index];
                // if the country code is not already in the list, add it
                if (!randomCountries.Contains(code))
                    randomCountries.Add(code);
            }

            // choose a random country from the 4 random countries, which will be the correct answer
            int randomIndex = random.Next(randomCountries.Count);
            // set the current correct button to the random index + 1
            currentCorrectButton = randomIndex + 1;
            // get the country code at the random index
            string randomCountry = randomCountries[randomIndex];

            // set the answers text to the country name
            option1.Text = code_country[randomCountries[0]];
            option2.Text = code_country[randomCountries[1]];
            option3.Text = code_country[randomCountries[2]];
            option4.Text = code_country[randomCountries[3]];

            // get the flag of the random country using my flags API from the following link:
            // https://github.com/lioraft/FlagsAPI/tree/main

            // create a new instance of the HttpClient
            HttpClient client = new HttpClient();
            try
            {
                // get the response from the API
                HttpResponseMessage response = client.GetAsync("https://lioraft.pythonanywhere.com/get_image/?category=countries&image=" + randomCountry).Result;
                // check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // read the response content as a string
                    string jsonResponse = response.Content.ReadAsStringAsync().Result;

                    // parse the json
                    JObject jsonObject = JObject.Parse(jsonResponse);
                    // get the image url from the json
                    string url = (string)jsonObject["Content"];
                    // convert url to image
                    Image image = Image.FromStream(client.GetStreamAsync(url).Result);
                    flag.Image = image;
                }
                else
                {
                    // if the response is not successful, show the status code and exit
                    MessageBox.Show("Request failed with status code:" + response.StatusCode + ". Please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                // if there was an error, show it to user and exit
                MessageBox.Show("Error: " + ex.Message + ". Please restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // function for when the start button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            // stop showing the spiral globe
            timer1.Stop();
            spiralGlobePic.Visible = false;
            // stop showing button itself
            button1.Visible = false;

            // show all the controls
            flag.Visible = true;
            question.Visible = true;
            option1.Visible = true;
            option2.Visible = true;
            option3.Visible = true;
            option4.Visible = true;
            points.Visible = true;
            answersLbl.Visible = true;

            // start displaying questions
            newQuestion();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}