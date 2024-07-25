// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUnfurlingRegisterInfoResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryUnfurlingRegisterInfoResponseBodyList> List { get; set; }
        public class QueryUnfurlingRegisterInfoResponseBodyList : TeaModel {
            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("callbackType")]
            [Validation(Required=false)]
            public int? CallbackType { get; set; }

            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("grayGroupIdList")]
            [Validation(Required=false)]
            public List<string> GrayGroupIdList { get; set; }

            [NameInMap("grayUserIdList")]
            [Validation(Required=false)]
            public List<string> GrayUserIdList { get; set; }

            [NameInMap("hsfMethodName")]
            [Validation(Required=false)]
            public string HsfMethodName { get; set; }

            [NameInMap("hsfServiceName")]
            [Validation(Required=false)]
            public string HsfServiceName { get; set; }

            [NameInMap("hsfVersion")]
            [Validation(Required=false)]
            public string HsfVersion { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("ruleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            [NameInMap("ruleMatchType")]
            [Validation(Required=false)]
            public int? RuleMatchType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
