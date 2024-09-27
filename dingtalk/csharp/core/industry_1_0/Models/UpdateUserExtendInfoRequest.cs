// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class UpdateUserExtendInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注, 当jobStatusCode为其他(0)时, 需要通过该字段补充状态</para>
        /// </summary>
        [NameInMap("comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("jobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        [NameInMap("jobStatusCode")]
        [Validation(Required=false)]
        public List<string> JobStatusCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userProbCode")]
        [Validation(Required=false)]
        public string UserProbCode { get; set; }

    }

}
