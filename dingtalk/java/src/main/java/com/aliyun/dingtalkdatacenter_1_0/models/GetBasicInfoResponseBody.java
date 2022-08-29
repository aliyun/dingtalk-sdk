// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBasicInfoResponseBody extends TeaModel {
    // 返回结果
    // ENT_NAME:企业名称
    // LEGAL_NAME:法定代表人姓名
    // ES_DATE:开业日期
    // ENT_STATUS:经营状态
    // REG_CAP:注册资本
    // REC_CAP:实收资本
    // SOCIAL_CREDIT_CODE:统一社会信用代码
    // LICENSE_NUMBER:工商注册号
    // ORG_NO:组织机构代码
    // TAX_NUM:纳税人识别号
    // ENT_TYPE:企业类型
    // INDUSTRY_NAME_LV1:国民经济行业门类名称
    // INDUSTRY_NAME_LV2:国民经济行业大类名称
    // OP_FROM:经营期限自
    // OP_TO:经营期限至
    // COLLEGUES_NUM:人员规模
    // INSURED_NUM:参保人数
    // ENT_NAME_ENG:英文名称
    // FORMER_NAMES:曾用名
    // REG_ORG:登记机关
    // CHECK_DATE:核准日期
    // OP_SCOPE:经营范围
    // IDENTITY_ID:ID
    // ENT_ADDRESS:企业地址
    // EMPLOYEES_INFO:主要管理人员
    // ENT_BRIEF:公司简介
    // REG_ORG_PROVINCE:注册地址所在省
    // REG_ORG_CITY:注册地址所在城市
    // REG_ORG_DISTRICT:注册地址所在区县
    // STD_REG_CAP:清洗后注册资本
    @NameInMap("data")
    public String data;

    // 总条数
    @NameInMap("total")
    public Long total;

    public static GetBasicInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBasicInfoResponseBody self = new GetBasicInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBasicInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetBasicInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
