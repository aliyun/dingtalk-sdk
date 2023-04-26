// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduAssetSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateEduAssetSpaceResponseBody body;

    public static CreateEduAssetSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateEduAssetSpaceResponse self = new CreateEduAssetSpaceResponse();
        return TeaModel.build(map, self);
    }

    public CreateEduAssetSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateEduAssetSpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateEduAssetSpaceResponse setBody(CreateEduAssetSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateEduAssetSpaceResponseBody getBody() {
        return this.body;
    }

}
