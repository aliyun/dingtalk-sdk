// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class ListItemUserDataRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    public static ListItemUserDataRequest build(java.util.Map<String, ?> map) throws Exception {
        ListItemUserDataRequest self = new ListItemUserDataRequest();
        return TeaModel.build(map, self);
    }

    public ListItemUserDataRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
