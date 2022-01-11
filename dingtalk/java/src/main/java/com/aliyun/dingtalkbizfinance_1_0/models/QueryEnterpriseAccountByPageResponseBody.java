// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountByPageResponseBody extends TeaModel {
    // 是否还有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // resultList
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
        // 账户code
        @NameInMap("accountCode")
        public String accountCode;

        // 关联资金账号id
        @NameInMap("accountId")
        public String accountId;

        // 账户名称
        @NameInMap("accountName")
        public String accountName;

        // 备注
        @NameInMap("accountRemark")
        public String accountRemark;

        // 账户类型:ALIPAY, BANKCARD, CASH, WECHAT
        @NameInMap("accountType")
        public String accountType;

        // 账户总额，保留2位小数
        @NameInMap("amount")
        public String amount;

        // 创建时间
        @NameInMap("createTime")
        public Long createTime;

        // 创建人工号
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
