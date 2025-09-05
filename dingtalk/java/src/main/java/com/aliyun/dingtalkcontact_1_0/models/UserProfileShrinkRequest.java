// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserProfileShrinkRequest extends TeaModel {
    @NameInMap("uids")
    public String uidsShrink;

    public static UserProfileShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        UserProfileShrinkRequest self = new UserProfileShrinkRequest();
        return TeaModel.build(map, self);
    }

    public UserProfileShrinkRequest setUidsShrink(String uidsShrink) {
        this.uidsShrink = uidsShrink;
        return this;
    }
    public String getUidsShrink() {
        return this.uidsShrink;
    }

}
