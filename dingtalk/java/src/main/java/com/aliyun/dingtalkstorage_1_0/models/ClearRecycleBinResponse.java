// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ClearRecycleBinResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ClearRecycleBinResponseBody body;

    public static ClearRecycleBinResponse build(java.util.Map<String, ?> map) throws Exception {
        ClearRecycleBinResponse self = new ClearRecycleBinResponse();
        return TeaModel.build(map, self);
    }

    public ClearRecycleBinResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ClearRecycleBinResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ClearRecycleBinResponse setBody(ClearRecycleBinResponseBody body) {
        this.body = body;
        return this;
    }
    public ClearRecycleBinResponseBody getBody() {
        return this.body;
    }

}
