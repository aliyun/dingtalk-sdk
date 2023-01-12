// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublicDevicesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetPublicDevicesResponseBody body;

    public static GetPublicDevicesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPublicDevicesResponse self = new GetPublicDevicesResponse();
        return TeaModel.build(map, self);
    }

    public GetPublicDevicesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPublicDevicesResponse setBody(GetPublicDevicesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPublicDevicesResponseBody getBody() {
        return this.body;
    }

}
