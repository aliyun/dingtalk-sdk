// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupPermissionRequest extends TeaModel {
    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 群权限项
    @NameInMap("permissionGroup")
    public String permissionGroup;

    // 状态,0-关闭，1-开启
    @NameInMap("status")
    public String status;

    public static UpdateGroupPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupPermissionRequest self = new UpdateGroupPermissionRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupPermissionRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateGroupPermissionRequest setPermissionGroup(String permissionGroup) {
        this.permissionGroup = permissionGroup;
        return this;
    }
    public String getPermissionGroup() {
        return this.permissionGroup;
    }

    public UpdateGroupPermissionRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
