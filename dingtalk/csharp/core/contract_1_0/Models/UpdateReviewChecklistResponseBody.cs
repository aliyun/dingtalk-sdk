// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class UpdateReviewChecklistResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateReviewChecklistResponseBodyData Data { get; set; }
        public class UpdateReviewChecklistResponseBodyData : TeaModel {
            [NameInMap("checklist")]
            [Validation(Required=false)]
            public UpdateReviewChecklistResponseBodyDataChecklist Checklist { get; set; }
            public class UpdateReviewChecklistResponseBodyDataChecklist : TeaModel {
                [NameInMap("created_at")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<UpdateReviewChecklistResponseBodyDataChecklistRules> Rules { get; set; }
                public class UpdateReviewChecklistResponseBodyDataChecklistRules : TeaModel {
                    [NameInMap("custom")]
                    [Validation(Required=false)]
                    public bool? Custom { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("items")]
                    [Validation(Required=false)]
                    public List<UpdateReviewChecklistResponseBodyDataChecklistRulesItems> Items { get; set; }
                    public class UpdateReviewChecklistResponseBodyDataChecklistRulesItems : TeaModel {
                        [NameInMap("criteria")]
                        [Validation(Required=false)]
                        public string Criteria { get; set; }

                        [NameInMap("enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("risk_level")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    [NameInMap("standpoint")]
                    [Validation(Required=false)]
                    public string Standpoint { get; set; }

                }

                [NameInMap("updated_at")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

        }

    }

}
