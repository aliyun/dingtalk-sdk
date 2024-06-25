// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryOpenConversationReceiveUserRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("sendUserId")
    public String sendUserId;

    public static QueryOpenConversationReceiveUserRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOpenConversationReceiveUserRequest self = new QueryOpenConversationReceiveUserRequest();
        return TeaModel.build(map, self);
    }

    public QueryOpenConversationReceiveUserRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryOpenConversationReceiveUserRequest setSendUserId(String sendUserId) {
        this.sendUserId = sendUserId;
        return this;
    }
    public String getSendUserId() {
        return this.sendUserId;
    }

}
