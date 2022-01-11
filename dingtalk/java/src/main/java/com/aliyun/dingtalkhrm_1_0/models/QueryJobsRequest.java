// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobsRequest extends TeaModel {
    // 职务名称
    @NameInMap("jobName")
    public String jobName;

    // 最大值
    @NameInMap("maxResults")
    public Integer maxResults;

    // 偏移量
    @NameInMap("nextToken")
    public Integer nextToken;

    public static QueryJobsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryJobsRequest self = new QueryJobsRequest();
        return TeaModel.build(map, self);
    }

    public QueryJobsRequest setJobName(String jobName) {
        this.jobName = jobName;
        return this;
    }
    public String getJobName() {
        return this.jobName;
    }

    public QueryJobsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryJobsRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

}
