// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTeacherCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    @NameInMap("success")
    public Boolean success;

    public static CreateTeacherCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTeacherCourseResponseBody self = new CreateTeacherCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTeacherCourseResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

    public CreateTeacherCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
