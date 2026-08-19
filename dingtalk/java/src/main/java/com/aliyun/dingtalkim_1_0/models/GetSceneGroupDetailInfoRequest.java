// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupDetailInfoRequest extends TeaModel {
    @NameInMap("cool_app_code")
    public String coolAppCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidXXXXXXX</p>
     */
    @NameInMap("open_conversation_id")
    public String openConversationId;

    public static GetSceneGroupDetailInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupDetailInfoRequest self = new GetSceneGroupDetailInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupDetailInfoRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public GetSceneGroupDetailInfoRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
