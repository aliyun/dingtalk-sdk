// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryInterviewsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryInterviewsResponseBodyList> list;

    /**
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>总数量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryInterviewsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInterviewsResponseBody self = new QueryInterviewsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInterviewsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryInterviewsResponseBody setList(java.util.List<QueryInterviewsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryInterviewsResponseBodyList> getList() {
        return this.list;
    }

    public QueryInterviewsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryInterviewsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryInterviewsResponseBodyListInterviewers extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxx</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryInterviewsResponseBodyListInterviewers build(java.util.Map<String, ?> map) throws Exception {
            QueryInterviewsResponseBodyListInterviewers self = new QueryInterviewsResponseBodyListInterviewers();
            return TeaModel.build(map, self);
        }

        public QueryInterviewsResponseBodyListInterviewers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryInterviewsResponseBodyList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("cancelled")
        public Boolean cancelled;

        /**
         * <strong>example:</strong>
         * <p>xxx</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>1626861600000</p>
         */
        @NameInMap("endTimeMillis")
        public Long endTimeMillis;

        /**
         * <strong>example:</strong>
         * <p>xxx</p>
         */
        @NameInMap("interviewId")
        public String interviewId;

        @NameInMap("interviewers")
        public java.util.List<QueryInterviewsResponseBodyListInterviewers> interviewers;

        /**
         * <strong>example:</strong>
         * <p>xxx</p>
         */
        @NameInMap("jobId")
        public String jobId;

        /**
         * <strong>example:</strong>
         * <p>1626858000000</p>
         */
        @NameInMap("startTimeMillis")
        public Long startTimeMillis;

        public static QueryInterviewsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryInterviewsResponseBodyList self = new QueryInterviewsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryInterviewsResponseBodyList setCancelled(Boolean cancelled) {
            this.cancelled = cancelled;
            return this;
        }
        public Boolean getCancelled() {
            return this.cancelled;
        }

        public QueryInterviewsResponseBodyList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryInterviewsResponseBodyList setEndTimeMillis(Long endTimeMillis) {
            this.endTimeMillis = endTimeMillis;
            return this;
        }
        public Long getEndTimeMillis() {
            return this.endTimeMillis;
        }

        public QueryInterviewsResponseBodyList setInterviewId(String interviewId) {
            this.interviewId = interviewId;
            return this;
        }
        public String getInterviewId() {
            return this.interviewId;
        }

        public QueryInterviewsResponseBodyList setInterviewers(java.util.List<QueryInterviewsResponseBodyListInterviewers> interviewers) {
            this.interviewers = interviewers;
            return this;
        }
        public java.util.List<QueryInterviewsResponseBodyListInterviewers> getInterviewers() {
            return this.interviewers;
        }

        public QueryInterviewsResponseBodyList setJobId(String jobId) {
            this.jobId = jobId;
            return this;
        }
        public String getJobId() {
            return this.jobId;
        }

        public QueryInterviewsResponseBodyList setStartTimeMillis(Long startTimeMillis) {
            this.startTimeMillis = startTimeMillis;
            return this;
        }
        public Long getStartTimeMillis() {
            return this.startTimeMillis;
        }

    }

}
