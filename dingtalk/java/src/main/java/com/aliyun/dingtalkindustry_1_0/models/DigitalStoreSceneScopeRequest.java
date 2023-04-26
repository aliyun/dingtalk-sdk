// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSceneScopeRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("sceneCode")
    public String sceneCode;

    public static DigitalStoreSceneScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreSceneScopeRequest self = new DigitalStoreSceneScopeRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreSceneScopeRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public DigitalStoreSceneScopeRequest setSceneCode(String sceneCode) {
        this.sceneCode = sceneCode;
        return this;
    }
    public String getSceneCode() {
        return this.sceneCode;
    }

}
