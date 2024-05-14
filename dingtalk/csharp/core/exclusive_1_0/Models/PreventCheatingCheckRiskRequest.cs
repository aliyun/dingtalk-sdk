// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class PreventCheatingCheckRiskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("clientVer")]
        [Validation(Required=false)]
        public string ClientVer { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("platformVer")]
        [Validation(Required=false)]
        public string PlatformVer { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sec")]
        [Validation(Required=false)]
        public string Sec { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
