// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeUniversityCourseGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("studentUserIds")
    public java.util.List<String> studentUserIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static UnsubscribeUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UnsubscribeUniversityCourseGroupRequest self = new UnsubscribeUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public UnsubscribeUniversityCourseGroupRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

    public UnsubscribeUniversityCourseGroupRequest setStudentUserIds(java.util.List<String> studentUserIds) {
        this.studentUserIds = studentUserIds;
        return this;
    }
    public java.util.List<String> getStudentUserIds() {
        return this.studentUserIds;
    }

    public UnsubscribeUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
