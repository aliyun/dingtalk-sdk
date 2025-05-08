// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPerfTaskUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static AgoalPerfTaskUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalPerfTaskUpdateResponseBody self = new AgoalPerfTaskUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalPerfTaskUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AgoalPerfTaskUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
