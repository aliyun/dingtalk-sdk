// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfOrgResp : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public string DeptCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>一级部门</para>
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/01</para>
        /// </summary>
        [NameInMap("organizationCodePath")]
        [Validation(Required=false)]
        public string OrganizationCodePath { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>公司/一级部门</para>
        /// </summary>
        [NameInMap("organizationPath")]
        [Validation(Required=false)]
        public string OrganizationPath { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("parentDeptCode")]
        [Validation(Required=false)]
        public string ParentDeptCode { get; set; }

    }

}
