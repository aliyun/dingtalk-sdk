// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatQueryRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>cid6KeBBLoveMJOGXoYKF5x7EeiodoA==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=</p>
     */
    @NameInMap("processQueryKey")
    public String processQueryKey;

    /**
     * <strong>example:</strong>
     * <p>dingue4kfzdxbyn0pjqd</p>
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
