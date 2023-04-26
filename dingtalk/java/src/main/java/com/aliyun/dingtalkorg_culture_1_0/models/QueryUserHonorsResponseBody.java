// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryUserHonorsResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryUserHonorsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryUserHonorsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserHonorsResponseBody self = new QueryUserHonorsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserHonorsResponseBody setResult(QueryUserHonorsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryUserHonorsResponseBodyResult getResult() {
        return this.result;
    }

    public QueryUserHonorsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUserHonorsResponseBodyResultHonorsGrantHistory extends TeaModel {
        @NameInMap("grantTime")
        public Long grantTime;

        @NameInMap("senderUserid")
        public String senderUserid;

        public static QueryUserHonorsResponseBodyResultHonorsGrantHistory build(java.util.Map<String, ?> map) throws Exception {
            QueryUserHonorsResponseBodyResultHonorsGrantHistory self = new QueryUserHonorsResponseBodyResultHonorsGrantHistory();
            return TeaModel.build(map, self);
        }

        public QueryUserHonorsResponseBodyResultHonorsGrantHistory setGrantTime(Long grantTime) {
            this.grantTime = grantTime;
            return this;
        }
        public Long getGrantTime() {
            return this.grantTime;
        }

        public QueryUserHonorsResponseBodyResultHonorsGrantHistory setSenderUserid(String senderUserid) {
            this.senderUserid = senderUserid;
            return this;
        }
        public String getSenderUserid() {
            return this.senderUserid;
        }

    }

    public static class QueryUserHonorsResponseBodyResultHonors extends TeaModel {
        @NameInMap("expirationTime")
        public Long expirationTime;

        @NameInMap("grantHistory")
        public java.util.List<QueryUserHonorsResponseBodyResultHonorsGrantHistory> grantHistory;

        @NameInMap("honorDesc")
        public String honorDesc;

        @NameInMap("honorId")
        public String honorId;

        @NameInMap("honorName")
        public String honorName;

        public static QueryUserHonorsResponseBodyResultHonors build(java.util.Map<String, ?> map) throws Exception {
            QueryUserHonorsResponseBodyResultHonors self = new QueryUserHonorsResponseBodyResultHonors();
            return TeaModel.build(map, self);
        }

        public QueryUserHonorsResponseBodyResultHonors setExpirationTime(Long expirationTime) {
            this.expirationTime = expirationTime;
            return this;
        }
        public Long getExpirationTime() {
            return this.expirationTime;
        }

        public QueryUserHonorsResponseBodyResultHonors setGrantHistory(java.util.List<QueryUserHonorsResponseBodyResultHonorsGrantHistory> grantHistory) {
            this.grantHistory = grantHistory;
            return this;
        }
        public java.util.List<QueryUserHonorsResponseBodyResultHonorsGrantHistory> getGrantHistory() {
            return this.grantHistory;
        }

        public QueryUserHonorsResponseBodyResultHonors setHonorDesc(String honorDesc) {
            this.honorDesc = honorDesc;
            return this;
        }
        public String getHonorDesc() {
            return this.honorDesc;
        }

        public QueryUserHonorsResponseBodyResultHonors setHonorId(String honorId) {
            this.honorId = honorId;
            return this;
        }
        public String getHonorId() {
            return this.honorId;
        }

        public QueryUserHonorsResponseBodyResultHonors setHonorName(String honorName) {
            this.honorName = honorName;
            return this;
        }
        public String getHonorName() {
            return this.honorName;
        }

    }

    public static class QueryUserHonorsResponseBodyResult extends TeaModel {
        @NameInMap("honors")
        public java.util.List<QueryUserHonorsResponseBodyResultHonors> honors;

        @NameInMap("nextToken")
        public String nextToken;

        public static QueryUserHonorsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserHonorsResponseBodyResult self = new QueryUserHonorsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserHonorsResponseBodyResult setHonors(java.util.List<QueryUserHonorsResponseBodyResultHonors> honors) {
            this.honors = honors;
            return this;
        }
        public java.util.List<QueryUserHonorsResponseBodyResultHonors> getHonors() {
            return this.honors;
        }

        public QueryUserHonorsResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
