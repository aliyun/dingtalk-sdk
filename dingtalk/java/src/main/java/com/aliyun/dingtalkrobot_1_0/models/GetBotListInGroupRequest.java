// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class GetBotListInGroupRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetBotListInGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBotListInGroupRequest self = new GetBotListInGroupRequest();
        return TeaModel.build(map, self);
    }

    public GetBotListInGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
