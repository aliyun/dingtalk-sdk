// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceChapterSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetServiceChapterSummaryResponseBody body;

    public static GetServiceChapterSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetServiceChapterSummaryResponse self = new GetServiceChapterSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetServiceChapterSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetServiceChapterSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetServiceChapterSummaryResponse setBody(GetServiceChapterSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetServiceChapterSummaryResponseBody getBody() {
        return this.body;
    }

}
