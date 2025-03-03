// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteSchoolReportResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteSchoolReportResponseBody body;

    public static DeleteSchoolReportResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteSchoolReportResponse self = new DeleteSchoolReportResponse();
        return TeaModel.build(map, self);
    }

    public DeleteSchoolReportResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteSchoolReportResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteSchoolReportResponse setBody(DeleteSchoolReportResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteSchoolReportResponseBody getBody() {
        return this.body;
    }

}
