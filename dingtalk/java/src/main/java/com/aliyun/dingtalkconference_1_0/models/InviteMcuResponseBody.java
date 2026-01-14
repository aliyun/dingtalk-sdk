// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class InviteMcuResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static InviteMcuResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InviteMcuResponseBody self = new InviteMcuResponseBody();
        return TeaModel.build(map, self);
    }

    public InviteMcuResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
