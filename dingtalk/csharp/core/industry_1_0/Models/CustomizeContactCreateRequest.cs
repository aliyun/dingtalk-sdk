// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CustomizeContactCreateRequest : TeaModel {
        [NameInMap("managerIdList")]
        [Validation(Required=false)]
        public List<string> ManagerIdList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

    }

}
