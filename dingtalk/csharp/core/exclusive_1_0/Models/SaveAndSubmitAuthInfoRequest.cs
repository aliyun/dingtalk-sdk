// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveAndSubmitAuthInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX组织申请高级认证</para>
        /// </summary>
        [NameInMap("applyRemark")]
        [Validation(Required=false)]
        public string ApplyRemark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA</para>
        /// </summary>
        [NameInMap("authorizeMediaId")]
        [Validation(Required=false)]
        public string AuthorizeMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>计算机</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>钉三多</para>
        /// </summary>
        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3301XX1997XXXXXXXXX</para>
        /// </summary>
        [NameInMap("legalPersonIdCard")]
        [Validation(Required=false)]
        public string LegalPersonIdCard { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA</para>
        /// </summary>
        [NameInMap("licenseMediaId")]
        [Validation(Required=false)]
        public string LicenseMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330100</para>
        /// </summary>
        [NameInMap("locCity")]
        [Validation(Required=false)]
        public long? LocCity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州</para>
        /// </summary>
        [NameInMap("locCityName")]
        [Validation(Required=false)]
        public string LocCityName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330000</para>
        /// </summary>
        [NameInMap("locProvince")]
        [Validation(Required=false)]
        public long? LocProvince { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江</para>
        /// </summary>
        [NameInMap("locProvinceName")]
        [Validation(Required=false)]
        public string LocProvinceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15869110714</para>
        /// </summary>
        [NameInMap("mobileNum")]
        [Validation(Required=false)]
        public string MobileNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试组织</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111111-1</para>
        /// </summary>
        [NameInMap("organizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA</para>
        /// </summary>
        [NameInMap("organizationCodeMediaId")]
        [Validation(Required=false)]
        public string OrganizationCodeMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>余杭区文一西路XX号</para>
        /// </summary>
        [NameInMap("registLocation")]
        [Validation(Required=false)]
        public string RegistLocation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1111111111111111</para>
        /// </summary>
        [NameInMap("registNum")]
        [Validation(Required=false)]
        public string RegistNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9111111XX2957XX4X</para>
        /// </summary>
        [NameInMap("unifiedSocialCredit")]
        [Validation(Required=false)]
        public string UnifiedSocialCredit { get; set; }

    }

}
