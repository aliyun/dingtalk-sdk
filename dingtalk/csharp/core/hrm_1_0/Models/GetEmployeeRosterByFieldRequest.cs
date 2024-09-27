// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetEmployeeRosterByFieldRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("appAgentId")]
        [Validation(Required=false)]
        public long? AppAgentId { get; set; }

        [NameInMap("fieldFilterList")]
        [Validation(Required=false)]
        public List<string> FieldFilterList { get; set; }

        [NameInMap("text2SelectConvert")]
        [Validation(Required=false)]
        public bool? Text2SelectConvert { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
