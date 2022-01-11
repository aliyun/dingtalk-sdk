// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUniversityCourseGroupRequest extends TeaModel {
    // 课程编码
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    // 操作人
    @NameInMap("opUserId")
    public String opUserId;

    public static QueryUniversityCourseGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUniversityCourseGroupRequest self = new QueryUniversityCourseGroupRequest();
        return TeaModel.build(map, self);
    }

    public QueryUniversityCourseGroupRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

    public QueryUniversityCourseGroupRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
