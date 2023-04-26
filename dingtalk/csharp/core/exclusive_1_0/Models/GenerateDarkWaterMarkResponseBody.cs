// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GenerateDarkWaterMarkResponseBody : TeaModel {
        [NameInMap("darkWatermarkVOList")]
        [Validation(Required=false)]
        public List<GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList> DarkWatermarkVOList { get; set; }
        public class GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList : TeaModel {
            [NameInMap("darkWatermark")]
            [Validation(Required=false)]
            public string DarkWatermark { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
