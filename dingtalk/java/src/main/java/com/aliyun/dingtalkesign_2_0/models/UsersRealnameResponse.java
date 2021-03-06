// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class UsersRealnameResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UsersRealnameResponseBody body;

    public static UsersRealnameResponse build(java.util.Map<String, ?> map) throws Exception {
        UsersRealnameResponse self = new UsersRealnameResponse();
        return TeaModel.build(map, self);
    }

    public UsersRealnameResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UsersRealnameResponse setBody(UsersRealnameResponseBody body) {
        this.body = body;
        return this;
    }
    public UsersRealnameResponseBody getBody() {
        return this.body;
    }

}
