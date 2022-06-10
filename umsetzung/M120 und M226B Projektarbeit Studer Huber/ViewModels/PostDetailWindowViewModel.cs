using M120_und_M226B_Projektarbeit_Studer_Huber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_und_M226B_Projektarbeit_Studer_Huber.ViewModels
{
    public class PostDetailWindowViewModel
    {
        public Post Post { get; }

        public PostDetailWindowViewModel(Post post)
        {
            Post = post;
        }
    }
}
