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
            /// 学期
            /// </summary>
            [NameInMap("semester")]
            [Validation(Required=false)]
            public int? Semester { get; set; }

            /// <summary>
            /// 开始时间（精确到日）
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsStart Start { get; set; }
            public class CreateSectionConfigRequestSectionConfigsStart : TeaModel {
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }
            };

            /// <summary>
            /// 学年
            /// </summary>
            [NameInMap("schoolYear")]
            [Validation(Required=false)]
            public string SchoolYear { get; set; }

            /// <summary>
            /// 课表名称
            /// </summary>
            [NameInMap("scheduleName")]
            [Validation(Required=false)]
            public string ScheduleName { get; set; }

            /// <summary>
            /// 节次模型
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<CreateSectionConfigRequestSectionConfigsSectionModels> SectionModels { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionModels : TeaModel {
                /// <summary>
                /// 节次类型枚举：COURSE/REST
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                /// <summary>
                /// 开始时间
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsStart Start { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsStart : TeaModel {
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }
                };

                /// <summary>
                /// 第几节。
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsEnd End { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsEnd : TeaModel {
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }
                };

                /// <summary>
                /// 节次名称
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

            }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsEnd End { get; set; }
            public class CreateSectionConfigRequestSectionConfigsEnd : TeaModel {
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }
            };

            /// <summary>
            /// 学期开始时间
            /// </summary>
            [NameInMap("semesterStart")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterStart SemesterStart { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterStart : TeaModel {
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }
            };

            /// <summary>
            /// 学期结束时间
            /// </summary>
            [NameInMap("semesterEnd")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterEnd SemesterEnd { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterEnd : TeaModel {
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }
            };

        }

        /// <summary>
        /// 操作人的userid。
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
