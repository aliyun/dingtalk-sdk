// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SaveFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveFormInstanceResponseBody body;

    public static SaveFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveFormInstanceResponse self = new SaveFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public SaveFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveFormInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveFormInstanceResponse setBody(SaveFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveFormInstanceResponseBody getBody() {
        return this.body;
    }

}
