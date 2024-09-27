// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateSectionConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>扩展参数</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sectionConfigs")]
        [Validation(Required=false)]
        public List<CreateSectionConfigRequestSectionConfigs> SectionConfigs { get; set; }
        public class CreateSectionConfigRequestSectionConfigs : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>第一学期课表</para>
            /// </summary>
            [NameInMap("scheduleName")]
            [Validation(Required=false)]
            public string ScheduleName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-2022</para>
            /// </summary>
            [NameInMap("schoolYear")]
            [Validation(Required=false)]
            public string SchoolYear { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sectionEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionEndDate SectionEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionEndDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<CreateSectionConfigRequestSectionConfigsSectionModels> SectionModels { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionModels : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sectionEndTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime SectionEndTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>第一节</para>
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sectionStartTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime SectionStartTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>COURSE：上课节次 REST：休息节次</para>
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sectionStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionStartDate SectionStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionStartDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("semester")]
            [Validation(Required=false)]
            public int? Semester { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("semesterEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterEndDate SemesterEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterEndDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("semesterStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterStartDate SemesterStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterStartDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager235</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
