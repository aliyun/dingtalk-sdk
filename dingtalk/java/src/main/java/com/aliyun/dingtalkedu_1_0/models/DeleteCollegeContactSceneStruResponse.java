// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeContactSceneStruResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCollegeContactSceneStruResponseBody body;

    public static DeleteCollegeContactSceneStruResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeContactSceneStruResponse self = new DeleteCollegeContactSceneStruResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeContactSceneStruResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCollegeContactSceneStruResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCollegeContactSceneStruResponse setBody(DeleteCollegeContactSceneStruResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCollegeContactSceneStruResponseBody getBody() {
        return this.body;
    }

}
