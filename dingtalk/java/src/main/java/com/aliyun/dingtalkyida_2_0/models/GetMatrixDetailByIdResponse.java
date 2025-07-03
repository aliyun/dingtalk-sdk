// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetMatrixDetailByIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMatrixDetailByIdResponseBody body;

    public static GetMatrixDetailByIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMatrixDetailByIdResponse self = new GetMatrixDetailByIdResponse();
        return TeaModel.build(map, self);
    }

    public GetMatrixDetailByIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMatrixDetailByIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMatrixDetailByIdResponse setBody(GetMatrixDetailByIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMatrixDetailByIdResponseBody getBody() {
        return this.body;
    }

}
