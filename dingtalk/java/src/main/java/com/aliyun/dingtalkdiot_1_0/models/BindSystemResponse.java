// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BindSystemResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BindSystemResponseBody body;

    public static BindSystemResponse build(java.util.Map<String, ?> map) throws Exception {
        BindSystemResponse self = new BindSystemResponse();
        return TeaModel.build(map, self);
    }

    public BindSystemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BindSystemResponse setBody(BindSystemResponseBody body) {
        this.body = body;
        return this;
    }
    public BindSystemResponseBody getBody() {
        return this.body;
    }

}
