// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveStorageFunctionSwitchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveStorageFunctionSwitchResponseBody body;

    public static SaveStorageFunctionSwitchResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveStorageFunctionSwitchResponse self = new SaveStorageFunctionSwitchResponse();
        return TeaModel.build(map, self);
    }

    public SaveStorageFunctionSwitchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveStorageFunctionSwitchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveStorageFunctionSwitchResponse setBody(SaveStorageFunctionSwitchResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveStorageFunctionSwitchResponseBody getBody() {
        return this.body;
    }

}
