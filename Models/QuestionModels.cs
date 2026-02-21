// Models/QuestionModels.cs

using System;
using System.Collections.Generic;

namespace QuestionBank.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Marks { get; set; }
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }
    }

    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public List<Topic> Topics { get; set; }
    }

    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }
        public List<Subtopic> Subtopics { get; set; }
    }

    public class Subtopic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }

    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }

    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int SyllabusId { get; set; }
        public Syllabus Syllabus { get; set; }
    }

    public class Syllabus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
        public List<Resource> Resources { get; set; }
    }

    public class Resource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int SyllabusId { get; set; }
        public Syllabus Syllabus { get; set; }
    }

    public class QuestionPaper
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Question> Questions { get; set; }
    }
}