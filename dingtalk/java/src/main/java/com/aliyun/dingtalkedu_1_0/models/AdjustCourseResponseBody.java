// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AdjustCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    @NameInMap("success")
    public Boolean success;

    public static AdjustCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AdjustCourseResponseBody self = new AdjustCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public AdjustCourseResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

    public AdjustCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
