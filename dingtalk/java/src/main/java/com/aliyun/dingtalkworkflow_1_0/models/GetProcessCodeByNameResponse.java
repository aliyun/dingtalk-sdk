// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessCodeByNameResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProcessCodeByNameResponseBody body;

    public static GetProcessCodeByNameResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessCodeByNameResponse self = new GetProcessCodeByNameResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessCodeByNameResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessCodeByNameResponse setBody(GetProcessCodeByNameResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessCodeByNameResponseBody getBody() {
        return this.body;
    }

}
