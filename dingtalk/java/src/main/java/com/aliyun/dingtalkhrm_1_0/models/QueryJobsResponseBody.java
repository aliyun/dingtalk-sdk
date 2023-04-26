// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobsResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryJobsResponseBodyList> list;

    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryJobsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryJobsResponseBody self = new QueryJobsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryJobsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryJobsResponseBody setList(java.util.List<QueryJobsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryJobsResponseBodyList> getList() {
        return this.list;
    }

    public QueryJobsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryJobsResponseBodyList extends TeaModel {
        @NameInMap("jobDescription")
        public String jobDescription;

        @NameInMap("jobId")
        public String jobId;

        @NameInMap("jobName")
        public String jobName;

        public static QueryJobsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryJobsResponseBodyList self = new QueryJobsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryJobsResponseBodyList setJobDescription(String jobDescription) {
            this.jobDescription = jobDescription;
            return this;
        }
        public String getJobDescription() {
            return this.jobDescription;
        }

        public QueryJobsResponseBodyList setJobId(String jobId) {
            this.jobId = jobId;
            return this;
        }
        public String getJobId() {
            return this.jobId;
        }

        public QueryJobsResponseBodyList setJobName(String jobName) {
            this.jobName = jobName;
            return this;
        }
        public String getJobName() {
            return this.jobName;
        }

    }

}
