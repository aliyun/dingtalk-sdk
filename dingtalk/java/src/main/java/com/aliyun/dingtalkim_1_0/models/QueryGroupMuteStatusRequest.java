// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMuteStatusRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

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
