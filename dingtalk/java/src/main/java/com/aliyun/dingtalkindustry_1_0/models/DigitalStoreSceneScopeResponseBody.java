// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSceneScopeResponseBody extends TeaModel {
    @NameInMap("groupConversationType")
    public String groupConversationType;

    @NameInMap("scopeId")
    public Long scopeId;

    public static DigitalStoreSceneScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreSceneScopeResponseBody self = new DigitalStoreSceneScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreSceneScopeResponseBody setGroupConversationType(String groupConversationType) {
        this.groupConversationType = groupConversationType;
        return this;
    }
    public String getGroupConversationType() {
        return this.groupConversationType;
    }

    public DigitalStoreSceneScopeResponseBody setScopeId(Long scopeId) {
        this.scopeId = scopeId;
        return this;
    }
    public Long getScopeId() {
        return this.scopeId;
    }

}
