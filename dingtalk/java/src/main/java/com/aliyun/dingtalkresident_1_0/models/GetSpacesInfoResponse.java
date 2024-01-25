// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetSpacesInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSpacesInfoResponseBody body;

    public static GetSpacesInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSpacesInfoResponse self = new GetSpacesInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetSpacesInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSpacesInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSpacesInfoResponse setBody(GetSpacesInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSpacesInfoResponseBody getBody() {
        return this.body;
    }

}
