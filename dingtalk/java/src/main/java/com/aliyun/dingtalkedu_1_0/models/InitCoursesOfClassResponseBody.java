// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitCoursesOfClassResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static InitCoursesOfClassResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitCoursesOfClassResponseBody self = new InitCoursesOfClassResponseBody();
        return TeaModel.build(map, self);
    }

    public InitCoursesOfClassResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
