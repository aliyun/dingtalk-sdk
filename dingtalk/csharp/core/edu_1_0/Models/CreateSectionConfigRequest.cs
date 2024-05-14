// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateSectionConfigRequest : TeaModel {
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sectionConfigs")]
        [Validation(Required=false)]
        public List<CreateSectionConfigRequestSectionConfigs> SectionConfigs { get; set; }
        public class CreateSectionConfigRequestSectionConfigs : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scheduleName")]
            [Validation(Required=false)]
            public string ScheduleName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("schoolYear")]
            [Validation(Required=false)]
            public string SchoolYear { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionEndDate SectionEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionEndDate : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<CreateSectionConfigRequestSectionConfigsSectionModels> SectionModels { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionModels : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionEndTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime SectionEndTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionStartTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime SectionStartTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionStartDate SectionStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionStartDate : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("semester")]
            [Validation(Required=false)]
            public int? Semester { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("semesterEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterEndDate SemesterEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterEndDate : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("semesterStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterStartDate SemesterStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterStartDate : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
