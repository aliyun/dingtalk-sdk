// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CourseFinishCourseResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static CourseFinishCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CourseFinishCourseResponseBody self = new CourseFinishCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public CourseFinishCourseResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
