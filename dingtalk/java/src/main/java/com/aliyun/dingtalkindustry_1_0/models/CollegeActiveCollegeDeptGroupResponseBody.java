// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeActiveCollegeDeptGroupResponseBody extends TeaModel {
    /**
     * <p>调用时如果满足创建群条件，直接返回 openConversationId</p>
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
