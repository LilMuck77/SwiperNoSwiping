using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwiperNoSwiping
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SwipeLabel.IsVisible = false;
            Instructions.IsVisible = false;
        }

        string image1 = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/Young_cats.jpg/1200px-Young_cats.jpg?20050828125901";
        string image2 = "https://media.istockphoto.com/id/1303043820/photo/mother-and-calf-dolphin-swimming-by.webp?s=2048x2048&w=is&k=20&c=ROwzQl41EC0WuC93Fu2Ur2aWl5J9o1qcOeJKf1lqQ-c=";
        string image3 = "https://st.depositphotos.com/1028833/4612/i/950/depositphotos_46128065-stock-photo-donkey-brown.jpg";
        string image4 = "https://media.istockphoto.com/id/1220985010/photo/grizzly-bear-in-water-growling-mouth-open.webp?s=2048x2048&w=is&k=20&c=MnLRODl0YLL_-hKNAr0UoU9s9P6qwyN-pAXDG9Araoc=";

        string question1 = "Cats actually have 9 lives.";
        string question2 = "Dolphins are mammals. ";
        string question3 = "A mule is the offspring of male donkey and female horse. ";
        string question4 = "Grizzly bears are the largest bears.";

        int correctAnswer = 0;

        
        private void StartButton_Clicked(object sender, EventArgs e)
        {
            StartQuiz.IsVisible = false;
            Images.IsVisible = true;
            SwipeLabel.IsVisible = true;
            Instructions.IsVisible = true;

            QuizResults.Text = question1;
            Images.Source = image1;
        }

        //Creat switch statement basically. Whether they swipe right or left to get the next image. Count score if they swipe correctly. 
        private void SwipeRight(object sender, EventArgs e)
        {
            if (QuizResults.Text == question1)
            {
                
                QuizResults.Text = question2;
                Images.Source = image2;
            }

            else if (QuizResults.Text == question2)
            {
                correctAnswer++;
                QuizResults.Text = question3;
                Images.Source = image3;
            }

            else if (QuizResults.Text == question3)
            {
                correctAnswer++;
                QuizResults.Text = question4;
                Images.Source = image4;
            }

            else if (QuizResults.Text == question4)
            {
                
                Images.IsVisible = false;
                SwipeLabel.IsVisible = false;
                Instructions.IsVisible = false;
                if (correctAnswer == 4)
                {
                    QuizResults.Text = $"You scored {correctAnswer}/4. Congratulations, you ROCK!";
                }
                else
                {

                    QuizResults.Text = $"You scored {correctAnswer}/4. It's suppose to be an easy quiz.";
                }
            }
        }

        private void SwipeLeft(object sender, EventArgs e)
        {
            if (QuizResults.Text == question1)
            {
                correctAnswer++;
                QuizResults.Text = question2;
                Images.Source = image2;
            }

            else if (QuizResults.Text == question2)
            {
                
                QuizResults.Text = question3;
                Images.Source = image3;
            }

            else if (QuizResults.Text == question3)
            {
                QuizResults.Text = question4;
                Images.Source = image4;
            }

            else if (QuizResults.Text == question4)
            {
                correctAnswer++;
                
                Images.IsVisible = false;
                SwipeLabel.IsVisible = false;
                Instructions.IsVisible = false;
                if (correctAnswer == 4)
                {
                    QuizResults.Text = $"You scored {correctAnswer}/4. Congratulations, you ROCK!";
                }
                else {

                    QuizResults.Text = $"You scored {correctAnswer}/4. It's suppose to be an easy quiz.";
                }
            }

        }

    }
}