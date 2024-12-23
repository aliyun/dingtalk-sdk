// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EnableCollegeContactSceneStruResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EnableCollegeContactSceneStruResponseBody body;

    public static EnableCollegeContactSceneStruResponse build(java.util.Map<String, ?> map) throws Exception {
        EnableCollegeContactSceneStruResponse self = new EnableCollegeContactSceneStruResponse();
        return TeaModel.build(map, self);
    }

    public EnableCollegeContactSceneStruResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EnableCollegeContactSceneStruResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EnableCollegeContactSceneStruResponse setBody(EnableCollegeContactSceneStruResponseBody body) {
        this.body = body;
        return this;
    }
    public EnableCollegeContactSceneStruResponseBody getBody() {
        return this.body;
    }

}
