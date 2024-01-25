// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveGroupMemberResponseBody body;

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

    public RemoveGroupMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveGroupMemberResponse setBody(RemoveGroupMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveGroupMemberResponseBody getBody() {
        return this.body;
    }

}
