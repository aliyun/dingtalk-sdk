// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetTaskPackageResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTaskPackageResultResponseBody body;

    public static GetTaskPackageResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTaskPackageResultResponse self = new GetTaskPackageResultResponse();
        return TeaModel.build(map, self);
    }

    public GetTaskPackageResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTaskPackageResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTaskPackageResultResponse setBody(GetTaskPackageResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTaskPackageResultResponseBody getBody() {
        return this.body;
    }

}
