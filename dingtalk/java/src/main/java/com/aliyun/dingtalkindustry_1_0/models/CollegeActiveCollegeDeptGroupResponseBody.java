// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeActiveCollegeDeptGroupResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0134124</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static CollegeActiveCollegeDeptGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeActiveCollegeDeptGroupResponseBody self = new CollegeActiveCollegeDeptGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeActiveCollegeDeptGroupResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
