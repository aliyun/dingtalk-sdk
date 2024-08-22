// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ExportDocResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExportDocResponseBody body;

    public static ExportDocResponse build(java.util.Map<String, ?> map) throws Exception {
        ExportDocResponse self = new ExportDocResponse();
        return TeaModel.build(map, self);
    }

    public ExportDocResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExportDocResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExportDocResponse setBody(ExportDocResponseBody body) {
        this.body = body;
        return this;
    }
    public ExportDocResponseBody getBody() {
        return this.body;
    }

}
