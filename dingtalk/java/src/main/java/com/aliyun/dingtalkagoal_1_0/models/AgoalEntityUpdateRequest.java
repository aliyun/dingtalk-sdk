// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalEntityUpdateRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<Entity> body;

    public static AgoalEntityUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalEntityUpdateRequest self = new AgoalEntityUpdateRequest();
        return TeaModel.build(map, self);
    }

    public AgoalEntityUpdateRequest setBody(java.util.List<Entity> body) {
        this.body = body;
        return this;
    }
    public java.util.List<Entity> getBody() {
        return this.body;
    }

}
