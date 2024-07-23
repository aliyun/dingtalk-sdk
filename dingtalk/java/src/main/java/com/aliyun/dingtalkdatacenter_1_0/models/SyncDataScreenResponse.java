// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class SyncDataScreenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncDataScreenResponseBody body;

    public static SyncDataScreenResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncDataScreenResponse self = new SyncDataScreenResponse();
        return TeaModel.build(map, self);
    }

    public SyncDataScreenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncDataScreenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncDataScreenResponse setBody(SyncDataScreenResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncDataScreenResponseBody getBody() {
        return this.body;
    }

}
