// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class DeleteDirRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>oaDirIdxxx</para>
        /// </summary>
        [NameInMap("dirId")]
        [Validation(Required=false)]
        public string DirId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user001</para>
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

    }

}
