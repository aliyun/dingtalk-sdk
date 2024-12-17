// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class SetOrgConfigRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("appDisplayStyle")]
        [Validation(Required=false)]
        public int? AppDisplayStyle { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("homepageCatalogs")]
        [Validation(Required=false)]
        public List<string> HomepageCatalogs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
