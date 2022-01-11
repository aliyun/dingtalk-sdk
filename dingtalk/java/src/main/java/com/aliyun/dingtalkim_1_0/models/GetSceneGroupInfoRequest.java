// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupInfoRequest extends TeaModel {
    // 酷应用编码
    @NameInMap("coolAppCode")
    public String coolAppCode;

    // 开放群ID
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
