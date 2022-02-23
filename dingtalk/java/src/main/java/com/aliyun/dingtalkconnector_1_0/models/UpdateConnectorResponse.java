// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class UpdateConnectorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateConnectorResponseBody body;

    public static UpdateConnectorResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateConnectorResponse self = new UpdateConnectorResponse();
        return TeaModel.build(map, self);
    }

    public UpdateConnectorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateConnectorResponse setBody(UpdateConnectorResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateConnectorResponseBody getBody() {
        return this.body;
    }

}
