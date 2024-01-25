// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMediaCerficateResponseBody body;

    public static GetMediaCerficateResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMediaCerficateResponse self = new GetMediaCerficateResponse();
        return TeaModel.build(map, self);
    }

    public GetMediaCerficateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMediaCerficateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMediaCerficateResponse setBody(GetMediaCerficateResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMediaCerficateResponseBody getBody() {
        return this.body;
    }

}
