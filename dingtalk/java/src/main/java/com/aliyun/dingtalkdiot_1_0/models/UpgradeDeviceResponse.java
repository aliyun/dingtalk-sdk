// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class UpgradeDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpgradeDeviceResponseBody body;

    public static UpgradeDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpgradeDeviceResponse self = new UpgradeDeviceResponse();
        return TeaModel.build(map, self);
    }

    public UpgradeDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpgradeDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpgradeDeviceResponse setBody(UpgradeDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpgradeDeviceResponseBody getBody() {
        return this.body;
    }

}
