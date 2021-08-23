// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListDeptUsersRequest : TeaModel {
        /// <summary>
        /// cursor
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        /// <summary>
        /// size
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// containAccessLimit
        /// </summary>
        [NameInMap("containAccessLimit")]
        [Validation(Required=false)]
        public bool? ContainAccessLimit { get; set; }

        /// <summary>
        /// subCorpId
        /// </summary>
        [NameInMap("subCorpId")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// language
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// orderField
        /// </summary>
        [NameInMap("orderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

    }

}
