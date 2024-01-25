// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsvMetadataQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IsvMetadataQueryResponseBody body;

    public static IsvMetadataQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        IsvMetadataQueryResponse self = new IsvMetadataQueryResponse();
        return TeaModel.build(map, self);
    }

    public IsvMetadataQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IsvMetadataQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IsvMetadataQueryResponse setBody(IsvMetadataQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public IsvMetadataQueryResponseBody getBody() {
        return this.body;
    }

}
