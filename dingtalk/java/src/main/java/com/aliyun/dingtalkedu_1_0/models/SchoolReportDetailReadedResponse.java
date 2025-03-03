// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SchoolReportDetailReadedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SchoolReportDetailReadedResponseBody body;

    public static SchoolReportDetailReadedResponse build(java.util.Map<String, ?> map) throws Exception {
        SchoolReportDetailReadedResponse self = new SchoolReportDetailReadedResponse();
        return TeaModel.build(map, self);
    }

    public SchoolReportDetailReadedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SchoolReportDetailReadedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SchoolReportDetailReadedResponse setBody(SchoolReportDetailReadedResponseBody body) {
        this.body = body;
        return this;
    }
    public SchoolReportDetailReadedResponseBody getBody() {
        return this.body;
    }

}
