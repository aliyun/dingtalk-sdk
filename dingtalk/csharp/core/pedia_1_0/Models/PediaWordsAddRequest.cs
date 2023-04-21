// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsAddRequest : TeaModel {
        /// <summary>
        /// 联系人列表
        /// 
        /// </summary>
        [NameInMap("contactList")]
        [Validation(Required=false)]
        public List<PediaWordsAddRequestContactList> ContactList { get; set; }
        public class PediaWordsAddRequestContactList : TeaModel {
            /// <summary>
            /// 头像地址也可以忽略
            /// </summary>
            [NameInMap("avatarMediaId")]
            [Validation(Required=false)]
            public string AvatarMediaId { get; set; }

            /// <summary>
            /// 名称可以忽略
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// 联系人的组织员工编号，开放平台员工信息接口获取userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 高亮的别名，从别名中选取，不在别名列表中不展示
        /// </summary>
        [NameInMap("highLightWordAlias")]
        [Validation(Required=false)]
        public List<string> HighLightWordAlias { get; set; }

        /// <summary>
        /// 相关图片
        /// 
        /// </summary>
        [NameInMap("picList")]
        [Validation(Required=false)]
        public List<PediaWordsAddRequestPicList> PicList { get; set; }
        public class PediaWordsAddRequestPicList : TeaModel {
            /// <summary>
            /// 图片的HTTP地址
            /// 
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
        public List<PediaWordsAddRequestRelatedDoc> RelatedDoc { get; set; }
        public class PediaWordsAddRequestRelatedDoc : TeaModel {
            /// <summary>
            /// 文档地址
            /// 
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
        public List<PediaWordsAddRequestRelatedLink> RelatedLink { get; set; }
        public class PediaWordsAddRequestRelatedLink : TeaModel {
            /// <summary>
            /// 链接地址
            /// 
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
        /// 组织对应的员工编号
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 词条的别名，多个名字的时候可以添加
        /// 
        /// </summary>
        [NameInMap("wordAlias")]
        [Validation(Required=false)]
        public List<string> WordAlias { get; set; }

        /// <summary>
        /// 新增词条的名称
        /// </summary>
        [NameInMap("wordName")]
        [Validation(Required=false)]
        public string WordName { get; set; }

        /// <summary>
        /// 词条释义，针对词条的描述内容
        /// 
        /// </summary>
        [NameInMap("wordParaphrase")]
        [Validation(Required=false)]
        public string WordParaphrase { get; set; }

    }

}
