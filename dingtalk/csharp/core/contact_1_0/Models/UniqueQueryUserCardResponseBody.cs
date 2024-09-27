// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UniqueQueryUserCardResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>@lADPD2sQxoYs677NAavNAao</para>
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CARD-6F0DA174-A0F4-4EBF-B24B-5FDFA648D25E</para>
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>工业</para>
        /// </summary>
        [NameInMap("industryName")]
        [Validation(Required=false)]
        public string IndustryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我是谁</para>
        /// </summary>
        [NameInMap("introduce")]
        [Validation(Required=false)]
        public string Introduce { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试企业</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Settings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>163520027_5FE66C522EA142C8r7Abf7VY</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
