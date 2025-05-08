// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPerfTaskUpdateRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<PerfTask> body;

    public static AgoalPerfTaskUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalPerfTaskUpdateRequest self = new AgoalPerfTaskUpdateRequest();
        return TeaModel.build(map, self);
    }

    public AgoalPerfTaskUpdateRequest setBody(java.util.List<PerfTask> body) {
        this.body = body;
        return this;
    }
    public java.util.List<PerfTask> getBody() {
        return this.body;
    }

}
