// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MasterDataQueryResponseBody body;

    public static MasterDataQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        MasterDataQueryResponse self = new MasterDataQueryResponse();
        return TeaModel.build(map, self);
    }

    public MasterDataQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MasterDataQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MasterDataQueryResponse setBody(MasterDataQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public MasterDataQueryResponseBody getBody() {
        return this.body;
    }

}
