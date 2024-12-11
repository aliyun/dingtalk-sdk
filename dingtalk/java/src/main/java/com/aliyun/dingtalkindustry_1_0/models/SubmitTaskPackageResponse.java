// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SubmitTaskPackageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitTaskPackageResponseBody body;

    public static SubmitTaskPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitTaskPackageResponse self = new SubmitTaskPackageResponse();
        return TeaModel.build(map, self);
    }

    public SubmitTaskPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitTaskPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitTaskPackageResponse setBody(SubmitTaskPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitTaskPackageResponseBody getBody() {
        return this.body;
    }

}
