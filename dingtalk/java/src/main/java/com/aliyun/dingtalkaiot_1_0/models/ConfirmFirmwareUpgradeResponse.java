// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class ConfirmFirmwareUpgradeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConfirmFirmwareUpgradeResponseBody body;

    public static ConfirmFirmwareUpgradeResponse build(java.util.Map<String, ?> map) throws Exception {
        ConfirmFirmwareUpgradeResponse self = new ConfirmFirmwareUpgradeResponse();
        return TeaModel.build(map, self);
    }

    public ConfirmFirmwareUpgradeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConfirmFirmwareUpgradeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConfirmFirmwareUpgradeResponse setBody(ConfirmFirmwareUpgradeResponseBody body) {
        this.body = body;
        return this;
    }
    public ConfirmFirmwareUpgradeResponseBody getBody() {
        return this.body;
    }

}
