// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateContactsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchUpdateContactsResponseBody body;

    public static BatchUpdateContactsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateContactsResponse self = new BatchUpdateContactsResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateContactsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateContactsResponse setBody(BatchUpdateContactsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateContactsResponseBody getBody() {
        return this.body;
    }

}
