// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class UpdateVersionStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateVersionStatusResponseBody body;

    public static UpdateVersionStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateVersionStatusResponse self = new UpdateVersionStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateVersionStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateVersionStatusResponse setBody(UpdateVersionStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateVersionStatusResponseBody getBody() {
        return this.body;
    }

}
