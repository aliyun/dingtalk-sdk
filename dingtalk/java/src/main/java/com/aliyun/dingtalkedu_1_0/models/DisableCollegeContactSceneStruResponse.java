// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DisableCollegeContactSceneStruResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DisableCollegeContactSceneStruResponseBody body;

    public static DisableCollegeContactSceneStruResponse build(java.util.Map<String, ?> map) throws Exception {
        DisableCollegeContactSceneStruResponse self = new DisableCollegeContactSceneStruResponse();
        return TeaModel.build(map, self);
    }

    public DisableCollegeContactSceneStruResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DisableCollegeContactSceneStruResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DisableCollegeContactSceneStruResponse setBody(DisableCollegeContactSceneStruResponseBody body) {
        this.body = body;
        return this;
    }
    public DisableCollegeContactSceneStruResponseBody getBody() {
        return this.body;
    }

}
