// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalCarbonInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPersonalCarbonInfoResponseBody body;

    public static GetPersonalCarbonInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalCarbonInfoResponse self = new GetPersonalCarbonInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPersonalCarbonInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPersonalCarbonInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPersonalCarbonInfoResponse setBody(GetPersonalCarbonInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPersonalCarbonInfoResponseBody getBody() {
        return this.body;
    }

}
