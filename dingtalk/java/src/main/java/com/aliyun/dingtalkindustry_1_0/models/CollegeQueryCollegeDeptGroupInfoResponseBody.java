// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryCollegeDeptGroupInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxx全员群</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <strong>example:</strong>
     * <p>0124215</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static CollegeQueryCollegeDeptGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryCollegeDeptGroupInfoResponseBody self = new CollegeQueryCollegeDeptGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeQueryCollegeDeptGroupInfoResponseBody setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CollegeQueryCollegeDeptGroupInfoResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
