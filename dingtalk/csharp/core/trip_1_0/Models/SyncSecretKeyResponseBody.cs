// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncSecretKeyResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SyncSecretKeyResponseBodyResult Result { get; set; }
        public class SyncSecretKeyResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dsiuuuuiasudnuai</para>
            /// </summary>
            [NameInMap("secretString")]
            [Validation(Required=false)]
            public string SecretString { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding001</para>
            /// </summary>
            [NameInMap("targetCorpId")]
            [Validation(Required=false)]
            public string TargetCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingwieudsiu</para>
            /// </summary>
            [NameInMap("tripAppKey")]
            [Validation(Required=false)]
            public string TripAppKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dusuduiidvs</para>
            /// </summary>
            [NameInMap("tripAppSecurity")]
            [Validation(Required=false)]
            public string TripAppSecurity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>isv001</para>
            /// </summary>
            [NameInMap("tripCorpId")]
            [Validation(Required=false)]
            public string TripCorpId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
