// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListSceneGroupsByTemplateIdResponseBody extends TeaModel {
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    @NameInMap("success")
    public Boolean success;

    public static ListSceneGroupsByTemplateIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSceneGroupsByTemplateIdResponseBody self = new ListSceneGroupsByTemplateIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSceneGroupsByTemplateIdResponseBody setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

    public ListSceneGroupsByTemplateIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
