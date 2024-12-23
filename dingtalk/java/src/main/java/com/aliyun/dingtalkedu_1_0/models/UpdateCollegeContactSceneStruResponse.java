// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactSceneStruResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCollegeContactSceneStruResponseBody body;

    public static UpdateCollegeContactSceneStruResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactSceneStruResponse self = new UpdateCollegeContactSceneStruResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactSceneStruResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCollegeContactSceneStruResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCollegeContactSceneStruResponse setBody(UpdateCollegeContactSceneStruResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCollegeContactSceneStruResponseBody getBody() {
        return this.body;
    }

}
