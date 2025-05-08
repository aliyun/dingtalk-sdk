// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalEntityCreateRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<Entity> body;

    public static AgoalEntityCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalEntityCreateRequest self = new AgoalEntityCreateRequest();
        return TeaModel.build(map, self);
    }

    public AgoalEntityCreateRequest setBody(java.util.List<Entity> body) {
        this.body = body;
        return this;
    }
    public java.util.List<Entity> getBody() {
        return this.body;
    }

}
