// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityCourseGroupResponseBody extends TeaModel {
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
        /**
         * <strong>example:</strong>
         * <p>GS10001</p>
         */
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
