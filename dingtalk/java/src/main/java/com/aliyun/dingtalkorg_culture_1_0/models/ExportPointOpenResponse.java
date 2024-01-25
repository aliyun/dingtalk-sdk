// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ExportPointOpenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExportPointOpenResponseBody body;

    public static ExportPointOpenResponse build(java.util.Map<String, ?> map) throws Exception {
        ExportPointOpenResponse self = new ExportPointOpenResponse();
        return TeaModel.build(map, self);
    }

    public ExportPointOpenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExportPointOpenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExportPointOpenResponse setBody(ExportPointOpenResponseBody body) {
        this.body = body;
        return this;
    }
    public ExportPointOpenResponseBody getBody() {
        return this.body;
    }

}
