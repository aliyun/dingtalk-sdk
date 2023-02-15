// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddFollowRecordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchAddFollowRecordsResponse setBody(BatchAddFollowRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchAddFollowRecordsResponseBody getBody() {
        return this.body;
    }

}
