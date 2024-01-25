// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetInAppSkuUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetInAppSkuUrlResponseBody body;

    public static GetInAppSkuUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInAppSkuUrlResponse self = new GetInAppSkuUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetInAppSkuUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInAppSkuUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInAppSkuUrlResponse setBody(GetInAppSkuUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInAppSkuUrlResponseBody getBody() {
        return this.body;
    }

}
