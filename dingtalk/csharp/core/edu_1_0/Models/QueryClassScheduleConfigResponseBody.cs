// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleConfigResponseBody : TeaModel {
        /// <summary>
        /// 查询结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryClassScheduleConfigResponseBodyResult> Result { get; set; }
        public class QueryClassScheduleConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// 班级的Id.
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public QueryClassScheduleConfigResponseBodyResultStart Start { get; set; }
            public class QueryClassScheduleConfigResponseBodyResultStart : TeaModel {
                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }
                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }
            };

            [NameInMap("end")]
            [Validation(Required=false)]
            public QueryClassScheduleConfigResponseBodyResultEnd End { get; set; }
            public class QueryClassScheduleConfigResponseBodyResultEnd : TeaModel {
                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }
                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }
            };

            /// <summary>
            /// 节次模型。
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleConfigResponseBodyResultSectionModels> SectionModels { get; set; }
            public class QueryClassScheduleConfigResponseBodyResultSectionModels : TeaModel {
                /// <summary>
                /// 节次类型：COURSE/REST
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                /// <summary>
                /// 开始时间（时分）
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public QueryClassScheduleConfigResponseBodyResultSectionModelsStart Start { get; set; }
                public class QueryClassScheduleConfigResponseBodyResultSectionModelsStart : TeaModel {
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }
                };

                /// <summary>
                /// 节次设置
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd End { get; set; }
                public class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd : TeaModel {
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

        }

    }

}
