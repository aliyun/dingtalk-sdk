// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class SignEnterpriseAccountRequest extends TeaModel {
    @NameInMap("bankCardNo")
    public String bankCardNo;

    @NameInMap("bankOpenId")
    public String bankOpenId;

    @NameInMap("operator")
    public String operator;

    @NameInMap("signOperateType")
    public String signOperateType;

    public static SignEnterpriseAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        SignEnterpriseAccountRequest self = new SignEnterpriseAccountRequest();
        return TeaModel.build(map, self);
    }

    public SignEnterpriseAccountRequest setBankCardNo(String bankCardNo) {
        this.bankCardNo = bankCardNo;
        return this;
    }
    public String getBankCardNo() {
        return this.bankCardNo;
    }

    public SignEnterpriseAccountRequest setBankOpenId(String bankOpenId) {
        this.bankOpenId = bankOpenId;
        return this;
    }
    public String getBankOpenId() {
        return this.bankOpenId;
    }

    public SignEnterpriseAccountRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public SignEnterpriseAccountRequest setSignOperateType(String signOperateType) {
        this.signOperateType = signOperateType;
        return this;
    }
    public String getSignOperateType() {
        return this.signOperateType;
    }

}
