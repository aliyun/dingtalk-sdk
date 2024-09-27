// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentriesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dentryIds")]
        [Validation(Required=false)]
        public List<string> DentryIds { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public GetDentriesRequestOption Option { get; set; }
        public class GetDentriesRequestOption : TeaModel {
            [NameInMap("appIdsForAppProperties")]
            [Validation(Required=false)]
            public List<string> AppIdsForAppProperties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("withThumbnail")]
            [Validation(Required=false)]
            public bool? WithThumbnail { get; set; }

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
