// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsSearchResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PediaWordsSearchResponseBodyData> Data { get; set; }
        public class PediaWordsSearchResponseBodyData : TeaModel {
            [NameInMap("appLink")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataAppLink> AppLink { get; set; }
            public class PediaWordsSearchResponseBodyDataAppLink : TeaModel {
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

            [NameInMap("contactList")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataContactList> ContactList { get; set; }
            public class PediaWordsSearchResponseBodyDataContactList : TeaModel {
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public string AvatarMediaId { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

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

            [NameInMap("parentUuid")]
            [Validation(Required=false)]
            public long? ParentUuid { get; set; }

            [NameInMap("picList")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataPicList> PicList { get; set; }
            public class PediaWordsSearchResponseBodyDataPicList : TeaModel {
                [NameInMap("mediaIdUrl")]
                [Validation(Required=false)]
                public string MediaIdUrl { get; set; }

            }

            [NameInMap("relatedDoc")]
            [Validation(Required=false)]
            public List<PediaWordsSearchResponseBodyDataRelatedDoc> RelatedDoc { get; set; }
            public class PediaWordsSearchResponseBodyDataRelatedDoc : TeaModel {
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
            public List<PediaWordsSearchResponseBodyDataRelatedLink> RelatedLink { get; set; }
            public class PediaWordsSearchResponseBodyDataRelatedLink : TeaModel {
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

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public long? Uuid { get; set; }

            [NameInMap("wordAlias")]
            [Validation(Required=false)]
            public List<string> WordAlias { get; set; }

            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

            [NameInMap("wordParaphrase")]
            [Validation(Required=false)]
            public string WordParaphrase { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
