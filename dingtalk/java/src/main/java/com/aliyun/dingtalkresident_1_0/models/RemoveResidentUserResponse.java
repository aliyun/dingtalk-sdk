// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveResidentUserResponseBody body;

    public static RemoveResidentUserResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentUserResponse self = new RemoveResidentUserResponse();
        return TeaModel.build(map, self);
    }

    public RemoveResidentUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveResidentUserResponse setBody(RemoveResidentUserResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveResidentUserResponseBody getBody() {
        return this.body;
    }

}
