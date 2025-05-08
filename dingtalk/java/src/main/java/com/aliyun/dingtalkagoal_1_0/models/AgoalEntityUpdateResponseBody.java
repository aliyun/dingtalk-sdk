// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalEntityUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static AgoalEntityUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalEntityUpdateResponseBody self = new AgoalEntityUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalEntityUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AgoalEntityUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
