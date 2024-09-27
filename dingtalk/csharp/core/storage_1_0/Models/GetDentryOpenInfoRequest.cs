// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryOpenInfoRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetDentryOpenInfoRequestOption Option { get; set; }
        public class GetDentryOpenInfoRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("checkLogin")]
            [Validation(Required=false)]
            public bool? CheckLogin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PREVIEW</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("waterMark")]
            [Validation(Required=false)]
            public bool? WaterMark { get; set; }

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
