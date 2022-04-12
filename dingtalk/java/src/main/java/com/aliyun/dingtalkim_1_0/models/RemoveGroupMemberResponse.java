// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static RemoveGroupMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveGroupMemberResponse self = new RemoveGroupMemberResponse();
        return TeaModel.build(map, self);
    }

    public RemoveGroupMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
