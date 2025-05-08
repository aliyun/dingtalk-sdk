// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPerfTaskCreateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static AgoalPerfTaskCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalPerfTaskCreateResponseBody self = new AgoalPerfTaskCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalPerfTaskCreateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AgoalPerfTaskCreateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
