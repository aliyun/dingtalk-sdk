// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class InsertSectionConfigRequest : TeaModel {
        [NameInMap("end")]
        [Validation(Required=false)]
        public InsertSectionConfigRequestEnd End { get; set; }
        public class InsertSectionConfigRequestEnd : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dayOfMonth")]
            [Validation(Required=false)]
            public int? DayOfMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021</para>
            /// </summary>
            [NameInMap("year")]
            [Validation(Required=false)]
            public int? Year { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020学年第一学期课表</para>
        /// </summary>
        [NameInMap("scheduleName")]
        [Validation(Required=false)]
        public string ScheduleName { get; set; }

        [NameInMap("sectionModels")]
        [Validation(Required=false)]
        public List<InsertSectionConfigRequestSectionModels> SectionModels { get; set; }
        public class InsertSectionConfigRequestSectionModels : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public InsertSectionConfigRequestSectionModelsEnd End { get; set; }
            public class InsertSectionConfigRequestSectionModelsEnd : TeaModel {
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
            /// <para>语文</para>
            /// </summary>
            [NameInMap("sectionName")]
            [Validation(Required=false)]
            public string SectionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>REST/COURSE</para>
            /// </summary>
            [NameInMap("sectionType")]
            [Validation(Required=false)]
            public string SectionType { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public InsertSectionConfigRequestSectionModelsStart Start { get; set; }
            public class InsertSectionConfigRequestSectionModelsStart : TeaModel {
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
        public InsertSectionConfigRequestStart Start { get; set; }
        public class InsertSectionConfigRequestStart : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dayOfMonth")]
            [Validation(Required=false)]
            public int? DayOfMonth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021</para>
            /// </summary>
            [NameInMap("year")]
            [Validation(Required=false)]
            public int? Year { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager235</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
