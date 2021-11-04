// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallOTOResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchRecallOTOResponseBody body;

    public static BatchRecallOTOResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallOTOResponse self = new BatchRecallOTOResponse();
        return TeaModel.build(map, self);
    }

    public BatchRecallOTOResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchRecallOTOResponse setBody(BatchRecallOTOResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchRecallOTOResponseBody getBody() {
        return this.body;
    }

}
