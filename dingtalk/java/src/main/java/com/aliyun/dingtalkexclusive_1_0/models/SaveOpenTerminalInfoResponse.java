// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveOpenTerminalInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SaveOpenTerminalInfoResponseBody body;

    public static SaveOpenTerminalInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveOpenTerminalInfoResponse self = new SaveOpenTerminalInfoResponse();
        return TeaModel.build(map, self);
    }

    public SaveOpenTerminalInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveOpenTerminalInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveOpenTerminalInfoResponse setBody(SaveOpenTerminalInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveOpenTerminalInfoResponseBody getBody() {
        return this.body;
    }

}
