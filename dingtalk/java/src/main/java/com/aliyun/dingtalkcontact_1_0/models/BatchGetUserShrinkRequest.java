// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchGetUserShrinkRequest extends TeaModel {
    @NameInMap("permissionCode")
    public String permissionCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIdList")
    public String userIdListShrink;

    public static BatchGetUserShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetUserShrinkRequest self = new BatchGetUserShrinkRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetUserShrinkRequest setPermissionCode(String permissionCode) {
        this.permissionCode = permissionCode;
        return this;
    }
    public String getPermissionCode() {
        return this.permissionCode;
    }

    public BatchGetUserShrinkRequest setUserIdListShrink(String userIdListShrink) {
        this.userIdListShrink = userIdListShrink;
        return this;
    }
    public String getUserIdListShrink() {
        return this.userIdListShrink;
    }

}
