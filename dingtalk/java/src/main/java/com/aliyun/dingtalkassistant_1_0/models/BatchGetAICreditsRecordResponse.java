// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class BatchGetAICreditsRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchGetAICreditsRecordResponseBody body;

    public static BatchGetAICreditsRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetAICreditsRecordResponse self = new BatchGetAICreditsRecordResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetAICreditsRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetAICreditsRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchGetAICreditsRecordResponse setBody(BatchGetAICreditsRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetAICreditsRecordResponseBody getBody() {
        return this.body;
    }

}
