// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SearchTeachersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李</para>
        /// </summary>
        [NameInMap("nameKeyword")]
        [Validation(Required=false)]
        public string NameKeyword { get; set; }

    }

}
