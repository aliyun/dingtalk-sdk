// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetUserMetricDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserMetricDataResponseBody body;

    public static GetUserMetricDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserMetricDataResponse self = new GetUserMetricDataResponse();
        return TeaModel.build(map, self);
    }

    public GetUserMetricDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserMetricDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserMetricDataResponse setBody(GetUserMetricDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserMetricDataResponseBody getBody() {
        return this.body;
    }

}
