// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchSaveFormDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchSaveFormDataResponseBody body;

    public static BatchSaveFormDataResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchSaveFormDataResponse self = new BatchSaveFormDataResponse();
        return TeaModel.build(map, self);
    }

    public BatchSaveFormDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchSaveFormDataResponse setBody(BatchSaveFormDataResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchSaveFormDataResponseBody getBody() {
        return this.body;
    }

}
