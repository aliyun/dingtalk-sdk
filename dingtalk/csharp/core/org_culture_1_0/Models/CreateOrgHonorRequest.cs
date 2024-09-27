// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class CreateOrgHonorRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$xxxxxxx</para>
        /// </summary>
        [NameInMap("avatarFrameMediaId")]
        [Validation(Required=false)]
        public string AvatarFrameMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#FFFBB4</para>
        /// </summary>
        [NameInMap("defaultBgColor")]
        [Validation(Required=false)]
        public string DefaultBgColor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户服务用心，奖励荣誉</para>
        /// </summary>
        [NameInMap("medalDesc")]
        [Validation(Required=false)]
        public string MedalDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@xxxxxxx</para>
        /// </summary>
        [NameInMap("medalMediaId")]
        [Validation(Required=false)]
        public string MedalMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户第一</para>
        /// </summary>
        [NameInMap("medalName")]
        [Validation(Required=false)]
        public string MedalName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312312</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
