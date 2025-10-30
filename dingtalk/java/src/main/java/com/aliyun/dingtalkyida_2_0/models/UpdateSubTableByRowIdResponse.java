// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateSubTableByRowIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateSubTableByRowIdResponseBody body;

    public static UpdateSubTableByRowIdResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubTableByRowIdResponse self = new UpdateSubTableByRowIdResponse();
        return TeaModel.build(map, self);
    }

    public UpdateSubTableByRowIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateSubTableByRowIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateSubTableByRowIdResponse setBody(UpdateSubTableByRowIdResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateSubTableByRowIdResponseBody getBody() {
        return this.body;
    }

}
