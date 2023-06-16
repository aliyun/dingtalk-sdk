// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class QueryCallConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryCallConfigResponseBodyResult> result;

    public static QueryCallConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCallConfigResponseBody self = new QueryCallConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCallConfigResponseBody setResult(java.util.List<QueryCallConfigResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryCallConfigResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryCallConfigResponseBodyResult extends TeaModel {
        @NameInMap("accountDomain")
        public String accountDomain;

        @NameInMap("accountId")
        public String accountId;

        @NameInMap("callInType")
        public Integer callInType;

        @NameInMap("callOutType")
        public Integer callOutType;

        @NameInMap("createUid")
        public String createUid;

        @NameInMap("phoneNumber")
        public String phoneNumber;

        @NameInMap("scopeType")
        public String scopeType;

        @NameInMap("showType")
        public Integer showType;

        @NameInMap("sourceType")
        public String sourceType;

        @NameInMap("status")
        public Integer status;

        public static QueryCallConfigResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryCallConfigResponseBodyResult self = new QueryCallConfigResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryCallConfigResponseBodyResult setAccountDomain(String accountDomain) {
            this.accountDomain = accountDomain;
            return this;
        }
        public String getAccountDomain() {
            return this.accountDomain;
        }

        public QueryCallConfigResponseBodyResult setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public QueryCallConfigResponseBodyResult setCallInType(Integer callInType) {
            this.callInType = callInType;
            return this;
        }
        public Integer getCallInType() {
            return this.callInType;
        }

        public QueryCallConfigResponseBodyResult setCallOutType(Integer callOutType) {
            this.callOutType = callOutType;
            return this;
        }
        public Integer getCallOutType() {
            return this.callOutType;
        }

        public QueryCallConfigResponseBodyResult setCreateUid(String createUid) {
            this.createUid = createUid;
            return this;
        }
        public String getCreateUid() {
            return this.createUid;
        }

        public QueryCallConfigResponseBodyResult setPhoneNumber(String phoneNumber) {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public String getPhoneNumber() {
            return this.phoneNumber;
        }

        public QueryCallConfigResponseBodyResult setScopeType(String scopeType) {
            this.scopeType = scopeType;
            return this;
        }
        public String getScopeType() {
            return this.scopeType;
        }

        public QueryCallConfigResponseBodyResult setShowType(Integer showType) {
            this.showType = showType;
            return this;
        }
        public Integer getShowType() {
            return this.showType;
        }

        public QueryCallConfigResponseBodyResult setSourceType(String sourceType) {
            this.sourceType = sourceType;
            return this;
        }
        public String getSourceType() {
            return this.sourceType;
        }

        public QueryCallConfigResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
