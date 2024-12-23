// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListCollegeContactSceneStrusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListCollegeContactSceneStrusResponseBody body;

    public static ListCollegeContactSceneStrusResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCollegeContactSceneStrusResponse self = new ListCollegeContactSceneStrusResponse();
        return TeaModel.build(map, self);
    }

    public ListCollegeContactSceneStrusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCollegeContactSceneStrusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListCollegeContactSceneStrusResponse setBody(ListCollegeContactSceneStrusResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCollegeContactSceneStrusResponseBody getBody() {
        return this.body;
    }

}
