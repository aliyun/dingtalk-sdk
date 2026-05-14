// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddSceneGroupMemberResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddSceneGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddSceneGroupMemberResponseBody self = new AddSceneGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public AddSceneGroupMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
