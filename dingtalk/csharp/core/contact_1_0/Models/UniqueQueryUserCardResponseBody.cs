// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UniqueQueryUserCardResponseBody : TeaModel {
        /// <summary>
        /// 图标
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 名片id
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extension { get; set; }

        /// <summary>
        /// 工业名
        /// </summary>
        [NameInMap("industryName")]
        [Validation(Required=false)]
        public string IndustryName { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        [NameInMap("introduce")]
        [Validation(Required=false)]
        public string Introduce { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 组织名
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
