// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryServiceGroupMessageReadStatusRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 开放消息ID
    @NameInMap("openMsgTaskId")
    public String openMsgTaskId;

    // 用来标记当前开始读取的位置，置空表示从头开始。
    @NameInMap("nextToken")
    public String nextToken;

    // 本次读取的最大数据记录数量，此参数为可选参数，用户传入为空时，应该有默认值。应设置最大值限制，最大不超过100
    @NameInMap("maxResults")
    public Integer maxResults;

    public static QueryServiceGroupMessageReadStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryServiceGroupMessageReadStatusRequest self = new QueryServiceGroupMessageReadStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryServiceGroupMessageReadStatusRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public QueryServiceGroupMessageReadStatusRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public QueryServiceGroupMessageReadStatusRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public QueryServiceGroupMessageReadStatusRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public QueryServiceGroupMessageReadStatusRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
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

    public QueryServiceGroupMessageReadStatusRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryServiceGroupMessageReadStatusRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
