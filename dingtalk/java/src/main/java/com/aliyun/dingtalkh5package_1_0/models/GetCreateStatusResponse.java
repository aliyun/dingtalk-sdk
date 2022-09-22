// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class GetCreateStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCreateStatusResponseBody body;

    public static GetCreateStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCreateStatusResponse self = new GetCreateStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetCreateStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCreateStatusResponse setBody(GetCreateStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCreateStatusResponseBody getBody() {
        return this.body;
    }

}
