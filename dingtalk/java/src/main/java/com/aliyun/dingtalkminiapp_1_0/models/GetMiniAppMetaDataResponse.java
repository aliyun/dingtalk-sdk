// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetMiniAppMetaDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMiniAppMetaDataResponseBody body;

    public static GetMiniAppMetaDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMiniAppMetaDataResponse self = new GetMiniAppMetaDataResponse();
        return TeaModel.build(map, self);
    }

    public GetMiniAppMetaDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMiniAppMetaDataResponse setBody(GetMiniAppMetaDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMiniAppMetaDataResponseBody getBody() {
        return this.body;
    }

}
