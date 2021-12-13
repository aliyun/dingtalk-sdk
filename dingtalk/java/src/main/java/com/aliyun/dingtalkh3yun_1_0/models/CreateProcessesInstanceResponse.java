// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateProcessesInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateProcessesInstanceResponseBody body;

    public static CreateProcessesInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateProcessesInstanceResponse self = new CreateProcessesInstanceResponse();
        return TeaModel.build(map, self);
    }

    public CreateProcessesInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateProcessesInstanceResponse setBody(CreateProcessesInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateProcessesInstanceResponseBody getBody() {
        return this.body;
    }

}
