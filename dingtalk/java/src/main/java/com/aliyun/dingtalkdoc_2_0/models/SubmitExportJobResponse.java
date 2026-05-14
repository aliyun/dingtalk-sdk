// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SubmitExportJobResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitExportJobResponseBody body;

    public static SubmitExportJobResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitExportJobResponse self = new SubmitExportJobResponse();
        return TeaModel.build(map, self);
    }

    public SubmitExportJobResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitExportJobResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitExportJobResponse setBody(SubmitExportJobResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitExportJobResponseBody getBody() {
        return this.body;
    }

}
