// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateSceneGroupConversationResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxxxx==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static CreateSceneGroupConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSceneGroupConversationResponseBody self = new CreateSceneGroupConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSceneGroupConversationResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
