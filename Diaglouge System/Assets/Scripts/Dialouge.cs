using System;

namespace DefaultNamespace
{
    
    [Serializable]
    public class Dialouge
    {
        public String Question;
        public Answers Answers;
        public FollowUps FollowUps;
    }

    [Serializable]
    public class Answers
    {
        public String A;
        public String B;
        public String C;
        public String D;
    }

    [Serializable]
    public class FollowUps
    {
        public String A;
        public String B;
        public String C;
        public String D;
    }
}