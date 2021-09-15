// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetFinanceAccountResponseBody extends TeaModel {
    // 账户code
    @NameInMap("accountCode")
    public String accountCode;

    // 关联资金账户id
    @NameInMap("accountId")
    public String accountId;

    // 账户类型:ALIPAY, BANKCARD, CASH, WECHAT
    @NameInMap("accountType")
    public String accountType;

    // 账户名称
    @NameInMap("accountName")
    public String accountName;

    // 备注
    @NameInMap("accountRemark")
    public String accountRemark;

    // 账户总额，保留2位小数
    @NameInMap("amount")
    public String amount;

    // 创建人工号
    @NameInMap("creator")
    public String creator;

    // 创建时间
    @NameInMap("createTime")
    public Long createTime;

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

    public GetFinanceAccountResponseBody setAccountType(String accountType) {
        this.accountType = accountType;
        return this;
    }
    public String getAccountType() {
        return this.accountType;
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

    public GetFinanceAccountResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public GetFinanceAccountResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public GetFinanceAccountResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

}
