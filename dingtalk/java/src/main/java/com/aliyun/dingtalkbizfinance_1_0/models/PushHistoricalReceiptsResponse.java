// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class PushHistoricalReceiptsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PushHistoricalReceiptsResponseBody body;

    public static PushHistoricalReceiptsResponse build(java.util.Map<String, ?> map) throws Exception {
        PushHistoricalReceiptsResponse self = new PushHistoricalReceiptsResponse();
        return TeaModel.build(map, self);
    }

    public PushHistoricalReceiptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushHistoricalReceiptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushHistoricalReceiptsResponse setBody(PushHistoricalReceiptsResponseBody body) {
        this.body = body;
        return this;
    }
    public PushHistoricalReceiptsResponseBody getBody() {
        return this.body;
    }

}
