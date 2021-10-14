// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TransformToExclusiveAccountRequest : TeaModel {
        /// <summary>
        /// idpDingTalk
        /// </summary>
        [NameInMap("idpDingTalk")]
        [Validation(Required=false)]
        public bool? IdpDingTalk { get; set; }

        /// <summary>
        /// initPassword
        /// </summary>
        [NameInMap("initPassword")]
        [Validation(Required=false)]
        public string InitPassword { get; set; }

        /// <summary>
        /// loginId
        /// </summary>
        [NameInMap("loginId")]
        [Validation(Required=false)]
        public string LoginId { get; set; }

        /// <summary>
        /// transformType
        /// </summary>
        [NameInMap("transformType")]
        [Validation(Required=false)]
        public string TransformType { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
