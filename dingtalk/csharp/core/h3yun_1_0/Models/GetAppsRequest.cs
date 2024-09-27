// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAppsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
