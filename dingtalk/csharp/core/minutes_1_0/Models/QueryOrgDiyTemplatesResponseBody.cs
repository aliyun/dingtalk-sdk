// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QueryOrgDiyTemplatesResponseBody : TeaModel {
        [NameInMap("diyTemplates")]
        [Validation(Required=false)]
        public List<QueryOrgDiyTemplatesResponseBodyDiyTemplates> DiyTemplates { get; set; }
        public class QueryOrgDiyTemplatesResponseBodyDiyTemplates : TeaModel {
            [NameInMap("acceptTimes")]
            [Validation(Required=false)]
            public long? AcceptTimes { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("diyTemplateBriefIntro")]
            [Validation(Required=false)]
            public string DiyTemplateBriefIntro { get; set; }

            [NameInMap("diyTemplateIconUrl")]
            [Validation(Required=false)]
            public string DiyTemplateIconUrl { get; set; }

            [NameInMap("diyTemplateKey")]
            [Validation(Required=false)]
            public string DiyTemplateKey { get; set; }

            [NameInMap("diyTemplateLatestVersion")]
            [Validation(Required=false)]
            public long? DiyTemplateLatestVersion { get; set; }

            [NameInMap("diyTemplateSource")]
            [Validation(Required=false)]
            public string DiyTemplateSource { get; set; }

            [NameInMap("diyTemplateTitle")]
            [Validation(Required=false)]
            public string DiyTemplateTitle { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
