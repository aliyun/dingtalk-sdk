// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSceneScopeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidxxa9122s733s1==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>achieveAllocate</p>
     */
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
