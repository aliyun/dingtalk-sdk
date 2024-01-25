// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchRemoveFollowRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchRemoveFollowRecordsResponseBody body;

    public static BatchRemoveFollowRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchRemoveFollowRecordsResponse self = new BatchRemoveFollowRecordsResponse();
        return TeaModel.build(map, self);
    }

    public BatchRemoveFollowRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchRemoveFollowRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchRemoveFollowRecordsResponse setBody(BatchRemoveFollowRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchRemoveFollowRecordsResponseBody getBody() {
        return this.body;
    }

}
