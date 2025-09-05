// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class GetTaskPackageResultResponseBody : TeaModel {
        [NameInMap("taskPackageId")]
        [Validation(Required=false)]
        public string TaskPackageId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<GetTaskPackageResultResponseBodyTasks> Tasks { get; set; }
        public class GetTaskPackageResultResponseBodyTasks : TeaModel {
            [NameInMap("reportLink")]
            [Validation(Required=false)]
            public string ReportLink { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public GetTaskPackageResultResponseBodyTasksResult Result { get; set; }
            public class GetTaskPackageResultResponseBodyTasksResult : TeaModel {
                [NameInMap("audioText")]
                [Validation(Required=false)]
                public string AudioText { get; set; }

                [NameInMap("audioTextFormatted")]
                [Validation(Required=false)]
                public string AudioTextFormatted { get; set; }

                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("formName")]
                [Validation(Required=false)]
                public string FormName { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetTaskPackageResultResponseBodyTasksResultItems> Items { get; set; }
                public class GetTaskPackageResultResponseBodyTasksResultItems : TeaModel {
                    [NameInMap("advantages")]
                    [Validation(Required=false)]
                    public string Advantages { get; set; }

                    [NameInMap("fabReference")]
                    [Validation(Required=false)]
                    public string FabReference { get; set; }

                    [NameInMap("info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("point")]
                    [Validation(Required=false)]
                    public long? Point { get; set; }

                    [NameInMap("reference")]
                    [Validation(Required=false)]
                    public string Reference { get; set; }

                    [NameInMap("res")]
                    [Validation(Required=false)]
                    public bool? Res { get; set; }

                    [NameInMap("suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("parseText")]
                [Validation(Required=false)]
                public string ParseText { get; set; }

                [NameInMap("rawData")]
                [Validation(Required=false)]
                public string RawData { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusInfo")]
            [Validation(Required=false)]
            public string StatusInfo { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
