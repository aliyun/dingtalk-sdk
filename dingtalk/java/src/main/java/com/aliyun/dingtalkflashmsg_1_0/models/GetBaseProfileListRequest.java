// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetBaseProfileListRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    public static GetBaseProfileListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBaseProfileListRequest self = new GetBaseProfileListRequest();
        return TeaModel.build(map, self);
    }

    public GetBaseProfileListRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
