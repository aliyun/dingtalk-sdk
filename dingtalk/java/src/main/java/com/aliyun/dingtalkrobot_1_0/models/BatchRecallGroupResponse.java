// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BatchRecallGroupResponseBody body;

    public static BatchRecallGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallGroupResponse self = new BatchRecallGroupResponse();
        return TeaModel.build(map, self);
    }

    public BatchRecallGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchRecallGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchRecallGroupResponse setBody(BatchRecallGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchRecallGroupResponseBody getBody() {
        return this.body;
    }

}
