// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityCourseGroupResponseBody extends TeaModel {
    // 课程组信息
    @NameInMap("courseGroupInfo")
    public CreateUniversityCourseGroupResponseBodyCourseGroupInfo courseGroupInfo;

    public static CreateUniversityCourseGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityCourseGroupResponseBody self = new CreateUniversityCourseGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateUniversityCourseGroupResponseBody setCourseGroupInfo(CreateUniversityCourseGroupResponseBodyCourseGroupInfo courseGroupInfo) {
        this.courseGroupInfo = courseGroupInfo;
        return this;
    }
    public CreateUniversityCourseGroupResponseBodyCourseGroupInfo getCourseGroupInfo() {
        return this.courseGroupInfo;
    }

    public static class CreateUniversityCourseGroupResponseBodyCourseGroupInfo extends TeaModel {
        // 课程组编码
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        public static CreateUniversityCourseGroupResponseBodyCourseGroupInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateUniversityCourseGroupResponseBodyCourseGroupInfo self = new CreateUniversityCourseGroupResponseBodyCourseGroupInfo();
            return TeaModel.build(map, self);
        }

        public CreateUniversityCourseGroupResponseBodyCourseGroupInfo setCourseGroupCode(String courseGroupCode) {
            this.courseGroupCode = courseGroupCode;
            return this;
        }
        public String getCourseGroupCode() {
            return this.courseGroupCode;
        }

    }

}
