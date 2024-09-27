// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TransformToExclusiveAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false/true</para>
        /// </summary>
        [NameInMap("idpDingTalk")]
        [Validation(Required=false)]
        public bool? IdpDingTalk { get; set; }

        [NameInMap("initPassword")]
        [Validation(Required=false)]
        public string InitPassword { get; set; }

        [NameInMap("loginId")]
        [Validation(Required=false)]
        public string LoginId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>migrate</para>
        /// </summary>
        [NameInMap("transformType")]
        [Validation(Required=false)]
        public string TransformType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
