// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PublishSchoolReportResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PublishSchoolReportResponseBody body;

    public static PublishSchoolReportResponse build(java.util.Map<String, ?> map) throws Exception {
        PublishSchoolReportResponse self = new PublishSchoolReportResponse();
        return TeaModel.build(map, self);
    }

    public PublishSchoolReportResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PublishSchoolReportResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PublishSchoolReportResponse setBody(PublishSchoolReportResponseBody body) {
        this.body = body;
        return this;
    }
    public PublishSchoolReportResponseBody getBody() {
        return this.body;
    }

}
