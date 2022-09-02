// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class IsFriendResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public IsFriendResponseBody body;

    public static IsFriendResponse build(java.util.Map<String, ?> map) throws Exception {
        IsFriendResponse self = new IsFriendResponse();
        return TeaModel.build(map, self);
    }

    public IsFriendResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IsFriendResponse setBody(IsFriendResponseBody body) {
        this.body = body;
        return this;
    }
    public IsFriendResponseBody getBody() {
        return this.body;
    }

}
