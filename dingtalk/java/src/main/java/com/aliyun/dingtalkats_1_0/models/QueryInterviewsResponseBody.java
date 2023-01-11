// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryInterviewsResponseBody extends TeaModel {
    /**
     * <p>是否有更多数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>数据列表</p>
     */
    @NameInMap("list")
    public java.util.List<QueryInterviewsResponseBodyList> list;

    /**
     * <p>下次查询的分页游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
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
         * <p>面试官员工标识</p>
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
         * <p>面试是否已取消</p>
         */
        @NameInMap("cancelled")
        public Boolean cancelled;

        /**
         * <p>面试创建人员工标识</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>面试结束时间（单位：毫秒）</p>
         */
        @NameInMap("endTimeMillis")
        public Long endTimeMillis;

        /**
         * <p>面试标识</p>
         */
        @NameInMap("interviewId")
        public String interviewId;

        /**
         * <p>面试官列表</p>
         */
        @NameInMap("interviewers")
        public java.util.List<QueryInterviewsResponseBodyListInterviewers> interviewers;

        /**
         * <p>职位标识</p>
         */
        @NameInMap("jobId")
        public String jobId;

        /**
         * <p>面试开始时间（单位：毫秒）</p>
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
