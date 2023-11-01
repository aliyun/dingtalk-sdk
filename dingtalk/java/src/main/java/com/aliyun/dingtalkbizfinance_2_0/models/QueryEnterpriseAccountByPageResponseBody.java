// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

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
        @NameInMap("accountCode")
        public String accountCode;

        @NameInMap("accountId")
        public String accountId;

        @NameInMap("accountName")
        public String accountName;

        @NameInMap("accountRemark")
        public String accountRemark;

        @NameInMap("accountType")
        public String accountType;

        @NameInMap("amount")
        public String amount;

        @NameInMap("bankCode")
        public String bankCode;

        @NameInMap("bankName")
        public String bankName;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("creator")
        public String creator;

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

    }

}
