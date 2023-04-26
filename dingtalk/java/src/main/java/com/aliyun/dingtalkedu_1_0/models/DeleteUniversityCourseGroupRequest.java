// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityCourseGroupRequest extends TeaModel {
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    @NameInMap("opUserId")
    public String opUserId;

    public static DeleteUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityCourseGroupRequest self = new DeleteUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityCourseGroupRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

    public DeleteUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
