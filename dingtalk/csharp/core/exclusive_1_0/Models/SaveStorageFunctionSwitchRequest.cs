// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveStorageFunctionSwitchRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("functionList")]
        [Validation(Required=false)]
        public List<SaveStorageFunctionSwitchRequestFunctionList> FunctionList { get; set; }
        public class SaveStorageFunctionSwitchRequestFunctionList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("functionKey")]
            [Validation(Required=false)]
            public string FunctionKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("functionValue")]
            [Validation(Required=false)]
            public string FunctionValue { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
