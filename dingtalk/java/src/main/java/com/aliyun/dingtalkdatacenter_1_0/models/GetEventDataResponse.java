// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEventDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetEventDataResponseBody body;

    public static GetEventDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEventDataResponse self = new GetEventDataResponse();
        return TeaModel.build(map, self);
    }

    public GetEventDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEventDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetEventDataResponse setBody(GetEventDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEventDataResponseBody getBody() {
        return this.body;
    }

}
