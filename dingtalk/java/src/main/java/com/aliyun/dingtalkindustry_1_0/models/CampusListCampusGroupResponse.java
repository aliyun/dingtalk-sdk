// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListCampusGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CampusListCampusGroupResponseBody body;

    public static CampusListCampusGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusListCampusGroupResponse self = new CampusListCampusGroupResponse();
        return TeaModel.build(map, self);
    }

    public CampusListCampusGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CampusListCampusGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CampusListCampusGroupResponse setBody(CampusListCampusGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CampusListCampusGroupResponseBody getBody() {
        return this.body;
    }

}
