// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetMultipartFileUploadInfosRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetMultipartFileUploadInfosRequestOption Option { get; set; }
        public class GetMultipartFileUploadInfosRequestOption : TeaModel {
            [NameInMap("preferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("partNumbers")]
        [Validation(Required=false)]
        public List<int?> PartNumbers { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
