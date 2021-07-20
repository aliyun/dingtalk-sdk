// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitCoursesOfClassResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public String result;

    public static InitCoursesOfClassResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitCoursesOfClassResponseBody self = new InitCoursesOfClassResponseBody();
        return TeaModel.build(map, self);
    }

    public InitCoursesOfClassResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
