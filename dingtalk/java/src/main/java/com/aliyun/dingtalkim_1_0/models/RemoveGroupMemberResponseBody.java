// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveGroupMemberResponseBody extends TeaModel {
    @NameInMap("message")
    public String message;

    public static RemoveGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveGroupMemberResponseBody self = new RemoveGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveGroupMemberResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
