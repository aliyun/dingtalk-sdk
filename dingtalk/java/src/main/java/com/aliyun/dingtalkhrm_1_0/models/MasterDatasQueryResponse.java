// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDatasQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MasterDatasQueryResponseBody body;

    public static MasterDatasQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        MasterDatasQueryResponse self = new MasterDatasQueryResponse();
        return TeaModel.build(map, self);
    }

    public MasterDatasQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MasterDatasQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MasterDatasQueryResponse setBody(MasterDatasQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public MasterDatasQueryResponseBody getBody() {
        return this.body;
    }

}
