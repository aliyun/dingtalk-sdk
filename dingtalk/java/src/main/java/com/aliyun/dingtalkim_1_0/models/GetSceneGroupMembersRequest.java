// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupMembersRequest extends TeaModel {
    @NameInMap("coolAppCode")
    public String coolAppCode;

    @NameInMap("cursor")
    public String cursor;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("size")
    public Long size;

    public static GetSceneGroupMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupMembersRequest self = new GetSceneGroupMembersRequest();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupMembersRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public GetSceneGroupMembersRequest setCursor(String cursor) {
        this.cursor = cursor;
        return this;
    }
    public String getCursor() {
        return this.cursor;
    }

    public GetSceneGroupMembersRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetSceneGroupMembersRequest setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

}
