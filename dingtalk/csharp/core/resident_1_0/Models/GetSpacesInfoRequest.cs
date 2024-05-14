// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetSpacesInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("referIds")]
        [Validation(Required=false)]
        public List<long?> ReferIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("residentCorpId")]
        [Validation(Required=false)]
        public string ResidentCorpId { get; set; }

    }

}
