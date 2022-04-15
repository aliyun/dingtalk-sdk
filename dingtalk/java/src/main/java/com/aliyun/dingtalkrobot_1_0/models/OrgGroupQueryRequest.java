// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupQueryRequest extends TeaModel {
    // 分页查询每页的数量
    @NameInMap("maxResults")
    public Long maxResults;

    // 一次查询后返回的加密的分页凭证，首次查询不填
    @NameInMap("nextToken")
    public String nextToken;

    // 开放的群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 发送消息返回的加密消息id
    @NameInMap("processQueryKey")
    public String processQueryKey;

    // 企业机器人的robotcode
    @NameInMap("robotCode")
    public String robotCode;

    // 群内机器人的webhook中的Token
    @NameInMap("token")
    public String token;

    public static OrgGroupQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupQueryRequest self = new OrgGroupQueryRequest();
        return TeaModel.build(map, self);
    }

    public OrgGroupQueryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public OrgGroupQueryRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public OrgGroupQueryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public OrgGroupQueryRequest setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

    public OrgGroupQueryRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public OrgGroupQueryRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
