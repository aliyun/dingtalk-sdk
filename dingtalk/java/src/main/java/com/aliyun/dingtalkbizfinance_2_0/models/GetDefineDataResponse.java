// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetDefineDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDefineDataResponseBody body;

    public static GetDefineDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDefineDataResponse self = new GetDefineDataResponse();
        return TeaModel.build(map, self);
    }

    public GetDefineDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDefineDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDefineDataResponse setBody(GetDefineDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDefineDataResponseBody getBody() {
        return this.body;
    }

}
