using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WorCout_API.Entities;
using WorCout_API.Models.Accounts;

namespace WorCout_API.Models.WorCoutModels
{
    public class Exercises
    {
        [Key]
        public string exercise_name { get; set; }
        [ForeignKey("MuscleGroups")]
        public string muscle_group_name { get; set; }
        public MuscleGroups MuscleGroups { get; set; }
        [DisplayFormat(NullDisplayText = "No Description.")]
        public string exercise_desc { get; set; }
    }
    public class MuscleGroups
    {
        [Key]
        public string muscle_group_name { get; set; }
        [ForeignKey("Muscles")]
        public int? targeted_muscles_id { get; set; }
        public Muscles Muscles { get; set; }
    }
    public class Calories
    {
        [Key]
        public int cal_id { get; set; }
        [ForeignKey("Id")]
        public int user_id { get; set; }
        public Account Id { get; set; }
        public int? daily_calories { get; set; }
        public string? weight { get; set; }
        public string? height { get; set; }
        public int? age { get; set; }
    }
    public class Muscles
    {
        [Key]
        [DefaultValue(0)]
        public int? muscles_id { get; set; }
        [DefaultValue(0)]
        public bool? shoulders { get; set; }
        [DefaultValue(0)]
        public bool? lower_back { get; set; }
        [DefaultValue(0)]
        public bool? upper_back { get; set; }
        [DefaultValue(0)]
        public bool? abs { get; set; }
        [DefaultValue(0)]
        public bool? hamstrings { get; set; }
        [DefaultValue(0)]
        public bool? glutes { get; set; }
        [DefaultValue(0)]
        public bool? quadriceps { get; set; }
        [DefaultValue(0)]
        public bool? biceps { get; set; }
        [DefaultValue(0)]
        public bool? triceps { get; set; }
        [DefaultValue(0)]
        public bool? delts { get; set; }
        [DefaultValue(0)]
        public bool? lats { get; set; }
        [DefaultValue(0)]
        public bool? traps { get; set; }
        [DefaultValue(0)]
        public bool? chest { get; set; }
        [DefaultValue(0)]
        public bool? forearm { get; set; }
        [DefaultValue(0)]
        public bool? calves { get; set; }
        [DefaultValue(0)]
        public bool? abductor { get; set; }
        [DefaultValue(0)]
        public bool? adductor { get; set; }
    }
/*    public class Sessions
    {
        [Key]
        public int session_id { get; set; }
        [DataType(DataType.Date)]
        [ForeignKey("user_id")]
        public int user_id { get; set; }
        public Workouts Id { get; set; }
        public DateTime session_date { get; set; }
        [DataType(DataType.Time)]
        public DateTime session_time { get; set; }
        public int session_length { get; set; }
    }*/
    public class Tempos
    {
        [Key]
        public int tempo_id { get; set; }
        public int negative_time_s { get; set; }
        public int isometric_time_s { get; set; }
        public int concentric_time_s { get; set; }
        public int pause_time_s { get; set; }
    }
    public class Workouts
    {
        [Key]
        public int workout_id { get; set; }
        [ForeignKey("Tempos")]
        public int? tempo_id { get; set; }
        public Tempos Tempos { get; set; }
        [ForeignKey("Id")]
        public int user_id { get; set; }
        public Account Id { get; set; }
        [ForeignKey("Exercises")]
        public string exercise_name { get; set; }
        public Exercises Exercises { get; set; }
        [Column(TypeName = "Date")]
        public DateTime session_date { get; set; }
        public int? set_number { get; set; }
        public int? reps { get; set; }
        public float? weight_lbs { get; set; }
        public bool? completed { get; set; }
    }
}
