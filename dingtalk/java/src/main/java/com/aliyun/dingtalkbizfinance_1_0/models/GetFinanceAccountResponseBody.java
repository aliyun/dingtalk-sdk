// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetFinanceAccountResponseBody extends TeaModel {
    /**
     * <p>账户code</p>
     */
    @NameInMap("accountCode")
    public String accountCode;

    /**
     * <p>关联资金账户id</p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>账户名称</p>
     */
    @NameInMap("accountName")
    public String accountName;

    /**
     * <p>备注</p>
     */
    @NameInMap("accountRemark")
    public String accountRemark;

    /**
     * <p>账户类型:ALIPAY, BANKCARD, CASH, WECHAT</p>
     */
    @NameInMap("accountType")
    public String accountType;

    /**
     * <p>账户总额，保留2位小数</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>银行代号，如果是银行卡类型，有值，其他类型时，为空</p>
     */
    @NameInMap("bankCode")
    public String bankCode;

    /**
     * <p>银行名称，如果是银行卡类型，有值，其他类型时，为空</p>
     */
    @NameInMap("bankName")
    public String bankName;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>创建人工号</p>
     */
    @NameInMap("creator")
    public String creator;

    public static GetFinanceAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFinanceAccountResponseBody self = new GetFinanceAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFinanceAccountResponseBody setAccountCode(String accountCode) {
        this.accountCode = accountCode;
        return this;
    }
    public String getAccountCode() {
        return this.accountCode;
    }

    public GetFinanceAccountResponseBody setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public GetFinanceAccountResponseBody setAccountName(String accountName) {
        this.accountName = accountName;
        return this;
    }
    public String getAccountName() {
        return this.accountName;
    }

    public GetFinanceAccountResponseBody setAccountRemark(String accountRemark) {
        this.accountRemark = accountRemark;
        return this;
    }
    public String getAccountRemark() {
        return this.accountRemark;
    }

    public GetFinanceAccountResponseBody setAccountType(String accountType) {
        this.accountType = accountType;
        return this;
    }
    public String getAccountType() {
        return this.accountType;
    }

    public GetFinanceAccountResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public GetFinanceAccountResponseBody setBankCode(String bankCode) {
        this.bankCode = bankCode;
        return this;
    }
    public String getBankCode() {
        return this.bankCode;
    }

    public GetFinanceAccountResponseBody setBankName(String bankName) {
        this.bankName = bankName;
        return this;
    }
    public String getBankName() {
        return this.bankName;
    }

    public GetFinanceAccountResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetFinanceAccountResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

}
