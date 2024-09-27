// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncSecretKeyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD</para>
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dnsuuiwenudsjid</para>
        /// </summary>
        [NameInMap("secretString")]
        [Validation(Required=false)]
        public string SecretString { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding001</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingduisdvfd</para>
        /// </summary>
        [NameInMap("tripAppKey")]
        [Validation(Required=false)]
        public string TripAppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dhsuibdusijue</para>
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

}
