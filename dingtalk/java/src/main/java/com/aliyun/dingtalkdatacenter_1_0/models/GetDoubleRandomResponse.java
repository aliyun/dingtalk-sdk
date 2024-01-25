// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDoubleRandomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetDoubleRandomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDoubleRandomResponse setBody(GetDoubleRandomResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDoubleRandomResponseBody getBody() {
        return this.body;
    }

}
