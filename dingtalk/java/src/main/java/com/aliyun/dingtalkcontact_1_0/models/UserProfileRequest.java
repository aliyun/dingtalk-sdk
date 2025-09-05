// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserProfileRequest extends TeaModel {
    @NameInMap("uids")
    public java.util.List<Long> uids;

    public static UserProfileRequest build(java.util.Map<String, ?> map) throws Exception {
        UserProfileRequest self = new UserProfileRequest();
        return TeaModel.build(map, self);
    }

    public UserProfileRequest setUids(java.util.List<Long> uids) {
        this.uids = uids;
        return this;
    }
    public java.util.List<Long> getUids() {
        return this.uids;
    }

}
