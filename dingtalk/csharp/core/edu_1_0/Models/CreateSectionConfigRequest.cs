// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateSectionConfigRequest : TeaModel {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// 课表模板信息
        /// </summary>
        [NameInMap("sectionConfigs")]
        [Validation(Required=false)]
        public List<CreateSectionConfigRequestSectionConfigs> SectionConfigs { get; set; }
        public class CreateSectionConfigRequestSectionConfigs : TeaModel {
            /// <summary>
            /// 课表名称
            /// </summary>
            [NameInMap("scheduleName")]
            [Validation(Required=false)]
            public string ScheduleName { get; set; }

            /// <summary>
            /// 学年
            /// </summary>
            [NameInMap("schoolYear")]
            [Validation(Required=false)]
            public string SchoolYear { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("sectionEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionEndDate SectionEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionEndDate : TeaModel {
                /// <summary>
                /// 日
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 节次模型
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<CreateSectionConfigRequestSectionConfigsSectionModels> SectionModels { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionModels : TeaModel {
                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("sectionEndTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime SectionEndTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime : TeaModel {
                    /// <summary>
                    /// 小时
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// 分
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// 第几节。
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// 节次名称
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                /// <summary>
                /// 开始时间
                /// </summary>
                [NameInMap("sectionStartTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime SectionStartTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime : TeaModel {
                    /// <summary>
                    /// 小时
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// 分
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// 节次类型枚举：COURSE/REST
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

            }

            /// <summary>
            /// 开始时间（精确到日）
            /// </summary>
            [NameInMap("sectionStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionStartDate SectionStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionStartDate : TeaModel {
                /// <summary>
                /// 每个月的第几天。
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月份。
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年份。
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 学期
            /// </summary>
            [NameInMap("semester")]
            [Validation(Required=false)]
            public int? Semester { get; set; }

            /// <summary>
            /// 学期结束时间
            /// </summary>
            [NameInMap("semesterEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterEndDate SemesterEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterEndDate : TeaModel {
                /// <summary>
                /// 每月第几天
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 学期开始时间
            /// </summary>
            [NameInMap("semesterStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterStartDate SemesterStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterStartDate : TeaModel {
                /// <summary>
                /// 日
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        /// <summary>
        /// 操作人的userid。
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
