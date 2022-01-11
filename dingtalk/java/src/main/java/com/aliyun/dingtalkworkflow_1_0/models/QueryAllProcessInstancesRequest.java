// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllProcessInstancesRequest extends TeaModel {
    // 应用编码
    @NameInMap("appUuid")
    public String appUuid;

    // 结束时间
    @NameInMap("endTimeInMills")
    public Long endTimeInMills;

    // 分页大小
    @NameInMap("maxResults")
    public Long maxResults;

    // 分页起始值
    @NameInMap("nextToken")
    public String nextToken;

    // 模板编码
    @NameInMap("processCode")
    public String processCode;

    // 开始时间
    @NameInMap("startTimeInMills")
    public Long startTimeInMills;

    public static QueryAllProcessInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllProcessInstancesRequest self = new QueryAllProcessInstancesRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllProcessInstancesRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QueryAllProcessInstancesRequest setEndTimeInMills(Long endTimeInMills) {
        this.endTimeInMills = endTimeInMills;
        return this;
    }
    public Long getEndTimeInMills() {
        return this.endTimeInMills;
    }

    public QueryAllProcessInstancesRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryAllProcessInstancesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAllProcessInstancesRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public QueryAllProcessInstancesRequest setStartTimeInMills(Long startTimeInMills) {
        this.startTimeInMills = startTimeInMills;
        return this;
    }
    public Long getStartTimeInMills() {
        return this.startTimeInMills;
    }

}
