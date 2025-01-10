// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class AddCustomSignConfigRequest : TeaModel {
        [NameInMap("allEffect")]
        [Validation(Required=false)]
        public bool? AllEffect { get; set; }

        [NameInMap("canDownload")]
        [Validation(Required=false)]
        public bool? CanDownload { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx协议</para>
        /// </summary>
        [NameInMap("protocolName")]
        [Validation(Required=false)]
        public string ProtocolName { get; set; }

        [NameInMap("pushDeptIds")]
        [Validation(Required=false)]
        public List<string> PushDeptIds { get; set; }

        [NameInMap("pushStaffIds")]
        [Validation(Required=false)]
        public List<string> PushStaffIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("signTermFiles")]
        [Validation(Required=false)]
        public List<AddCustomSignConfigRequestSignTermFiles> SignTermFiles { get; set; }
        public class AddCustomSignConfigRequestSignTermFiles : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx协议说明</para>
        /// </summary>
        [NameInMap("termMessage")]
        [Validation(Required=false)]
        public string TermMessage { get; set; }

        [NameInMap("unpushDeptIds")]
        [Validation(Required=false)]
        public List<string> UnpushDeptIds { get; set; }

        [NameInMap("unpushStaffIds")]
        [Validation(Required=false)]
        public List<string> UnpushStaffIds { get; set; }

    }

}
