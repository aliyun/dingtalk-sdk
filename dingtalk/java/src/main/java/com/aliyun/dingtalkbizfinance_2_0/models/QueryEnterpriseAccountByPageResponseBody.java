// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountByPageResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("list")
    public java.util.List<QueryEnterpriseAccountByPageResponseBodyList> list;

    public static QueryEnterpriseAccountByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseAccountByPageResponseBody self = new QueryEnterpriseAccountByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseAccountByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryEnterpriseAccountByPageResponseBody setList(java.util.List<QueryEnterpriseAccountByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryEnterpriseAccountByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryEnterpriseAccountByPageResponseBodyList extends TeaModel {
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
         * <p>网商银行</p>
         */
        @NameInMap("accountName")
        public String accountName;

        /**
         * <strong>example:</strong>
         * <p>test</p>
         */
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

        /**
         * <strong>example:</strong>
         * <p>10000.33</p>
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
         * <p>aaa</p>
         */
        @NameInMap("creator")
        public String creator;

        @NameInMap("signStatus")
        public String signStatus;

        @NameInMap("supportReceipt")
        public Boolean supportReceipt;

        @NameInMap("supportTradeDetail")
        public Boolean supportTradeDetail;

        public static QueryEnterpriseAccountByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryEnterpriseAccountByPageResponseBodyList self = new QueryEnterpriseAccountByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryEnterpriseAccountByPageResponseBodyList setAccountCode(String accountCode) {
            this.accountCode = accountCode;
            return this;
        }
        public String getAccountCode() {
            return this.accountCode;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setAccountRemark(String accountRemark) {
            this.accountRemark = accountRemark;
            return this;
        }
        public String getAccountRemark() {
            return this.accountRemark;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setSignStatus(String signStatus) {
            this.signStatus = signStatus;
            return this;
        }
        public String getSignStatus() {
            return this.signStatus;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setSupportReceipt(Boolean supportReceipt) {
            this.supportReceipt = supportReceipt;
            return this;
        }
        public Boolean getSupportReceipt() {
            return this.supportReceipt;
        }

        public QueryEnterpriseAccountByPageResponseBodyList setSupportTradeDetail(Boolean supportTradeDetail) {
            this.supportTradeDetail = supportTradeDetail;
            return this;
        }
        public Boolean getSupportTradeDetail() {
            return this.supportTradeDetail;
        }

    }

}
