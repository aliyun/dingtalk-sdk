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
        /**
         * <p>授予时间 时间戳</p>
         */
        @NameInMap("grantTime")
        public Long grantTime;

        /**
         * <p>必须。荣誉发放人userid</p>
         */
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
        /**
         * <p>有效期截止时间点，没有该属性则为永久生效</p>
         */
        @NameInMap("expirationTime")
        public Long expirationTime;

        /**
         * <p>授予历史记录 包含用户及授予时间</p>
         */
        @NameInMap("grantHistory")
        public java.util.List<QueryUserHonorsResponseBodyResultHonorsGrantHistory> grantHistory;

        /**
         * <p>荣誉含义</p>
         */
        @NameInMap("honorDesc")
        public String honorDesc;

        /**
         * <p>必须。荣誉id</p>
         */
        @NameInMap("honorId")
        public String honorId;

        /**
         * <p>必须。荣誉名字</p>
         */
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
