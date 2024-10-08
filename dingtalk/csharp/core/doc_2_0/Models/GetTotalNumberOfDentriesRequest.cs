// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetTotalNumberOfDentriesRequest : TeaModel {
        [NameInMap("includeFolder")]
        [Validation(Required=false)]
        public bool? IncludeFolder { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("spaceTypes")]
        [Validation(Required=false)]
        public string SpaceTypes { get; set; }

    }

}
