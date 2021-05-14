// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOTOResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchSendOTOResponseBody body;

    public static BatchSendOTOResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOTOResponse self = new BatchSendOTOResponse();
        return TeaModel.build(map, self);
    }

    public BatchSendOTOResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchSendOTOResponse setBody(BatchSendOTOResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchSendOTOResponseBody getBody() {
        return this.body;
    }

}
