// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class InviteUsersResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static InviteUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InviteUsersResponseBody self = new InviteUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public InviteUsersResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
