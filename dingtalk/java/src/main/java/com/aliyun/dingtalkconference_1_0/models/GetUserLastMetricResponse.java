// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetUserLastMetricResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserLastMetricResponseBody body;

    public static GetUserLastMetricResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserLastMetricResponse self = new GetUserLastMetricResponse();
        return TeaModel.build(map, self);
    }

    public GetUserLastMetricResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserLastMetricResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserLastMetricResponse setBody(GetUserLastMetricResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserLastMetricResponseBody getBody() {
        return this.body;
    }

}
