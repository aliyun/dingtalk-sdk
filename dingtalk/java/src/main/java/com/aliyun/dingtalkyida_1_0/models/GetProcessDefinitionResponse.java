// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDefinitionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProcessDefinitionResponseBody body;

    public static GetProcessDefinitionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDefinitionResponse self = new GetProcessDefinitionResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessDefinitionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessDefinitionResponse setBody(GetProcessDefinitionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessDefinitionResponseBody getBody() {
        return this.body;
    }

}
