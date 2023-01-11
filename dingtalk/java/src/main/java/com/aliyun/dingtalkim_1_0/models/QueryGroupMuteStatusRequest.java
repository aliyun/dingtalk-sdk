// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMuteStatusRequest extends TeaModel {
    /**
     * <p>开放的会话ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>群成员的员工工号</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryGroupMuteStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMuteStatusRequest self = new QueryGroupMuteStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupMuteStatusRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryGroupMuteStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
