// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetTrustDeviceListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetTrustDeviceListResponse setBody(GetTrustDeviceListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTrustDeviceListResponseBody getBody() {
        return this.body;
    }

}
