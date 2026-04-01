// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DsbandOpenSceneGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static DsbandOpenSceneGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        DsbandOpenSceneGroupRequest self = new DsbandOpenSceneGroupRequest();
        return TeaModel.build(map, self);
    }

    public DsbandOpenSceneGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
