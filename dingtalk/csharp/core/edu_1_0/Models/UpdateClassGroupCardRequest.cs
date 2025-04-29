// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateClassGroupCardRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizCardId")]
        [Validation(Required=false)]
        public string BizCardId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("classId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupTypeList")]
        [Validation(Required=false)]
        public List<string> GroupTypeList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("isFinalUpdate")]
        [Validation(Required=false)]
        public bool? IsFinalUpdate { get; set; }

        [NameInMap("privateCardData")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> PrivateCardData { get; set; }

        [NameInMap("publicCardData")]
        [Validation(Required=false)]
        public Dictionary<string, string> PublicCardData { get; set; }

    }

}
