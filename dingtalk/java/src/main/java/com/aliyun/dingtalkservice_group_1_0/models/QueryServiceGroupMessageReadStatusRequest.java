// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openMsgTaskId")
    public String openMsgTaskId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static QueryServiceGroupMessageReadStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceGroupMessageReadStatusRequest self = new QueryServiceGroupMessageReadStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryServiceGroupMessageReadStatusRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryServiceGroupMessageReadStatusRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryServiceGroupMessageReadStatusRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryServiceGroupMessageReadStatusRequest setOpenMsgTaskId(String openMsgTaskId) {
        this.openMsgTaskId = openMsgTaskId;
        return this;
    }
    public String getOpenMsgTaskId() {
        return this.openMsgTaskId;
    }

    public QueryServiceGroupMessageReadStatusRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
