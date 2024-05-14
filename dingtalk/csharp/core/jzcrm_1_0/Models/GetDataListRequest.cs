// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class GetDataListRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public string Datatype { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pagesize")]
        [Validation(Required=false)]
        public long? Pagesize { get; set; }

    }

}
