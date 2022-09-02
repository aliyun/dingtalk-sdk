// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class IsFriendResponseBody extends TeaModel {
    // 是否有好友关系
    @NameInMap("isFriend")
    public Boolean isFriend;

    public static IsFriendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IsFriendResponseBody self = new IsFriendResponseBody();
        return TeaModel.build(map, self);
    }

    public IsFriendResponseBody setIsFriend(Boolean isFriend) {
        this.isFriend = isFriend;
        return this;
    }
    public Boolean getIsFriend() {
        return this.isFriend;
    }

}
