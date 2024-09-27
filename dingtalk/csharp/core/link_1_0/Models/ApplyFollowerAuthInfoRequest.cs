// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ApplyFollowerAuthInfoRequest : TeaModel {
        [NameInMap("appAuthKey")]
        [Validation(Required=false)]
        public string AppAuthKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Contact.User.mobile</para>
        /// </summary>
        [NameInMap("fieldScope")]
        [Validation(Required=false)]
        public string FieldScope { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sid22b31b4bf59ef2c783f7</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idzb26bxl64vqx2keyi</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
