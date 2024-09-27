// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidenceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101户</para>
        /// </summary>
        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("destitute")]
        [Validation(Required=false)]
        public bool? Destitute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>第1网格</para>
        /// </summary>
        [NameInMap("grid")]
        [Validation(Required=false)]
        public string Grid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16612345678</para>
        /// </summary>
        [NameInMap("homeTel")]
        [Validation(Required=false)]
        public string HomeTel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("managerUserId")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public long? ParentDepartmentId { get; set; }

    }

}
