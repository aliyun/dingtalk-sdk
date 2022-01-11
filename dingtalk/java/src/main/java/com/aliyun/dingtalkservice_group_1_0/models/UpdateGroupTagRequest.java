// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupTagRequest extends TeaModel {
    // 群会话ID集合
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    @NameInMap("tagNames")
    public java.util.List<String> tagNames;

    // 更新类型，APPEND、NOTAPPEND、DELETE三种类型
    @NameInMap("updateType")
    public String updateType;

    public static UpdateGroupTagRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupTagRequest self = new UpdateGroupTagRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupTagRequest setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

    public UpdateGroupTagRequest setTagNames(java.util.List<String> tagNames) {
        this.tagNames = tagNames;
        return this;
    }
    public java.util.List<String> getTagNames() {
        return this.tagNames;
    }

    public UpdateGroupTagRequest setUpdateType(String updateType) {
        this.updateType = updateType;
        return this;
    }
    public String getUpdateType() {
        return this.updateType;
    }

}
