// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataSaveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public MasterDataSaveResponse setBody(MasterDataSaveResponseBody body) {
        this.body = body;
        return this;
    }
    public MasterDataSaveResponseBody getBody() {
        return this.body;
    }

}
