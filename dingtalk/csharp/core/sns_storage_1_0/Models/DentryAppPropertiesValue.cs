// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksns_storage_1_0.Models
{
    public class DentryAppPropertiesValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>property_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>property_value</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
