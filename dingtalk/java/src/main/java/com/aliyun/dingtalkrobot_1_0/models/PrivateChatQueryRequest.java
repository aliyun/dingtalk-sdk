// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatQueryRequest extends TeaModel {
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

    public static PrivateChatQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        PrivateChatQueryRequest self = new PrivateChatQueryRequest();
        return TeaModel.build(map, self);
    }

    public PrivateChatQueryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public PrivateChatQueryRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PrivateChatQueryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public PrivateChatQueryRequest setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

    public PrivateChatQueryRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
