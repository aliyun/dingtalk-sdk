// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateConnectorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateConnectorResponseBody body;

    public static CreateConnectorResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateConnectorResponse self = new CreateConnectorResponse();
        return TeaModel.build(map, self);
    }

    public CreateConnectorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateConnectorResponse setBody(CreateConnectorResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateConnectorResponseBody getBody() {
        return this.body;
    }

}