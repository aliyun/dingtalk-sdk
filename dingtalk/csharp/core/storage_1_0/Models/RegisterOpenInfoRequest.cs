// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RegisterOpenInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openInfos")]
        [Validation(Required=false)]
        public List<RegisterOpenInfoRequestOpenInfos> OpenInfos { get; set; }
        public class RegisterOpenInfoRequestOpenInfos : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openType")]
            [Validation(Required=false)]
            public string OpenType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
