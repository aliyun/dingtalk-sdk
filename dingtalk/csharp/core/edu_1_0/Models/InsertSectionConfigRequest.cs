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

            [NameInMap("sectionType")]
            [Validation(Required=false)]
            public string SectionType { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public InsertSectionConfigRequestSectionModelsStart Start { get; set; }
            public class InsertSectionConfigRequestSectionModelsStart : TeaModel {
                [NameInMap("hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

            }

        }

        [NameInMap("start")]
        [Validation(Required=false)]
        public InsertSectionConfigRequestStart Start { get; set; }
        public class InsertSectionConfigRequestStart : TeaModel {
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

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
