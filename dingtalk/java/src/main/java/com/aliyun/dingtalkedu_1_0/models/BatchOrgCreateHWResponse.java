// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchOrgCreateHWResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchOrgCreateHWResponseBody body;

    public static BatchOrgCreateHWResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchOrgCreateHWResponse self = new BatchOrgCreateHWResponse();
        return TeaModel.build(map, self);
    }

    public BatchOrgCreateHWResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchOrgCreateHWResponse setBody(BatchOrgCreateHWResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchOrgCreateHWResponseBody getBody() {
        return this.body;
    }

}
