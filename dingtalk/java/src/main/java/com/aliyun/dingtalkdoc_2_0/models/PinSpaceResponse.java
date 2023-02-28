// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class PinSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PinSpaceResponseBody body;

    public static PinSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        PinSpaceResponse self = new PinSpaceResponse();
        return TeaModel.build(map, self);
    }

    public PinSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PinSpaceResponse setBody(PinSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public PinSpaceResponseBody getBody() {
        return this.body;
    }

}
