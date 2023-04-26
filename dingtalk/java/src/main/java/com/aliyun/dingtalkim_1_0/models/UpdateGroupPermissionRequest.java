// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupPermissionRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("permissionGroup")
    public String permissionGroup;

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
