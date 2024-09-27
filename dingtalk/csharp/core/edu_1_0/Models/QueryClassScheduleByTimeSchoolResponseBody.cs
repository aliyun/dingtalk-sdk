// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleByTimeSchoolResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryClassScheduleByTimeSchoolResponseBodyResult> Result { get; set; }
        public class QueryClassScheduleByTimeSchoolResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_yuwen_12341</para>
            /// </summary>
            [NameInMap("bizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2345</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("classrooms")]
            [Validation(Required=false)]
            public List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> Classrooms { get; set; }
            public class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms : TeaModel {
                [NameInMap("interactInfo")]
                [Validation(Required=false)]
                public string InteractInfo { get; set; }

                [NameInMap("targetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EKK243</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ek1234</para>
            /// </summary>
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>url</para>
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ekk512345</para>
            /// </summary>
            [NameInMap("creatorCorpId")]
            [Validation(Required=false)]
            public string CreatorCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5234523452</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>行政老师A</para>
            /// </summary>
            [NameInMap("creatorUserName")]
            [Validation(Required=false)]
            public string CreatorUserName { get; set; }

            [NameInMap("eduUserModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> EduUserModels { get; set; }
            public class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682399879</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是语文</para>
            /// </summary>
            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>语文</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public long? SectionIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>第一节</para>
            /// </summary>
            [NameInMap("sectionName")]
            [Validation(Required=false)]
            public string SectionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682397879</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_yuwen</para>
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding253453</para>
            /// </summary>
            [NameInMap("teacherCorpId")]
            [Validation(Required=false)]
            public string TeacherCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25234534552345</para>
            /// </summary>
            [NameInMap("teacherUserId")]
            [Validation(Required=false)]
            public string TeacherUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李老师</para>
            /// </summary>
            [NameInMap("teacherUserName")]
            [Validation(Required=false)]
            public string TeacherUserName { get; set; }

        }

    }

}
