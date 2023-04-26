// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class KickMembersResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static KickMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        KickMembersResponseBody self = new KickMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public KickMembersResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
