// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MuteMembersResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static MuteMembersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MuteMembersResponseBody self = new MuteMembersResponseBody();
        return TeaModel.build(map, self);
    }

    public MuteMembersResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
