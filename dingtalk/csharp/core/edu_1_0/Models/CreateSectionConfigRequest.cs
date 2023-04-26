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

        [NameInMap("sectionConfigs")]
        [Validation(Required=false)]
        public List<CreateSectionConfigRequestSectionConfigs> SectionConfigs { get; set; }
        public class CreateSectionConfigRequestSectionConfigs : TeaModel {
            [NameInMap("scheduleName")]
            [Validation(Required=false)]
            public string ScheduleName { get; set; }

            [NameInMap("schoolYear")]
            [Validation(Required=false)]
            public string SchoolYear { get; set; }

            [NameInMap("sectionEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionEndDate SectionEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionEndDate : TeaModel {
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<CreateSectionConfigRequestSectionConfigsSectionModels> SectionModels { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionModels : TeaModel {
                [NameInMap("sectionEndTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime SectionEndTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime : TeaModel {
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                [NameInMap("sectionStartTime")]
                [Validation(Required=false)]
                public CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime SectionStartTime { get; set; }
                public class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime : TeaModel {
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

            }

            [NameInMap("sectionStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSectionStartDate SectionStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSectionStartDate : TeaModel {
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            [NameInMap("semester")]
            [Validation(Required=false)]
            public int? Semester { get; set; }

            [NameInMap("semesterEndDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterEndDate SemesterEndDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterEndDate : TeaModel {
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            [NameInMap("semesterStartDate")]
            [Validation(Required=false)]
            public CreateSectionConfigRequestSectionConfigsSemesterStartDate SemesterStartDate { get; set; }
            public class CreateSectionConfigRequestSectionConfigsSemesterStartDate : TeaModel {
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
