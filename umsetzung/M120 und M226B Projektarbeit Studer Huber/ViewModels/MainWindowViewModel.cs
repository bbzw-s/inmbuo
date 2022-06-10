using M120_und_M226B_Projektarbeit_Studer_Huber.Models;
using M120_und_M226B_Projektarbeit_Studer_Huber.Utils;
using M120_und_M226B_Projektarbeit_Studer_Huber.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace M120_und_M226B_Projektarbeit_Studer_Huber.ViewModels
{
    public class MainWindowViewModel
    {
        private const string LOREM = @"
Bacon ipsum dolor amet bresaola turkey ham tongue chicken kevin, fatback tenderloin strip steak shank sausage spare ribs. Shankle cupim turkey flank bresaola. Prosciutto alcatra porchetta shoulder hamburger filet mignon pig jowl pork loin jerky ribeye frankfurter tail. Pig ground round boudin kielbasa prosciutto doner. Sausage leberkas t-bone pastrami. Ham hock tail cow meatloaf. Turkey short ribs pig beef ribs.

Buffalo short loin ribeye, chicken shoulder turducken venison t-bone. Jerky pig sirloin, chicken salami short loin porchetta doner brisket boudin spare ribs pork chop jowl burgdoggen. Brisket andouille ribeye pork loin, jerky alcatra prosciutto sirloin pastrami drumstick beef boudin. Chislic leberkas fatback, bacon pastrami drumstick kielbasa hamburger shoulder landjaeger ham hock frankfurter. Pork loin doner cupim sirloin ground round tenderloin. Short ribs ham hock chislic, salami doner meatloaf spare ribs pig.
";
        public ObservableCollection<Category> PostCategories { get; set; }

        public ICommand ShowPostDetailsCommand { get; set; }

        public MainWindowViewModel()
        {
            ShowPostDetailsCommand = new RelayCommand(ShowPostDetails);

            #region Dummy Data
            PostCategories = new ObservableCollection<Category>()
            {
                new Category()
                {
                    Title = "Engineering und Architektur",
                    SubTitle = "Interessante Beiträge zu Software Engineering und Architektur.",
                    Posts = new ObservableCollection<Post>()
                    {
                        new Post()
                        {
                            Title = "Microservices mit linkerd",
                            Content = LOREM,
                            Description = "Interessante Beiträge zu Software Engineering und Architektur.",
                            Author = "Lian Studer"
                        },
                        new Post()
                        {
                            Title = "Microservices mit linkerd",
                            Content = LOREM,
                            Description = "Interessante Beiträge zu Software Engineering und Architektur.",
                            Author = "Lian Studer"
                        },
                        new Post()
                        {
                            Title = "Microservices mit linkerd",
                            Content = LOREM,
                            Description = "Interessante Beiträge zu Software Engineering und Architektur.",
                            Author = "Lian Studer"
                        }
                    }
                },
                new Category()
                {
                    Title = "Marketing und Kommunikation",
                    SubTitle = "Neuste Posts zum Thema Marketing und Kommunikation.",
                    Posts = new ObservableCollection<Post>()
                    {
                        new Post()
                        {
                            Title = "Microservices mit linkerd",
                            Content = LOREM,
                            Description = "Interessante Beiträge zu Software Engineering und Architektur.",
                            Author = "Lian Studer"
                        },
                        new Post()
                        {
                            Title = "Microservices mit linkerd",
                            Content = LOREM,
                            Description = "Interessante Beiträge zu Software Engineering und Architektur.",
                            Author = "Lian Studer"
                        },
                        new Post()
                        {
                            Title = "Microservices mit linkerd",
                            Content = LOREM,
                            Description = "Interessante Beiträge zu Software Engineering und Architektur.",
                            Author = "Lian Studer"
                        }
                    }
                }
            };
            #endregion
        }

        private void ShowPostDetails(object post)
        {
            new PostDetailWindow(post as Post).Show();
        }
    }
}
