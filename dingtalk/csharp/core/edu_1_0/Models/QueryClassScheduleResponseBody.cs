// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleResponseBody : TeaModel {
        /// <summary>
        /// 课表时间节次配置。
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public QueryClassScheduleResponseBodyConfig Config { get; set; }
        public class QueryClassScheduleResponseBodyConfig : TeaModel {
            /// <summary>
            /// 开始时间（到日）。
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public QueryClassScheduleResponseBodyConfigEnd End { get; set; }
            public class QueryClassScheduleResponseBodyConfigEnd : TeaModel {
                /// <summary>
                /// 一个月中第几天
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }

                /// <summary>
                /// 月份。
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

                /// <summary>
                /// 年份。
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }

            }

            /// <summary>
            /// 节次模型。
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleResponseBodyConfigSectionModels> SectionModels { get; set; }
            public class QueryClassScheduleResponseBodyConfigSectionModels : TeaModel {
                /// <summary>
                /// 结束时间（时分级别）
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public QueryClassScheduleResponseBodyConfigSectionModelsEnd End { get; set; }
                public class QueryClassScheduleResponseBodyConfigSectionModelsEnd : TeaModel {
                    /// <summary>
                    /// 小时。
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    /// <summary>
                    /// 分钟。
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                }

                /// <summary>
                /// 节次序列。
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public long? SectionIndex { get; set; }

                /// <summary>
                /// 节次名称。
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                /// <summary>
                /// 节次类型：  COURSE：上课节次 REST：休息节次
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                /// <summary>
                /// 开始时间（时分级别）。
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public QueryClassScheduleResponseBodyConfigSectionModelsStart Start { get; set; }
                public class QueryClassScheduleResponseBodyConfigSectionModelsStart : TeaModel {
                    /// <summary>
                    /// 小时。
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    /// <summary>
                    /// 分钟
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                }

            }

            /// <summary>
            /// 开始时间（到日）。
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public QueryClassScheduleResponseBodyConfigStart Start { get; set; }
            public class QueryClassScheduleResponseBodyConfigStart : TeaModel {
                /// <summary>
                /// 一个月中第几天
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }

                /// <summary>
                /// 月份。
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

                /// <summary>
                /// 年份。
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }

            }

        }

        /// <summary>
        /// 课程列表
        /// </summary>
        [NameInMap("courseDTOS")]
        [Validation(Required=false)]
        public List<QueryClassScheduleResponseBodyCourseDTOS> CourseDTOS { get; set; }
        public class QueryClassScheduleResponseBodyCourseDTOS : TeaModel {
            /// <summary>
            /// 课程所在班级id
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// 课堂列表
            /// </summary>
            [NameInMap("classrooms")]
            [Validation(Required=false)]
            public List<QueryClassScheduleResponseBodyCourseDTOSClassrooms> Classrooms { get; set; }
            public class QueryClassScheduleResponseBodyCourseDTOSClassrooms : TeaModel {
                /// <summary>
                /// 交互信息
                /// </summary>
                [NameInMap("interactInfo")]
                [Validation(Required=false)]
                public string InteractInfo { get; set; }

                /// <summary>
                /// 课堂唯一标识
                /// </summary>
                [NameInMap("targetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

            }

            /// <summary>
            /// 课程编码
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 课程组编码
            /// </summary>
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            /// <summary>
            /// 课程封面地址
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

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
            /// 课程参与人列表
            /// </summary>
            [NameInMap("eduUserModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleResponseBodyCourseDTOSEduUserModels> EduUserModels { get; set; }
            public class QueryClassScheduleResponseBodyCourseDTOSEduUserModels : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 用户uid
                /// </summary>
                [NameInMap("uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

                /// <summary>
                /// 用户userid
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 课程扩展信息
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// 课程介绍
            /// </summary>
            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            /// <summary>
            /// 课程名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 课程所在节次序列号
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public long? SectionIndex { get; set; }

            /// <summary>
            /// 课程名称
            /// </summary>
            [NameInMap("sectionName")]
            [Validation(Required=false)]
            public string SectionName { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 课程状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// 学科编码
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

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

        }

    }

}
