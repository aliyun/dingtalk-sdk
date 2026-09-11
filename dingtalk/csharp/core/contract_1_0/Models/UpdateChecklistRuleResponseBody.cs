// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class UpdateChecklistRuleResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateChecklistRuleResponseBodyData Data { get; set; }
        public class UpdateChecklistRuleResponseBodyData : TeaModel {
            [NameInMap("rule")]
            [Validation(Required=false)]
            public UpdateChecklistRuleResponseBodyDataRule Rule { get; set; }
            public class UpdateChecklistRuleResponseBodyDataRule : TeaModel {
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
                public List<UpdateChecklistRuleResponseBodyDataRuleItems> Items { get; set; }
                public class UpdateChecklistRuleResponseBodyDataRuleItems : TeaModel {
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
