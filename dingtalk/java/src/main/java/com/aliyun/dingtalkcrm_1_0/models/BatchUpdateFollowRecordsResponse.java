// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFollowRecordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchUpdateFollowRecordsResponse setBody(BatchUpdateFollowRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateFollowRecordsResponseBody getBody() {
        return this.body;
    }

}
