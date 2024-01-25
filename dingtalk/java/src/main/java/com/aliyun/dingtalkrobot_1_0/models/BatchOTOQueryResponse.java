// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchOTOQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchOTOQueryResponseBody body;

    public static BatchOTOQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchOTOQueryResponse self = new BatchOTOQueryResponse();
        return TeaModel.build(map, self);
    }

    public BatchOTOQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchOTOQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchOTOQueryResponse setBody(BatchOTOQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchOTOQueryResponseBody getBody() {
        return this.body;
    }

}
