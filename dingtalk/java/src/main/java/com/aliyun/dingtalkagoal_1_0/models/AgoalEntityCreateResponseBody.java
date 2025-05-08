// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalEntityCreateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static AgoalEntityCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalEntityCreateResponseBody self = new AgoalEntityCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalEntityCreateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AgoalEntityCreateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
