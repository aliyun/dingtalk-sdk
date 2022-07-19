// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleBinResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRecycleBinResponseBody body;

    public static GetRecycleBinResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRecycleBinResponse self = new GetRecycleBinResponse();
        return TeaModel.build(map, self);
    }

    public GetRecycleBinResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRecycleBinResponse setBody(GetRecycleBinResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecycleBinResponseBody getBody() {
        return this.body;
    }

}
