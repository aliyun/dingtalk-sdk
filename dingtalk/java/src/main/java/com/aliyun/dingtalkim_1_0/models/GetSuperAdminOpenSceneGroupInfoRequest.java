// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSuperAdminOpenSceneGroupInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetSuperAdminOpenSceneGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSuperAdminOpenSceneGroupInfoRequest self = new GetSuperAdminOpenSceneGroupInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetSuperAdminOpenSceneGroupInfoRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
