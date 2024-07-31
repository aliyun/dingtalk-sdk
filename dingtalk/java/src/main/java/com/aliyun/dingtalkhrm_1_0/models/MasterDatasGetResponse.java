// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDatasGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MasterDatasGetResponseBody body;

    public static MasterDatasGetResponse build(java.util.Map<String, ?> map) throws Exception {
        MasterDatasGetResponse self = new MasterDatasGetResponse();
        return TeaModel.build(map, self);
    }

    public MasterDatasGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MasterDatasGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MasterDatasGetResponse setBody(MasterDatasGetResponseBody body) {
        this.body = body;
        return this;
    }
    public MasterDatasGetResponseBody getBody() {
        return this.body;
    }

}
