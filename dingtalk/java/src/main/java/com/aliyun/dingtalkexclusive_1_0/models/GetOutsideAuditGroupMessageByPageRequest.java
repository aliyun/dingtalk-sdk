// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOutsideAuditGroupMessageByPageRequest extends TeaModel {
    /**
     * <p>页大小，一次请求几条消息，合法区间[20,50]</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>毫秒时间戳，从该时间向过去拉消息</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>会话</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetOutsideAuditGroupMessageByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOutsideAuditGroupMessageByPageRequest self = new GetOutsideAuditGroupMessageByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetOutsideAuditGroupMessageByPageRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetOutsideAuditGroupMessageByPageRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetOutsideAuditGroupMessageByPageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
