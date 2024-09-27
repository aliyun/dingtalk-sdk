// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class CreateDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan/password</para>
        /// </summary>
        [NameInMap("authInfo")]
        [Validation(Required=false)]
        public string AuthInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Acount</para>
        /// </summary>
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;workdate&quot;:&quot;workday&quot;}</para>
        /// </summary>
        [NameInMap("bizExt")]
        [Validation(Required=false)]
        public string BizExt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生产1组</para>
        /// </summary>
        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Primary</para>
        /// </summary>
        [NameInMap("departmentType")]
        [Validation(Required=false)]
        public string DepartmentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生产1组负责中控机的组装</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.xxx.com/manage">https://xxx.xxx.com/manage</a></para>
        /// </summary>
        [NameInMap("systemUrl")]
        [Validation(Required=false)]
        public string SystemUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager10</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
