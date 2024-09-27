// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveStorageFunctionSwitchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15800000000</para>
        /// </summary>
        [NameInMap("functionList")]
        [Validation(Required=false)]
        public List<SaveStorageFunctionSwitchRequestFunctionList> FunctionList { get; set; }
        public class SaveStorageFunctionSwitchRequestFunctionList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("functionKey")]
            [Validation(Required=false)]
            public string FunctionKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("functionValue")]
            [Validation(Required=false)]
            public string FunctionValue { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxxxx</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
