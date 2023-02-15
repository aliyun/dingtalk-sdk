// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchRemoveFollowRecordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchRemoveFollowRecordsResponse setBody(BatchRemoveFollowRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchRemoveFollowRecordsResponseBody getBody() {
        return this.body;
    }

}
