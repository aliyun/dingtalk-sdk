// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class SignEnterpriseAccountRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ACC_XXX</p>
     */
    @NameInMap("accountCode")
    public String accountCode;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("bankCardNo")
    public String bankCardNo;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("bankOpenId")
    public String bankOpenId;

    /**
     * <strong>example:</strong>
     * <p>COMM_UNIONPAY</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("channelType")
    public String channelType;

    /**
     * <strong>example:</strong>
     * <p>XXX</p>
     */
    @NameInMap("feeItemCode")
    public String feeItemCode;

    /**
     * <strong>example:</strong>
     * <p>XXXX</p>
     */
    @NameInMap("issueNo")
    public String issueNo;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <strong>example:</strong>
     * <p>signed</p>
     */
    @NameInMap("signOperateType")
    public String signOperateType;

    public static SignEnterpriseAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        SignEnterpriseAccountRequest self = new SignEnterpriseAccountRequest();
        return TeaModel.build(map, self);
    }

    public SignEnterpriseAccountRequest setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
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

    public SignEnterpriseAccountRequest setChannelType(String channelType) {
        this.channelType = channelType;
        return this;
    }
    public String getChannelType() {
        return this.channelType;
    }

    public SignEnterpriseAccountRequest setFeeItemCode(String feeItemCode) {
        this.feeItemCode = feeItemCode;
        return this;
    }
    public String getFeeItemCode() {
        return this.feeItemCode;
    }

    public SignEnterpriseAccountRequest setIssueNo(String issueNo) {
        this.issueNo = issueNo;
        return this;
    }
    public String getIssueNo() {
        return this.issueNo;
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
