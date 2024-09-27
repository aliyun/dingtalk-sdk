// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleConfigResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryClassScheduleConfigResponseBodyResult> Result { get; set; }
        public class QueryClassScheduleConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2345</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("end")]
            [Validation(Required=false)]
            public QueryClassScheduleConfigResponseBodyResultEnd End { get; set; }
            public class QueryClassScheduleConfigResponseBodyResultEnd : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }

            }

            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleConfigResponseBodyResultSectionModels> SectionModels { get; set; }
            public class QueryClassScheduleConfigResponseBodyResultSectionModels : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public QueryClassScheduleConfigResponseBodyResultSectionModelsEnd End { get; set; }
                public class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>45</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>第一节</para>
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public QueryClassScheduleConfigResponseBodyResultSectionModelsStart Start { get; set; }
                public class QueryClassScheduleConfigResponseBodyResultSectionModelsStart : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

            }

            [NameInMap("start")]
            [Validation(Required=false)]
            public QueryClassScheduleConfigResponseBodyResultStart Start { get; set; }
            public class QueryClassScheduleConfigResponseBodyResultStart : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

    }

}
