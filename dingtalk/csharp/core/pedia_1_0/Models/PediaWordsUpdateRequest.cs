// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsUpdateRequest : TeaModel {
        [NameInMap("appLink")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestAppLink> AppLink { get; set; }
        public class PediaWordsUpdateRequestAppLink : TeaModel {
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

        [NameInMap("contactList")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestContactList> ContactList { get; set; }
        public class PediaWordsUpdateRequestContactList : TeaModel {
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
        public List<PediaWordsUpdateRequestPicList> PicList { get; set; }
        public class PediaWordsUpdateRequestPicList : TeaModel {
            [NameInMap("mediaIdUrl")]
            [Validation(Required=false)]
            public string MediaIdUrl { get; set; }

        }

        [NameInMap("relatedDoc")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestRelatedDoc> RelatedDoc { get; set; }
        public class PediaWordsUpdateRequestRelatedDoc : TeaModel {
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
        public List<PediaWordsUpdateRequestRelatedLink> RelatedLink { get; set; }
        public class PediaWordsUpdateRequestRelatedLink : TeaModel {
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

}
