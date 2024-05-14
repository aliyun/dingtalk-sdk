// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupAvatarResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("newGroupAvatar")
    public String newGroupAvatar;

    public static UpdateGroupAvatarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupAvatarResponseBody self = new UpdateGroupAvatarResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateGroupAvatarResponseBody setNewGroupAvatar(String newGroupAvatar) {
        this.newGroupAvatar = newGroupAvatar;
        return this;
    }
    public String getNewGroupAvatar() {
        return this.newGroupAvatar;
    }

}
