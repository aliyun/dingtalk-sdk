// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupMembersRequest extends TeaModel {
    // 酷应用编码
    @NameInMap("coolAppCode")
    public String coolAppCode;

    // 分页游标，首页传0
    @NameInMap("cursor")
    public String cursor;

    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 本次查询返回数量上限（该入参传入值小于钉钉阈值时不启用）
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
