// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDoubleRandomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDoubleRandomResponseBody body;

    public static GetDoubleRandomResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDoubleRandomResponse self = new GetDoubleRandomResponse();
        return TeaModel.build(map, self);
    }

    public GetDoubleRandomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDoubleRandomResponse setBody(GetDoubleRandomResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDoubleRandomResponseBody getBody() {
        return this.body;
    }

}
