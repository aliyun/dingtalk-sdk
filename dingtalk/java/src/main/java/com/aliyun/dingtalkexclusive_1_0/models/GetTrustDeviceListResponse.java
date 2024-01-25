// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetTrustDeviceListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTrustDeviceListResponseBody body;

    public static GetTrustDeviceListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTrustDeviceListResponse self = new GetTrustDeviceListResponse();
        return TeaModel.build(map, self);
    }

    public GetTrustDeviceListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTrustDeviceListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTrustDeviceListResponse setBody(GetTrustDeviceListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTrustDeviceListResponseBody getBody() {
        return this.body;
    }

}
