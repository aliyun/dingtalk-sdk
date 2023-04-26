// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RelatedSpacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RelatedSpacesResponseBody body;

    public static RelatedSpacesResponse build(java.util.Map<String, ?> map) throws Exception {
        RelatedSpacesResponse self = new RelatedSpacesResponse();
        return TeaModel.build(map, self);
    }

    public RelatedSpacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RelatedSpacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RelatedSpacesResponse setBody(RelatedSpacesResponseBody body) {
        this.body = body;
        return this;
    }
    public RelatedSpacesResponseBody getBody() {
        return this.body;
    }

}
