// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetConversationRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConversationRequest self = new GetConversationRequest();
        return TeaModel.build(map, self);
    }

    public GetConversationRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
