// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateRemoteClassDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateRemoteClassDeviceResponseBody body;

    public static UpdateRemoteClassDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRemoteClassDeviceResponse self = new UpdateRemoteClassDeviceResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRemoteClassDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRemoteClassDeviceResponse setBody(UpdateRemoteClassDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRemoteClassDeviceResponseBody getBody() {
        return this.body;
    }

}