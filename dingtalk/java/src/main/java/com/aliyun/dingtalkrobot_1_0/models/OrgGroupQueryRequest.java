// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupQueryRequest extends TeaModel {
    /**
     * <p>分页查询每页的数量</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>一次查询后返回的加密的分页凭证，首次查询不填</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>开放的群id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>发送消息返回的加密消息id</p>
     */
    @NameInMap("processQueryKey")
    public String processQueryKey;

    /**
     * <p>企业机器人的robotcode</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>群内机器人的webhook中的Token</p>
     */
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
