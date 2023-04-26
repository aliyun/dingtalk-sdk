// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_1_0.Models
{
    public class WikiWordsDetailResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<WikiWordsDetailResponseBodyData> Data { get; set; }
        public class WikiWordsDetailResponseBodyData : TeaModel {
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataAppLink> AppLink { get; set; }
            public class WikiWordsDetailResponseBodyDataAppLink : TeaModel {
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("iconLink")]
                [Validation(Required=false)]
                public string IconLink { get; set; }

                [NameInMap("pcLink")]
                [Validation(Required=false)]
                public string PcLink { get; set; }

                [NameInMap("phoneLink")]
                [Validation(Required=false)]
                public string PhoneLink { get; set; }

            }

            [NameInMap("approveName")]
            [Validation(Required=false)]
            public string ApproveName { get; set; }

            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            [NameInMap("highLightWordAlias")]
            [Validation(Required=false)]
            public List<string> HighLightWordAlias { get; set; }

            [NameInMap("imHighLight")]
            [Validation(Required=false)]
            public bool? ImHighLight { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedDoc : TeaModel {
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("relatedLink")]
            [Validation(Required=false)]
            public List<WikiWordsDetailResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class WikiWordsDetailResponseBodyDataRelatedLink : TeaModel {
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("simHighLight")]
            [Validation(Required=false)]
            public bool? SimHighLight { get; set; }

            [NameInMap("simpleWordParaphrase")]
            [Validation(Required=false)]
            public string SimpleWordParaphrase { get; set; }

            [NameInMap("tagsList")]
            [Validation(Required=false)]
            public List<string> TagsList { get; set; }

            [NameInMap("updaterName")]
            [Validation(Required=false)]
            public string UpdaterName { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            [NameInMap("wordFullName")]
            [Validation(Required=false)]
            public string WordFullName { get; set; }

            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
