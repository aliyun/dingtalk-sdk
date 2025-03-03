// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PublishSchoolReportRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("classDetailItems")]
        [Validation(Required=false)]
        public List<PublishSchoolReportRequestClassDetailItems> ClassDetailItems { get; set; }
        public class PublishSchoolReportRequestClassDetailItems : TeaModel {
            [NameInMap("classId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }

            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("studentDetailList")]
            [Validation(Required=false)]
            public List<PublishSchoolReportRequestClassDetailItemsStudentDetailList> StudentDetailList { get; set; }
            public class PublishSchoolReportRequestClassDetailItemsStudentDetailList : TeaModel {
                [NameInMap("studentId")]
                [Validation(Required=false)]
                public string StudentId { get; set; }

                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                [NameInMap("subjectList")]
                [Validation(Required=false)]
                public List<PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList> SubjectList { get; set; }
                public class PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList : TeaModel {
                    [NameInMap("gradeRank")]
                    [Validation(Required=false)]
                    public long? GradeRank { get; set; }

                    [NameInMap("levelScore")]
                    [Validation(Required=false)]
                    public string LevelScore { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("examClass")]
        [Validation(Required=false)]
        public string ExamClass { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("examTitle")]
        [Validation(Required=false)]
        public string ExamTitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("publishScope")]
        [Validation(Required=false)]
        public string PublishScope { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scoreType")]
        [Validation(Required=false)]
        public string ScoreType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("share")]
        [Validation(Required=false)]
        public bool? Share { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("showRank")]
        [Validation(Required=false)]
        public bool? ShowRank { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("showStatisticsScore")]
        [Validation(Required=false)]
        public bool? ShowStatisticsScore { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subScoreType")]
        [Validation(Required=false)]
        public string SubScoreType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subjectList")]
        [Validation(Required=false)]
        public List<PublishSchoolReportRequestSubjectList> SubjectList { get; set; }
        public class PublishSchoolReportRequestSubjectList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subjects")]
        [Validation(Required=false)]
        public string Subjects { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("teacherId")]
        [Validation(Required=false)]
        public string TeacherId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("teacherName")]
        [Validation(Required=false)]
        public string TeacherName { get; set; }

    }

}
