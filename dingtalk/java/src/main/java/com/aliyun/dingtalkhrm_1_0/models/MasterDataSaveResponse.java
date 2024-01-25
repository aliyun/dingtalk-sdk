// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataSaveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MasterDataSaveResponseBody body;

    public static MasterDataSaveResponse build(java.util.Map<String, ?> map) throws Exception {
        MasterDataSaveResponse self = new MasterDataSaveResponse();
        return TeaModel.build(map, self);
    }

    public MasterDataSaveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MasterDataSaveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MasterDataSaveResponse setBody(MasterDataSaveResponseBody body) {
        this.body = body;
        return this;
    }
    public MasterDataSaveResponseBody getBody() {
        return this.body;
    }

}
