// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPayAccountListResponseBody extends TeaModel {
    // 账号列表
    @NameInMap("payAccountVOList")
    public java.util.List<QueryPayAccountListResponseBodyPayAccountVOList> payAccountVOList;

    public static QueryPayAccountListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPayAccountListResponseBody self = new QueryPayAccountListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPayAccountListResponseBody setPayAccountVOList(java.util.List<QueryPayAccountListResponseBodyPayAccountVOList> payAccountVOList) {
        this.payAccountVOList = payAccountVOList;
        return this;
    }
    public java.util.List<QueryPayAccountListResponseBodyPayAccountVOList> getPayAccountVOList() {
        return this.payAccountVOList;
    }

    public static class QueryPayAccountListResponseBodyPayAccountVOList extends TeaModel {
        // 付款账号（脱敏）
        @NameInMap("accountNo")
        public String accountNo;

        // 账号名称
        @NameInMap("accountName")
        public String accountName;

        // 账户类型
        @NameInMap("accountType")
        public String accountType;

        // 账户备注
        @NameInMap("accountRemark")
        public String accountRemark;

        // 账号唯一id
        @NameInMap("accountId")
        public String accountId;

        // 账户分类
        @NameInMap("accountClass")
        public String accountClass;

        public static QueryPayAccountListResponseBodyPayAccountVOList build(java.util.Map<String, ?> map) throws Exception {
            QueryPayAccountListResponseBodyPayAccountVOList self = new QueryPayAccountListResponseBodyPayAccountVOList();
            return TeaModel.build(map, self);
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountNo(String accountNo) {
            this.accountNo = accountNo;
            return this;
        }
        public String getAccountNo() {
            return this.accountNo;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountRemark(String accountRemark) {
            this.accountRemark = accountRemark;
            return this;
        }
        public String getAccountRemark() {
            return this.accountRemark;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountClass(String accountClass) {
            this.accountClass = accountClass;
            return this;
        }
        public String getAccountClass() {
            return this.accountClass;
        }

    }

}
