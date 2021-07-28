// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureJobBookResponseBody : TeaModel {
        /// <summary>
        /// content
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public IndustrializeManufactureJobBookResponseBodyContent Content { get; set; }
        public class IndustrializeManufactureJobBookResponseBodyContent : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }
        };

        /// <summary>
        /// 此次报工记录的唯一标识
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
