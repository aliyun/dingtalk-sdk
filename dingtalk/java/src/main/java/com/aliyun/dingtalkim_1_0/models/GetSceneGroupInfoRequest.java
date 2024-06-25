// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupInfoRequest extends TeaModel {
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidXXXXXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetSceneGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupInfoRequest self = new GetSceneGroupInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupInfoRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public GetSceneGroupInfoRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
