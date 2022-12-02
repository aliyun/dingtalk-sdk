// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class SubscribeEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SubscribeEventResponseBody body;

    public static SubscribeEventResponse build(java.util.Map<String, ?> map) throws Exception {
        SubscribeEventResponse self = new SubscribeEventResponse();
        return TeaModel.build(map, self);
    }

    public SubscribeEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubscribeEventResponse setBody(SubscribeEventResponseBody body) {
        this.body = body;
        return this;
    }
    public SubscribeEventResponseBody getBody() {
        return this.body;
    }

}
