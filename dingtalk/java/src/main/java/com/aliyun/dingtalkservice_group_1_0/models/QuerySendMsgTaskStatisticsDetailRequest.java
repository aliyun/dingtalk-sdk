// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QuerySendMsgTaskStatisticsDetailRequest extends TeaModel {
    // 每页条数
    @NameInMap("maxResults")
    public Long maxResults;

    // 游标，首页传递空
    @NameInMap("nextToken")
    public String nextToken;

    // 开放群发任务ID
    @NameInMap("openBatchTaskId")
    public String openBatchTaskId;

    // 开放会话ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static QuerySendMsgTaskStatisticsDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySendMsgTaskStatisticsDetailRequest self = new QuerySendMsgTaskStatisticsDetailRequest();
        return TeaModel.build(map, self);
    }

    public QuerySendMsgTaskStatisticsDetailRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QuerySendMsgTaskStatisticsDetailRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QuerySendMsgTaskStatisticsDetailRequest setOpenBatchTaskId(String openBatchTaskId) {
        this.openBatchTaskId = openBatchTaskId;
        return this;
    }
    public String getOpenBatchTaskId() {
        return this.openBatchTaskId;
    }

    public QuerySendMsgTaskStatisticsDetailRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QuerySendMsgTaskStatisticsDetailRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
