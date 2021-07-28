// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryInterviewsResponseBody extends TeaModel {
    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    // 是否有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下次查询的分页游标
    @NameInMap("nextToken")
    public String nextToken;

    // 数据列表
    @NameInMap("list")
    public java.util.List<QueryInterviewsResponseBodyList> list;

    public static QueryInterviewsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInterviewsResponseBody self = new QueryInterviewsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInterviewsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryInterviewsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryInterviewsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryInterviewsResponseBody setList(java.util.List<QueryInterviewsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryInterviewsResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryInterviewsResponseBodyListInterviewers extends TeaModel {
        // 面试官员工标识
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
        // 面试标识
        @NameInMap("interviewId")
        public String interviewId;

        // 职位标识
        @NameInMap("jobId")
        public String jobId;

        // 面试开始时间（单位：毫秒）
        @NameInMap("startTimeMillis")
        public Long startTimeMillis;

        // 面试结束时间（单位：毫秒）
        @NameInMap("endTimeMillis")
        public Long endTimeMillis;

        // 面试创建人员工标识
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 面试官列表
        @NameInMap("interviewers")
        public java.util.List<QueryInterviewsResponseBodyListInterviewers> interviewers;

        public static QueryInterviewsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryInterviewsResponseBodyList self = new QueryInterviewsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryInterviewsResponseBodyList setInterviewId(String interviewId) {
            this.interviewId = interviewId;
            return this;
        }
        public String getInterviewId() {
            return this.interviewId;
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

        public QueryInterviewsResponseBodyList setEndTimeMillis(Long endTimeMillis) {
            this.endTimeMillis = endTimeMillis;
            return this;
        }
        public Long getEndTimeMillis() {
            return this.endTimeMillis;
        }

        public QueryInterviewsResponseBodyList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryInterviewsResponseBodyList setInterviewers(java.util.List<QueryInterviewsResponseBodyListInterviewers> interviewers) {
            this.interviewers = interviewers;
            return this;
        }
        public java.util.List<QueryInterviewsResponseBodyListInterviewers> getInterviewers() {
            return this.interviewers;
        }

    }

}
