// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddFollowRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchAddFollowRecordsResponseBody body;

    public static BatchAddFollowRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchAddFollowRecordsResponse self = new BatchAddFollowRecordsResponse();
        return TeaModel.build(map, self);
    }

    public BatchAddFollowRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchAddFollowRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchAddFollowRecordsResponse setBody(BatchAddFollowRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchAddFollowRecordsResponseBody getBody() {
        return this.body;
    }

}
