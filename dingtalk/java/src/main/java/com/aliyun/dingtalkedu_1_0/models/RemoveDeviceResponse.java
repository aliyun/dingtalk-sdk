// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class RemoveDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveDeviceResponseBody body;

    public static RemoveDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveDeviceResponse self = new RemoveDeviceResponse();
        return TeaModel.build(map, self);
    }

    public RemoveDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveDeviceResponse setBody(RemoveDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveDeviceResponseBody getBody() {
        return this.body;
    }

}