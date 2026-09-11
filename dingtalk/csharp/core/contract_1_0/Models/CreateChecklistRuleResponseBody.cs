// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateChecklistRuleResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateChecklistRuleResponseBodyData Data { get; set; }
        public class CreateChecklistRuleResponseBodyData : TeaModel {
            [NameInMap("rule")]
            [Validation(Required=false)]
            public CreateChecklistRuleResponseBodyDataRule Rule { get; set; }
            public class CreateChecklistRuleResponseBodyDataRule : TeaModel {
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
                public List<CreateChecklistRuleResponseBodyDataRuleItems> Items { get; set; }
                public class CreateChecklistRuleResponseBodyDataRuleItems : TeaModel {
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

        }

    }

}
