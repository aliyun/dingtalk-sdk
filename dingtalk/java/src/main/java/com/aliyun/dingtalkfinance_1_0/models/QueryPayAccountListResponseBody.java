// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPayAccountListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>B</p>
         */
        @NameInMap("accountClass")
        public String accountClass;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>20210912001</p>
         */
        @NameInMap("accountId")
        public String accountId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>test</p>
         */
        @NameInMap("accountName")
        public String accountName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>139****1</p>
         */
        @NameInMap("accountNo")
        public String accountNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>备注</p>
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
