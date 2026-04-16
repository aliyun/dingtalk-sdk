// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchGetVoicePrintIdentifyConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchGetVoicePrintIdentifyConfigResponseBody body;

    public static BatchGetVoicePrintIdentifyConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetVoicePrintIdentifyConfigResponse self = new BatchGetVoicePrintIdentifyConfigResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetVoicePrintIdentifyConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetVoicePrintIdentifyConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchGetVoicePrintIdentifyConfigResponse setBody(BatchGetVoicePrintIdentifyConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetVoicePrintIdentifyConfigResponseBody getBody() {
        return this.body;
    }

}
