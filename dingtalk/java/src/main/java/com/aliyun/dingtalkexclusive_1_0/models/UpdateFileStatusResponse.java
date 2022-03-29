// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateFileStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateFileStatusResponseBody body;

    public static UpdateFileStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFileStatusResponse self = new UpdateFileStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFileStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFileStatusResponse setBody(UpdateFileStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFileStatusResponseBody getBody() {
        return this.body;
    }

}
