// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPayAccountListResponseBody extends TeaModel {
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
        @NameInMap("accountClass")
        public String accountClass;

        @NameInMap("accountId")
        public String accountId;

        @NameInMap("accountName")
        public String accountName;

        @NameInMap("accountNo")
        public String accountNo;

        @NameInMap("accountRemark")
        public String accountRemark;

        @NameInMap("accountType")
        public String accountType;

        public static QueryPayAccountListResponseBodyPayAccountVOList build(java.util.Map<String, ?> map) throws Exception {
            QueryPayAccountListResponseBodyPayAccountVOList self = new QueryPayAccountListResponseBodyPayAccountVOList();
            return TeaModel.build(map, self);
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountClass(String accountClass) {
            this.accountClass = accountClass;
            return this;
        }
        public String getAccountClass() {
            return this.accountClass;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountNo(String accountNo) {
            this.accountNo = accountNo;
            return this;
        }
        public String getAccountNo() {
            return this.accountNo;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountRemark(String accountRemark) {
            this.accountRemark = accountRemark;
            return this;
        }
        public String getAccountRemark() {
            return this.accountRemark;
        }

        public QueryPayAccountListResponseBodyPayAccountVOList setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

    }

}
