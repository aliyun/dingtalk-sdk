// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SubscribeUniversityCourseGroupRequest extends TeaModel {
    /**
     * <p>课程组编号</p>
     */
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    /**
     * <p>学生用户Id</p>
     */
    @NameInMap("studentUserIds")
    public java.util.List<String> studentUserIds;

    /**
     * <p>操作人id</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static SubscribeUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        SubscribeUniversityCourseGroupRequest self = new SubscribeUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public SubscribeUniversityCourseGroupRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

    public SubscribeUniversityCourseGroupRequest setStudentUserIds(java.util.List<String> studentUserIds) {
        this.studentUserIds = studentUserIds;
        return this;
    }
    public java.util.List<String> getStudentUserIds() {
        return this.studentUserIds;
    }

    public SubscribeUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
