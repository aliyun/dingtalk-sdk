// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class GetSubmitStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSubmitStatisticsResponseBody body;

    public static GetSubmitStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSubmitStatisticsResponse self = new GetSubmitStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public GetSubmitStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSubmitStatisticsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSubmitStatisticsResponse setBody(GetSubmitStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSubmitStatisticsResponseBody getBody() {
        return this.body;
    }

}
