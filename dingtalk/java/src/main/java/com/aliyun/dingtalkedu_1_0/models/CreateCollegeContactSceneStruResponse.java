// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCollegeContactSceneStruResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCollegeContactSceneStruResponseBody body;

    public static CreateCollegeContactSceneStruResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCollegeContactSceneStruResponse self = new CreateCollegeContactSceneStruResponse();
        return TeaModel.build(map, self);
    }

    public CreateCollegeContactSceneStruResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCollegeContactSceneStruResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCollegeContactSceneStruResponse setBody(CreateCollegeContactSceneStruResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCollegeContactSceneStruResponseBody getBody() {
        return this.body;
    }

}
