// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeviceMarketManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeviceMarketManagerResponseBody body;

    public static DeviceMarketManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        DeviceMarketManagerResponse self = new DeviceMarketManagerResponse();
        return TeaModel.build(map, self);
    }

    public DeviceMarketManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeviceMarketManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeviceMarketManagerResponse setBody(DeviceMarketManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public DeviceMarketManagerResponseBody getBody() {
        return this.body;
    }

}
