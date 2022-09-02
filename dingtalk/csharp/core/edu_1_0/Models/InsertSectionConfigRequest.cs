// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class InsertSectionConfigRequest : TeaModel {
        /// <summary>
        /// 结束日期
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public InsertSectionConfigRequestEnd End { get; set; }
        public class InsertSectionConfigRequestEnd : TeaModel {
            /// <summary>
            /// 一月中的第几天
            /// </summary>
            [NameInMap("dayOfMonth")]
            [Validation(Required=false)]
            public int? DayOfMonth { get; set; }

            /// <summary>
            /// 月份
            /// </summary>
            [NameInMap("month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// 年份
            /// </summary>
            [NameInMap("year")]
            [Validation(Required=false)]
            public int? Year { get; set; }

        }

        /// <summary>
        /// 课程表名称
        /// </summary>
        [NameInMap("scheduleName")]
        [Validation(Required=false)]
        public string ScheduleName { get; set; }

        /// <summary>
        /// 节次模型
        /// </summary>
        [NameInMap("sectionModels")]
        [Validation(Required=false)]
        public List<InsertSectionConfigRequestSectionModels> SectionModels { get; set; }
        public class InsertSectionConfigRequestSectionModels : TeaModel {
            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public InsertSectionConfigRequestSectionModelsEnd End { get; set; }
            public class InsertSectionConfigRequestSectionModelsEnd : TeaModel {
                /// <summary>
                /// 小时
                /// </summary>
                [NameInMap("hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// 分钟
                /// </summary>
                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

            }

            /// <summary>
            /// 节次序号
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
            /// 节次类型
            /// </summary>
            [NameInMap("sectionType")]
            [Validation(Required=false)]
            public string SectionType { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public InsertSectionConfigRequestSectionModelsStart Start { get; set; }
            public class InsertSectionConfigRequestSectionModelsStart : TeaModel {
                /// <summary>
                /// 小时
                /// </summary>
                [NameInMap("hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// 分钟
                /// </summary>
                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

            }

        }

        /// <summary>
        /// 开始日期
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public InsertSectionConfigRequestStart Start { get; set; }
        public class InsertSectionConfigRequestStart : TeaModel {
            /// <summary>
            /// 一月中的第几天
            /// </summary>
            [NameInMap("dayOfMonth")]
            [Validation(Required=false)]
            public int? DayOfMonth { get; set; }

            /// <summary>
            /// 月份
            /// </summary>
            [NameInMap("month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// 年份
            /// </summary>
            [NameInMap("year")]
            [Validation(Required=false)]
            public int? Year { get; set; }

        }

        /// <summary>
        /// 操作人的userid。
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
