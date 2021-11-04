// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityCourseGroupRequest extends TeaModel {
    // 操作人
    @NameInMap("opUserId")
    public String opUserId;

    // 课程组编码
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    public static DeleteUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityCourseGroupRequest self = new DeleteUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public DeleteUniversityCourseGroupRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

}
