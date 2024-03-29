// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceMapResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchUpdateFormDataByInstanceMapResponseBody body;

    public static BatchUpdateFormDataByInstanceMapResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFormDataByInstanceMapResponse self = new BatchUpdateFormDataByInstanceMapResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFormDataByInstanceMapResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateFormDataByInstanceMapResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchUpdateFormDataByInstanceMapResponse setBody(BatchUpdateFormDataByInstanceMapResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateFormDataByInstanceMapResponseBody getBody() {
        return this.body;
    }

}
