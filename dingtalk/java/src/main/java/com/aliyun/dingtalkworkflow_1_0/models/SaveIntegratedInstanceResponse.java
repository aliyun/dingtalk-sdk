// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveIntegratedInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveIntegratedInstanceResponseBody body;

    public static SaveIntegratedInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveIntegratedInstanceResponse self = new SaveIntegratedInstanceResponse();
        return TeaModel.build(map, self);
    }

    public SaveIntegratedInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveIntegratedInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveIntegratedInstanceResponse setBody(SaveIntegratedInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveIntegratedInstanceResponseBody getBody() {
        return this.body;
    }

}
