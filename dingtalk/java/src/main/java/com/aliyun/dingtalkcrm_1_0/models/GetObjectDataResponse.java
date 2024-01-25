// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetObjectDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetObjectDataResponseBody body;

    public static GetObjectDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetObjectDataResponse self = new GetObjectDataResponse();
        return TeaModel.build(map, self);
    }

    public GetObjectDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetObjectDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetObjectDataResponse setBody(GetObjectDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetObjectDataResponseBody getBody() {
        return this.body;
    }

}
