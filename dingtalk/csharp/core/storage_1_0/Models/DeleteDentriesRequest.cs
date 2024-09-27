// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DeleteDentriesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dentryIds")]
        [Validation(Required=false)]
        public List<string> DentryIds { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public DeleteDentriesRequestOption Option { get; set; }
        public class DeleteDentriesRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("toRecycleBin")]
            [Validation(Required=false)]
            public bool? ToRecycleBin { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
