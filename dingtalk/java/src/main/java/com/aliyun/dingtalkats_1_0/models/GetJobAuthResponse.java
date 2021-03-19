// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetJobAuthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetJobAuthResponseBody body;

    public static GetJobAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        GetJobAuthResponse self = new GetJobAuthResponse();
        return TeaModel.build(map, self);
    }

    public GetJobAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetJobAuthResponse setBody(GetJobAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public GetJobAuthResponseBody getBody() {
        return this.body;
    }

}
