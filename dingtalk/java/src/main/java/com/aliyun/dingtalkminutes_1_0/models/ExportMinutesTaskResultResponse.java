// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class ExportMinutesTaskResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExportMinutesTaskResultResponseBody body;

    public static ExportMinutesTaskResultResponse build(java.util.Map<String, ?> map) throws Exception {
        ExportMinutesTaskResultResponse self = new ExportMinutesTaskResultResponse();
        return TeaModel.build(map, self);
    }

    public ExportMinutesTaskResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExportMinutesTaskResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExportMinutesTaskResultResponse setBody(ExportMinutesTaskResultResponseBody body) {
        this.body = body;
        return this;
    }
    public ExportMinutesTaskResultResponseBody getBody() {
        return this.body;
    }

}
