// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QuerySendMsgTaskStatisticsRequest extends TeaModel {
    /**
     * <p>每页条数</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>游标，首页为空</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开放群发任务ID</p>
     */
    @NameInMap("openBatchTaskId")
    public String openBatchTaskId;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static QuerySendMsgTaskStatisticsRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySendMsgTaskStatisticsRequest self = new QuerySendMsgTaskStatisticsRequest();
        return TeaModel.build(map, self);
    }

    public QuerySendMsgTaskStatisticsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QuerySendMsgTaskStatisticsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QuerySendMsgTaskStatisticsRequest setOpenBatchTaskId(String openBatchTaskId) {
        this.openBatchTaskId = openBatchTaskId;
        return this;
    }
    public String getOpenBatchTaskId() {
        return this.openBatchTaskId;
    }

    public QuerySendMsgTaskStatisticsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
