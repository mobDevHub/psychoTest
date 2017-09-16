using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace psychoTest
{
    [Activity(Label = "App11", MainLauncher = true)]
    
    public class MainActivity : Activity
    {
        public TextView tv1;
        public RadioButton rb1;
        public RadioButton rb2;
        public RadioButton rb3;
        public Button button1;
        public ProgressBar progress;
        int point = 0;
        int i = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            PersonToJsonToPersonExample();

            Answer answerText = new Answer();
            _currentQuestion = new Question();
            List<Answer> Answer = new List<Answer>();
            #region    
            resultTest.Add("Вы чересчур самостоятельны во всех отношениях. Вы не только не терпите какого-нибудь вмешательства в ваши дела, но и не можете прислушаться к чужому мнению. Уверены ли вы, что всегда будете точно оценивать плюсы и минусы какого-либо решения? Не вкладываете ли излишнее упрямство в достижение какой-либо цели? Запомните, что самоуверенность хороша только в меру, в противном случае она превращается в недостаток.");
            resultTest.Add("У вас сильный характер, вы неплохо переносите стрессы. Вы надежный друг. Ваша уверенность в себе, своем будущем обоснована. Вы независимы, но всегда прислушиваетесь к мнению окружающих, которые вас за это ценят.");
            resultTest.Add("Вы очень нерешительны. Настолько, что это, простите, граничит с малодушием. Может быть, поэтому к вам иногда относятся с пренебрежением? Почему бы вам не попробовать проявить побольше самостоятельности? Конечно, в разумных пределах. Может быть, стоит сделать и так, чтобы ваша нерешительность не была написана у вас на лице? Станьте более самостоятельным, и у вас появится уверенность в себе, которой вам не хватает.");


            answerText.Text = "решали самостоятельно, следуя своему увлечению и своим данным;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "прислушивались и к мнению своих родителей, родственников;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "прислушивались к совету только близких и друзей.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Закончив школу, как вы принимали решение о дальнейшей учебе, будущей профессии: ";
            _currentQuestion.Answers = Answer;
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            tv1 = FindViewById<TextView>(Resource.Id.textView1);
            rb1 = FindViewById<RadioButton>(Resource.Id.radioButton1);
            rb2 = FindViewById<RadioButton>(Resource.Id.radioButton2);
            rb3 = FindViewById<RadioButton>(Resource.Id.radioButton3);
            button1 = FindViewById<Button>(Resource.Id.button1);
            currentQuestion();
            answerText = new Answer();
            answerText.Text = "только на свои силы;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "на благоприятный исход вступительных экзаменов и на связи;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "только на связи.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "На что вы рассчитывали, поступая в выбранное вами учебное заведение: ";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "рассчитывали, делали упор на свое трудолюбие;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "иногда просили помочь преподавателей и однокурсников;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "рассчитывали только на чужую помощь.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Как во время учебы вы готовились к экзаменам, занятиям: ";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "по распределению;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "прежде всего вы использовали информацию знакомых, знающих людей;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "вы устроились благодаря связям.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Как вы поступили на работу:";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "рассчитывая только на свой опыт и знания;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "иногда консультируетесь с коллегами;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "всегда с ними советуюсь.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "При сложных ситуациях в работе каким образом вы принимаете решения:";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "вы сами приняли окончательное решение;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "вы прислушивались к мнению близких;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "прежде всего вы представили невесту своим близким, посоветовались с ними.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Чем был продиктован ваш выбор перед вступлением в брак:";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "да;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "конечно, вы можете это сделать, но лучше было бы отложить решение;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "нет.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Если ваша жена (муж) в длительной командировке, в состоянии ли вы сами, допустим, выбрать жилье, мебель, принять другие важные решения:";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "всегда отстаивали;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "по этому поводу у вас даже были конфликты с родителями; отстаивали, но сохраняли и уважение к мнению родителей;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "вы ни на что не могли решиться сами.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Насколько упорно в подростковом возрасте вы отстаивали свое мнение:";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "разумеется, отстаиваете, независимо от обстоятельств;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "в большинстве случаев — да;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "редко.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "В настоящее время насколько упорно вы отстаиваете собственное мнение на службе, дома, с друзьями:";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "полностью отдаете себя профессии;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "для вас очень важно мнение вашей супруги и близких;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "вы полностью полагаетесь на ее (их) мнение.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Как вы развиваетесь как личность в служебной, общественной, интеллектуальной сферах:";
            _currentQuestion.Answers = Answer;

            answerText = new Answer();
            answerText.Text = "вы заставляете ее (его) следить за своим здоровьем;";
            answerText.Point = 4;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "тактично подсказываете, что ей (ему) нужно сделать;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "стремитесь сделать это, но вам редко удается.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Если ваши близкие должны поправить свое здоровье, если вы видите, что ваша жена (муж) не следит за собой, делая что-то себе во вред:";
            _currentQuestion.Answers = Answer;
            #endregion
            progress = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            button1.Click += delegate
            {
                button1_On_Click();
            };
        }


        public class Person
        {
            public string Name { get; set; }
            public DateTime Birthday { get; set; }
        }

        void PersonToJsonToPersonExample()
        {
            Answer answerText = new Answer();
            _currentQuestion = new Question();
            List<Answer> Answer = new List<Answer>();
            answerText.Text = "решали самостоятельно, следуя своему увлечению и своим данным;";
            answerText.Point = 4; 
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "прислушивались и к мнению своих родителей, родственников;";
            answerText.Point = 2;
            Answer.Add(answerText);
            answerText = new Answer();
            answerText.Text = "прислушивались к совету только близких и друзей.";
            answerText.Point = 1;
            Answer.Add(answerText);
            _currentQuestion.Text = "Закончив школу, как вы принимали решение о дальнейшей учебе, будущей профессии: ";
            _currentQuestion.Answers = Answer;
           // var expandoObject = JsonConvert.DeserializeObject<ExpandoObject>(carPropertiesJson, new ExpandoObjectConverter());
            //Json json;
           var json = JsonConvert.SerializeObject(_currentQuestion);
            //Console.WriteLine("JSON representation of person: {0}", json);

            var question = JsonConvert.DeserializeObject<Question>(json);
            
        }
        

        List<string> resultTest = new List<string>(); 
        Question _currentQuestion;

        void currentQuestion()
        {
            tv1.Text = _currentQuestion.Text;
            rb1.Text = _currentQuestion.Answers[i].Text;
            rb2.Text = _currentQuestion.Answers[i+1].Text;
            rb3.Text = _currentQuestion.Answers[i+2].Text;
        }

        void button1_On_Click()
        { 
            if (i <= 32)
            {
                i = i + 3;
                countPoin();
                progress.Progress += 1;
                currentQuestion();
            }
            else
            {
                rb1.Visibility = Android.Views.ViewStates.Invisible;
                rb2.Visibility = Android.Views.ViewStates.Invisible;
                rb3.Visibility = Android.Views.ViewStates.Invisible;
                resultPoint();
            }
        }
        void countPoin()
        {
            if (rb1.Checked == true)
                point += Convert.ToInt32(_currentQuestion.Answers[0].Point);
            else if (rb2.Checked == true)
                point += Convert.ToInt32(_currentQuestion.Answers[1].Point);
            else if (rb3.Checked == true)
                point += Convert.ToInt32(_currentQuestion.Answers[2].Point);

        }
        void resultPoint()
        {
            if (point >= 33)
                tv1.Text = Convert.ToString("Вы набрали " + point + '\n' + '\n' + resultTest[0]);
            else if (point >= 15 && point <= 29)
                tv1.Text = Convert.ToString("Вы набрали " + point + '\n' + '\n' + resultTest[1]);
            else if (point <= 14)
                tv1.Text = Convert.ToString("Вы набрали " + point + '\n' + '\n' + resultTest[2]);
        }
        public class Answer
        {
            public string Text { get; set; }
            public int Point{ get; set; } 
        }
        public class Question
        {
            public string Text { get; set; }
            public List<Answer> Answers{ get; set; }
        }
    }
}

