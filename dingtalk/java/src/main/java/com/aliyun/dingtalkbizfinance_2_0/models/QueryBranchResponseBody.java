// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryBranchResponseBody extends TeaModel {
    @NameInMap("supportSubBanks")
    public java.util.List<QueryBranchResponseBodySupportSubBanks> supportSubBanks;

    public static QueryBranchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBranchResponseBody self = new QueryBranchResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBranchResponseBody setSupportSubBanks(java.util.List<QueryBranchResponseBodySupportSubBanks> supportSubBanks) {
        this.supportSubBanks = supportSubBanks;
        return this;
    }
    public java.util.List<QueryBranchResponseBodySupportSubBanks> getSupportSubBanks() {
        return this.supportSubBanks;
    }

    public static class QueryBranchResponseBodySupportSubBanks extends TeaModel {
        @NameInMap("branchCode")
        public String branchCode;

        @NameInMap("branchName")
        public String branchName;

        public static QueryBranchResponseBodySupportSubBanks build(java.util.Map<String, ?> map) throws Exception {
            QueryBranchResponseBodySupportSubBanks self = new QueryBranchResponseBodySupportSubBanks();
            return TeaModel.build(map, self);
        }

        public QueryBranchResponseBodySupportSubBanks setBranchCode(String branchCode) {
            this.branchCode = branchCode;
            return this;
        }
        public String getBranchCode() {
            return this.branchCode;
        }

        public QueryBranchResponseBodySupportSubBanks setBranchName(String branchName) {
            this.branchName = branchName;
            return this;
        }
        public String getBranchName() {
            return this.branchName;
        }

    }

}
