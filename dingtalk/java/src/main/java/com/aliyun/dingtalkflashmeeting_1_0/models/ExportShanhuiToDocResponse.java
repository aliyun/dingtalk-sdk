// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class ExportShanhuiToDocResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExportShanhuiToDocResponseBody body;

    public static ExportShanhuiToDocResponse build(java.util.Map<String, ?> map) throws Exception {
        ExportShanhuiToDocResponse self = new ExportShanhuiToDocResponse();
        return TeaModel.build(map, self);
    }

    public ExportShanhuiToDocResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExportShanhuiToDocResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExportShanhuiToDocResponse setBody(ExportShanhuiToDocResponseBody body) {
        this.body = body;
        return this;
    }
    public ExportShanhuiToDocResponseBody getBody() {
        return this.body;
    }

}
