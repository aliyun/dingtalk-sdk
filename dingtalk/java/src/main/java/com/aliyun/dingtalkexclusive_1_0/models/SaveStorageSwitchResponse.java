// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveStorageSwitchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveStorageSwitchResponseBody body;

    public static SaveStorageSwitchResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveStorageSwitchResponse self = new SaveStorageSwitchResponse();
        return TeaModel.build(map, self);
    }

    public SaveStorageSwitchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveStorageSwitchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveStorageSwitchResponse setBody(SaveStorageSwitchResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveStorageSwitchResponseBody getBody() {
        return this.body;
    }

}
