using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWJ_LAB2.Models
{
    // 包含页面上所有宠物和主人详情的静态数据模型
    public class PetDetails
    {
        // 顶部学生信息
        public string StudentInfo => "Tiong Wei Jie BCS23020014";

        // 宠物信息
        public string PetImageSource => "dog.jpg";
        public string PetName => "Robin Hood";
        public string PetBreed => "Pug";
        public string PetAge => "1 year old";
        public string PetGender => "♂";
        public string PetAddress => "3B,Lorong 88, Taman Rantau Panjang";
        public string PetDescription => "Hi! Robin the Pug is simply a tiny tornado of fur, wrinkles, and endless charm!";

        // 主人信息
        public string OwnerImageSource => "owner1.jpeg";
        public string OwnerName => "Tiong Wei Jie";
        public string OwnerRole => "Owner";
        public string AdoptionDate => "11/11/2024";
    }
}
