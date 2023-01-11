// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusRequest extends TeaModel {
    /**
     * <p>本次读取的最大数据记录数量，此参数为可选参数，用户传入为空时，应该有默认值。应设置最大值限制，最大不超过100</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>用来标记当前开始读取的位置，置空表示从头开始。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开放群ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>开放消息ID</p>
     */
    @NameInMap("openMsgTaskId")
    public String openMsgTaskId;

    /**
     * <p>开放团队ID</p>
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
