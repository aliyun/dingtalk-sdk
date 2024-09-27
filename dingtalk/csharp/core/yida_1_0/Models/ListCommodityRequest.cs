// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListCommodityRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>accessKey</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>callerUid</para>
        /// </summary>
        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>currentPage</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pageSize</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
