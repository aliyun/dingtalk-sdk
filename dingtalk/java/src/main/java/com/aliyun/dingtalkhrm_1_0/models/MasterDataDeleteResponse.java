// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataDeleteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MasterDataDeleteResponseBody body;

    public static MasterDataDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        MasterDataDeleteResponse self = new MasterDataDeleteResponse();
        return TeaModel.build(map, self);
    }

    public MasterDataDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MasterDataDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MasterDataDeleteResponse setBody(MasterDataDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public MasterDataDeleteResponseBody getBody() {
        return this.body;
    }

}
