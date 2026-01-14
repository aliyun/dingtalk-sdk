// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class AddRoleMemberResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddRoleMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRoleMemberResponseBody self = new AddRoleMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRoleMemberResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
