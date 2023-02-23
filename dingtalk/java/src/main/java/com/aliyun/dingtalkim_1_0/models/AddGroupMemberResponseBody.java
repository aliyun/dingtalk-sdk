// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddGroupMemberResponseBody extends TeaModel {
    /**
     * <p>添加成功的钉外账号列表。</p>
     */
    @NameInMap("appUserIds")
    public java.util.List<String> appUserIds;

    /**
     * <p>添加成功的钉内账号列表。</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static AddGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddGroupMemberResponseBody self = new AddGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public AddGroupMemberResponseBody setAppUserIds(java.util.List<String> appUserIds) {
        this.appUserIds = appUserIds;
        return this;
    }
    public java.util.List<String> getAppUserIds() {
        return this.appUserIds;
    }

    public AddGroupMemberResponseBody setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
