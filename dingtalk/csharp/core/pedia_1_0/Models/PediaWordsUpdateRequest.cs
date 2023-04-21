// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsUpdateRequest : TeaModel {
        /// <summary>
        /// 相关应用
        /// </summary>
        [NameInMap("appLink")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestAppLink> AppLink { get; set; }
        public class PediaWordsUpdateRequestAppLink : TeaModel {
            /// <summary>
            /// 应用名称
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// icon地址
            /// </summary>
            [NameInMap("iconLink")]
            [Validation(Required=false)]
            public string IconLink { get; set; }

            /// <summary>
            /// 电脑端地址
            /// </summary>
            [NameInMap("pcLink")]
            [Validation(Required=false)]
            public string PcLink { get; set; }

            /// <summary>
            /// 手机端地址
            /// </summary>
            [NameInMap("phoneLink")]
            [Validation(Required=false)]
            public string PhoneLink { get; set; }

        }

        /// <summary>
        /// 相关联系人
        /// </summary>
        [NameInMap("contactList")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestContactList> ContactList { get; set; }
        public class PediaWordsUpdateRequestContactList : TeaModel {
            /// <summary>
            /// 联系人图片地址，可以不传
            /// </summary>
            [NameInMap("avatarMediaId")]
            [Validation(Required=false)]
            public string AvatarMediaId { get; set; }

            /// <summary>
            /// 名称，可空
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// 联系人的组织员工编号
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 在聊天中可命中的别名
        /// </summary>
        [NameInMap("highLightWordAlias")]
        [Validation(Required=false)]
        public List<string> HighLightWordAlias { get; set; }

        /// <summary>
        /// 相关图片
        /// </summary>
        [NameInMap("picList")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestPicList> PicList { get; set; }
        public class PediaWordsUpdateRequestPicList : TeaModel {
            /// <summary>
            /// 图片地址，Http
            /// </summary>
            [NameInMap("mediaIdUrl")]
            [Validation(Required=false)]
            public string MediaIdUrl { get; set; }

        }

        /// <summary>
        /// 相关文档，支持钉钉在线文档
        /// </summary>
        [NameInMap("relatedDoc")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestRelatedDoc> RelatedDoc { get; set; }
        public class PediaWordsUpdateRequestRelatedDoc : TeaModel {
            /// <summary>
            /// 在线文档链接
            /// </summary>
            [NameInMap("link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// 文档名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 文档类型，adoc或者asheet字段
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 相关链接
        /// </summary>
        [NameInMap("relatedLink")]
        [Validation(Required=false)]
        public List<PediaWordsUpdateRequestRelatedLink> RelatedLink { get; set; }
        public class PediaWordsUpdateRequestRelatedLink : TeaModel {
            /// <summary>
            /// 链接地址
            /// </summary>
            [NameInMap("link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// 链接名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 操作人的组织员工编号
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 更新的词条编号
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public long? Uuid { get; set; }

        /// <summary>
        /// 词条别名
        /// </summary>
        [NameInMap("wordAlias")]
        [Validation(Required=false)]
        public List<string> WordAlias { get; set; }

        /// <summary>
        /// 词条名称
        /// </summary>
        [NameInMap("wordName")]
        [Validation(Required=false)]
        public string WordName { get; set; }

        /// <summary>
        /// 词条释义
        /// </summary>
        [NameInMap("wordParaphrase")]
        [Validation(Required=false)]
        public string WordParaphrase { get; set; }

    }

}
