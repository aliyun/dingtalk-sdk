// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QueryUserAvailableDiyTemplatesResponseBody : TeaModel {
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("orgDiyTemplates")]
        [Validation(Required=false)]
        public List<QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates> OrgDiyTemplates { get; set; }
        public class QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

        }

        [NameInMap("userDiyTemplates")]
        [Validation(Required=false)]
        public List<QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates> UserDiyTemplates { get; set; }
        public class QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

        }

    }

}
