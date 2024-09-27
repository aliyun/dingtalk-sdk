// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateSheetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sheet_id</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sheet_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>visible</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
