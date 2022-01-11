// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupInfoResponseBody extends TeaModel {
    // 群url
    @NameInMap("groupUrl")
    public String groupUrl;

    // 群头像mediaId
    @NameInMap("icon")
    public String icon;

    // 开放群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 群主员工id
    @NameInMap("ownerUserId")
    public String ownerUserId;

    // result
    @NameInMap("success")
    public Boolean success;

    // 场景群模板ID
    @NameInMap("templateId")
    public String templateId;

    // 群名称
    @NameInMap("title")
    public String title;

    public static GetSceneGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupInfoResponseBody self = new GetSceneGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupInfoResponseBody setGroupUrl(String groupUrl) {
        this.groupUrl = groupUrl;
        return this;
    }
    public String getGroupUrl() {
        return this.groupUrl;
    }

    public GetSceneGroupInfoResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetSceneGroupInfoResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetSceneGroupInfoResponseBody setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public GetSceneGroupInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public GetSceneGroupInfoResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public GetSceneGroupInfoResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
