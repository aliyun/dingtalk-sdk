// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeviceMarketOrderManagerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeviceMarketOrderManagerResponseBody body;

    public static DeviceMarketOrderManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        DeviceMarketOrderManagerResponse self = new DeviceMarketOrderManagerResponse();
        return TeaModel.build(map, self);
    }

    public DeviceMarketOrderManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeviceMarketOrderManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeviceMarketOrderManagerResponse setBody(DeviceMarketOrderManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public DeviceMarketOrderManagerResponseBody getBody() {
        return this.body;
    }

}
