// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class SearchResidentRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("residentCropId")]
        [Validation(Required=false)]
        public string ResidentCropId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("searchWord")]
        [Validation(Required=false)]
        public string SearchWord { get; set; }

    }

}
