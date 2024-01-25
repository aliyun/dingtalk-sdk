// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class GetSendAndReceiveReportListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSendAndReceiveReportListResponseBody body;

    public static GetSendAndReceiveReportListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSendAndReceiveReportListResponse self = new GetSendAndReceiveReportListResponse();
        return TeaModel.build(map, self);
    }

    public GetSendAndReceiveReportListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSendAndReceiveReportListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSendAndReceiveReportListResponse setBody(GetSendAndReceiveReportListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSendAndReceiveReportListResponseBody getBody() {
        return this.body;
    }

}
