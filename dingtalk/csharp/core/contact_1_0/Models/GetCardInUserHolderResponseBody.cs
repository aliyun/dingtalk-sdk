// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetCardInUserHolderResponseBody : TeaModel {
        /// <summary>
        /// 头像
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 名片收下状态
        /// </summary>
        [NameInMap("cardAcceptStatus")]
        [Validation(Required=false)]
        public int? CardAcceptStatus { get; set; }

        [NameInMap("cardAcceptTimeLong")]
        [Validation(Required=false)]
        public long? CardAcceptTimeLong { get; set; }

        /// <summary>
        /// 名片ID
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extension { get; set; }

        /// <summary>
        /// 行业
        /// </summary>
        [NameInMap("industryName")]
        [Validation(Required=false)]
        public string IndustryName { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [NameInMap("introduce")]
        [Validation(Required=false)]
        public string Introduce { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
