// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// ENT_NAME:企业名称
        /// LEGAL_NAME:法定代表人姓名
        /// ES_DATE:开业日期
        /// ENT_STATUS:经营状态
        /// REG_CAP:注册资本
        /// REC_CAP:实收资本
        /// SOCIAL_CREDIT_CODE:统一社会信用代码
        /// LICENSE_NUMBER:工商注册号
        /// ORG_NO:组织机构代码
        /// TAX_NUM:纳税人识别号
        /// ENT_TYPE:企业类型
        /// INDUSTRY_NAME_LV1:国民经济行业门类名称
        /// INDUSTRY_NAME_LV2:国民经济行业大类名称
        /// OP_FROM:经营期限自
        /// OP_TO:经营期限至
        /// COLLEGUES_NUM:人员规模
        /// INSURED_NUM:参保人数
        /// ENT_NAME_ENG:英文名称
        /// FORMER_NAMES:曾用名
        /// REG_ORG:登记机关
        /// CHECK_DATE:核准日期
        /// OP_SCOPE:经营范围
        /// IDENTITY_ID:ID
        /// ENT_ADDRESS:企业地址
        /// EMPLOYEES_INFO:主要管理人员
        /// ENT_BRIEF:公司简介
        /// REG_ORG_PROVINCE:注册地址所在省
        /// REG_ORG_CITY:注册地址所在城市
        /// REG_ORG_DISTRICT:注册地址所在区县
        /// STD_REG_CAP:清洗后注册资本
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
