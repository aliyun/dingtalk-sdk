// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetGroupMembersByUserTokenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>200</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidXXXXXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetGroupMembersByUserTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupMembersByUserTokenRequest self = new GetGroupMembersByUserTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupMembersByUserTokenRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetGroupMembersByUserTokenRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetGroupMembersByUserTokenRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
