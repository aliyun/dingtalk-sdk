// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchGetGroupSetConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchGetGroupSetConfigResponseBody body;

    public static BatchGetGroupSetConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetGroupSetConfigResponse self = new BatchGetGroupSetConfigResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetGroupSetConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetGroupSetConfigResponse setBody(BatchGetGroupSetConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetGroupSetConfigResponseBody getBody() {
        return this.body;
    }

}
