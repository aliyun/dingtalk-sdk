// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGrantProcessInstanceForDownloadFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGrantProcessInstanceForDownloadFileResponseBody body;

    public static PremiumGrantProcessInstanceForDownloadFileResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGrantProcessInstanceForDownloadFileResponse self = new PremiumGrantProcessInstanceForDownloadFileResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGrantProcessInstanceForDownloadFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGrantProcessInstanceForDownloadFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGrantProcessInstanceForDownloadFileResponse setBody(PremiumGrantProcessInstanceForDownloadFileResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGrantProcessInstanceForDownloadFileResponseBody getBody() {
        return this.body;
    }

}
