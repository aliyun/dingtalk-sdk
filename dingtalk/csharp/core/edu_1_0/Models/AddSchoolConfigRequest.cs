// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddSchoolConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>操作人id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>操作人名称</para>
        /// </summary>
        [NameInMap("operatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测温上限</para>
        /// </summary>
        [NameInMap("temperatureUpLimit")]
        [Validation(Required=false)]
        public long? TemperatureUpLimit { get; set; }

    }

}
