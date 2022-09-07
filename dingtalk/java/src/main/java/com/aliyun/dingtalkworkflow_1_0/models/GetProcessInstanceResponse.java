// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProcessInstanceResponseBody body;

    public static GetProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessInstanceResponse self = new GetProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessInstanceResponse setBody(GetProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
