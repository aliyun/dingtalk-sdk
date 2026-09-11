// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ListReviewChecklistsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListReviewChecklistsResponseBodyData Data { get; set; }
        public class ListReviewChecklistsResponseBodyData : TeaModel {
            [NameInMap("checklists")]
            [Validation(Required=false)]
            public List<ListReviewChecklistsResponseBodyDataChecklists> Checklists { get; set; }
            public class ListReviewChecklistsResponseBodyDataChecklists : TeaModel {
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
                public List<ListReviewChecklistsResponseBodyDataChecklistsRules> Rules { get; set; }
                public class ListReviewChecklistsResponseBodyDataChecklistsRules : TeaModel {
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
                    public List<ListReviewChecklistsResponseBodyDataChecklistsRulesItems> Items { get; set; }
                    public class ListReviewChecklistsResponseBodyDataChecklistsRulesItems : TeaModel {
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

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

        }

    }

}
