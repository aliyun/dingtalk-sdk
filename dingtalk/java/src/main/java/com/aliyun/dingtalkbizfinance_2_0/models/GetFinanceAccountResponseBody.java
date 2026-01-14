// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetFinanceAccountResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("accountCode")
    public String accountCode;

    /**
     * <strong>example:</strong>
     * <p><a href="mailto:test@alipay.com">test@alipay.com</a></p>
     */
    @NameInMap("accountId")
    public String accountId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试</p>
     */
    @NameInMap("accountName")
    public String accountName;

    @NameInMap("accountRemark")
    public String accountRemark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ALIPAY</p>
     */
    @NameInMap("accountType")
    public String accountType;

    @NameInMap("accountantBookIdList")
    public java.util.List<String> accountantBookIdList;

    /**
     * <strong>example:</strong>
     * <p>50000.55</p>
     */
    @NameInMap("amount")
    public String amount;

    @NameInMap("bankCode")
    public String bankCode;

    @NameInMap("bankName")
    public String bankName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1631526550994</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcdef</p>
     */
    @NameInMap("creator")
    public String creator;

    @NameInMap("officialName")
    public String officialName;

    @NameInMap("officialNumber")
    public String officialNumber;

    @NameInMap("signStatus")
    public String signStatus;

    @NameInMap("source")
    public String source;

    @NameInMap("status")
    public String status;

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

    public GetFinanceAccountResponseBody setAccountantBookIdList(java.util.List<String> accountantBookIdList) {
        this.accountantBookIdList = accountantBookIdList;
        return this;
    }
    public java.util.List<String> getAccountantBookIdList() {
        return this.accountantBookIdList;
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

    public GetFinanceAccountResponseBody setOfficialName(String officialName) {
        this.officialName = officialName;
        return this;
    }
    public String getOfficialName() {
        return this.officialName;
    }

    public GetFinanceAccountResponseBody setOfficialNumber(String officialNumber) {
        this.officialNumber = officialNumber;
        return this;
    }
    public String getOfficialNumber() {
        return this.officialNumber;
    }

    public GetFinanceAccountResponseBody setSignStatus(String signStatus) {
        this.signStatus = signStatus;
        return this;
    }
    public String getSignStatus() {
        return this.signStatus;
    }

    public GetFinanceAccountResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetFinanceAccountResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
