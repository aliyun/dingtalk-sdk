// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchUpdateFormDataByInstanceIdResponseBody body;

    public static BatchUpdateFormDataByInstanceIdResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFormDataByInstanceIdResponse self = new BatchUpdateFormDataByInstanceIdResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFormDataByInstanceIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateFormDataByInstanceIdResponse setBody(BatchUpdateFormDataByInstanceIdResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateFormDataByInstanceIdResponseBody getBody() {
        return this.body;
    }

}
