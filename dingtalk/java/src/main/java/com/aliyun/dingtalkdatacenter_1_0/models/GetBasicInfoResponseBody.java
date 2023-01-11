// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBasicInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>ENT_NAME:企业名称</p>
     * <p>LEGAL_NAME:法定代表人姓名</p>
     * <p>ES_DATE:开业日期</p>
     * <p>ENT_STATUS:经营状态</p>
     * <p>REG_CAP:注册资本</p>
     * <p>REC_CAP:实收资本</p>
     * <p>SOCIAL_CREDIT_CODE:统一社会信用代码</p>
     * <p>LICENSE_NUMBER:工商注册号</p>
     * <p>ORG_NO:组织机构代码</p>
     * <p>TAX_NUM:纳税人识别号</p>
     * <p>ENT_TYPE:企业类型</p>
     * <p>INDUSTRY_NAME_LV1:国民经济行业门类名称</p>
     * <p>INDUSTRY_NAME_LV2:国民经济行业大类名称</p>
     * <p>OP_FROM:经营期限自</p>
     * <p>OP_TO:经营期限至</p>
     * <p>COLLEGUES_NUM:人员规模</p>
     * <p>INSURED_NUM:参保人数</p>
     * <p>ENT_NAME_ENG:英文名称</p>
     * <p>FORMER_NAMES:曾用名</p>
     * <p>REG_ORG:登记机关</p>
     * <p>CHECK_DATE:核准日期</p>
     * <p>OP_SCOPE:经营范围</p>
     * <p>IDENTITY_ID:ID</p>
     * <p>ENT_ADDRESS:企业地址</p>
     * <p>EMPLOYEES_INFO:主要管理人员</p>
     * <p>ENT_BRIEF:公司简介</p>
     * <p>REG_ORG_PROVINCE:注册地址所在省</p>
     * <p>REG_ORG_CITY:注册地址所在城市</p>
     * <p>REG_ORG_DISTRICT:注册地址所在区县</p>
     * <p>STD_REG_CAP:清洗后注册资本</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
