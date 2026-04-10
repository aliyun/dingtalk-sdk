// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SyncCheckedDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncCheckedDataResponseBody body;

    public static SyncCheckedDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncCheckedDataResponse self = new SyncCheckedDataResponse();
        return TeaModel.build(map, self);
    }

    public SyncCheckedDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncCheckedDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncCheckedDataResponse setBody(SyncCheckedDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncCheckedDataResponseBody getBody() {
        return this.body;
    }

}
