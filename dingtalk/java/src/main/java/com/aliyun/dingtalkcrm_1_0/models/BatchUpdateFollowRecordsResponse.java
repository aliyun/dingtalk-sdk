// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFollowRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchUpdateFollowRecordsResponseBody body;

    public static BatchUpdateFollowRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFollowRecordsResponse self = new BatchUpdateFollowRecordsResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFollowRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateFollowRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchUpdateFollowRecordsResponse setBody(BatchUpdateFollowRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateFollowRecordsResponseBody getBody() {
        return this.body;
    }

}
