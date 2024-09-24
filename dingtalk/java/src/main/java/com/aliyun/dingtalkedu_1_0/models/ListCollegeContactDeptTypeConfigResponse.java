// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListCollegeContactDeptTypeConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListCollegeContactDeptTypeConfigResponseBody body;

    public static ListCollegeContactDeptTypeConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCollegeContactDeptTypeConfigResponse self = new ListCollegeContactDeptTypeConfigResponse();
        return TeaModel.build(map, self);
    }

    public ListCollegeContactDeptTypeConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCollegeContactDeptTypeConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListCollegeContactDeptTypeConfigResponse setBody(ListCollegeContactDeptTypeConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCollegeContactDeptTypeConfigResponseBody getBody() {
        return this.body;
    }

}
