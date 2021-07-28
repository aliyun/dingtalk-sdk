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
            /// 课程编码
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 课程名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 课程介绍
            /// </summary>
            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            /// <summary>
            /// 课程封面地址
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 创建者组织id
            /// </summary>
            [NameInMap("creatorCorpId")]
            [Validation(Required=false)]
            public string CreatorCorpId { get; set; }

            /// <summary>
            /// 创建者UserId
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// 创建者UserName
            /// </summary>
            [NameInMap("creatorUserName")]
            [Validation(Required=false)]
            public string CreatorUserName { get; set; }

            /// <summary>
            /// 老师CorpId
            /// </summary>
            [NameInMap("teacherCorpId")]
            [Validation(Required=false)]
            public string TeacherCorpId { get; set; }

            /// <summary>
            /// 老师UserId
            /// </summary>
            [NameInMap("teacherUserId")]
            [Validation(Required=false)]
            public string TeacherUserId { get; set; }

            /// <summary>
            /// 老师UserName
            /// </summary>
            [NameInMap("teacherUserName")]
            [Validation(Required=false)]
            public string TeacherUserName { get; set; }

            /// <summary>
            /// 业务唯一键
            /// </summary>
            [NameInMap("bizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            /// <summary>
            /// 学科编码
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// 课程组编码
            /// </summary>
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            /// <summary>
            /// 课程状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// 课堂列表
            /// </summary>
            [NameInMap("classrooms")]
            [Validation(Required=false)]
            public List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> Classrooms { get; set; }
            public class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms : TeaModel {
                /// <summary>
                /// 课堂唯一标识
                /// </summary>
                [NameInMap("targetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                /// <summary>
                /// 交互信息
                /// </summary>
                [NameInMap("interactInfo")]
                [Validation(Required=false)]
                public string InteractInfo { get; set; }

            }

            /// <summary>
            /// 课程参与人列表
            /// </summary>
            [NameInMap("eduUserModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> EduUserModels { get; set; }
            public class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels : TeaModel {
                /// <summary>
                /// 用户userid
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// 用户uid
                /// </summary>
                [NameInMap("uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 课程编码
            /// </summary>
            [NameInMap("sectionName")]
            [Validation(Required=false)]
            public string SectionName { get; set; }

            /// <summary>
            /// 课程所在节次序列号
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public long? SectionIndex { get; set; }

            /// <summary>
            /// 课程所在班级id
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// 课程扩展信息
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

        }

    }

}
