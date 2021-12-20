// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class SearchResidentRequest : TeaModel {
        [NameInMap("residentCropId")]
        [Validation(Required=false)]
        public string ResidentCropId { get; set; }

        [NameInMap("searchWord")]
        [Validation(Required=false)]
        public string SearchWord { get; set; }

    }

}
