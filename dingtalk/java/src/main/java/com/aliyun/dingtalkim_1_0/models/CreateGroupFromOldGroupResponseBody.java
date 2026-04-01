// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupFromOldGroupResponseBody extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("success")
    public Boolean success;

    public static CreateGroupFromOldGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupFromOldGroupResponseBody self = new CreateGroupFromOldGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateGroupFromOldGroupResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CreateGroupFromOldGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
