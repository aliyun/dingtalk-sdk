// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DataSyncResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DataSyncResponseBody body;

    public static DataSyncResponse build(java.util.Map<String, ?> map) throws Exception {
        DataSyncResponse self = new DataSyncResponse();
        return TeaModel.build(map, self);
    }

    public DataSyncResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DataSyncResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DataSyncResponse setBody(DataSyncResponseBody body) {
        this.body = body;
        return this;
    }
    public DataSyncResponseBody getBody() {
        return this.body;
    }

}
