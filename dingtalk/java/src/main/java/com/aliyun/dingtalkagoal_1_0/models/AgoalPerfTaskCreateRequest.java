// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPerfTaskCreateRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<PerfTask> body;

    public static AgoalPerfTaskCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalPerfTaskCreateRequest self = new AgoalPerfTaskCreateRequest();
        return TeaModel.build(map, self);
    }

    public AgoalPerfTaskCreateRequest setBody(java.util.List<PerfTask> body) {
        this.body = body;
        return this;
    }
    public java.util.List<PerfTask> getBody() {
        return this.body;
    }

}
