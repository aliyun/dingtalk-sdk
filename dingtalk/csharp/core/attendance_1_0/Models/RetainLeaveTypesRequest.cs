// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class RetainLeaveTypesRequest : TeaModel {
        [NameInMap("leaveCodes")]
        [Validation(Required=false)]
        public List<string> LeaveCodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager233</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

    }

}
