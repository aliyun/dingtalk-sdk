// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsAddRequest : TeaModel {
        [NameInMap("contactList")]
        [Validation(Required=false)]
        public List<PediaWordsAddRequestContactList> ContactList { get; set; }
        public class PediaWordsAddRequestContactList : TeaModel {
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

        [NameInMap("highLightWordAlias")]
        [Validation(Required=false)]
        public List<string> HighLightWordAlias { get; set; }

        [NameInMap("picList")]
        [Validation(Required=false)]
        public List<PediaWordsAddRequestPicList> PicList { get; set; }
        public class PediaWordsAddRequestPicList : TeaModel {
            [NameInMap("mediaIdUrl")]
            [Validation(Required=false)]
            public string MediaIdUrl { get; set; }

        }

        [NameInMap("relatedDoc")]
        [Validation(Required=false)]
        public List<PediaWordsAddRequestRelatedDoc> RelatedDoc { get; set; }
        public class PediaWordsAddRequestRelatedDoc : TeaModel {
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
        public List<PediaWordsAddRequestRelatedLink> RelatedLink { get; set; }
        public class PediaWordsAddRequestRelatedLink : TeaModel {
            [NameInMap("link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

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

}
