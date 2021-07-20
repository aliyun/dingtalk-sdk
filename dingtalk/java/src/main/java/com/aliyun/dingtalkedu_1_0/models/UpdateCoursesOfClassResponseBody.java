// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCoursesOfClassResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public Boolean result;

    public static UpdateCoursesOfClassResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCoursesOfClassResponseBody self = new UpdateCoursesOfClassResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCoursesOfClassResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
