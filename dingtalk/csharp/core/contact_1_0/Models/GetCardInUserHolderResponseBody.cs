// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetCardInUserHolderResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("cardAcceptStatus")]
        [Validation(Required=false)]
        public int? CardAcceptStatus { get; set; }

        [NameInMap("cardAcceptTimeLong")]
        [Validation(Required=false)]
        public long? CardAcceptTimeLong { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cardSource")]
        [Validation(Required=false)]
        public int? CardSource { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extension { get; set; }

        [NameInMap("industryName")]
        [Validation(Required=false)]
        public string IndustryName { get; set; }

        [NameInMap("introduce")]
        [Validation(Required=false)]
        public string Introduce { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
