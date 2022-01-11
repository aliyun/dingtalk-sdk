// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EndCourseResponseBody extends TeaModel {
    @NameInMap("universityCourseCommonResponse")
    public EndCourseResponseBodyUniversityCourseCommonResponse universityCourseCommonResponse;

    public static EndCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EndCourseResponseBody self = new EndCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public EndCourseResponseBody setUniversityCourseCommonResponse(EndCourseResponseBodyUniversityCourseCommonResponse universityCourseCommonResponse) {
        this.universityCourseCommonResponse = universityCourseCommonResponse;
        return this;
    }
    public EndCourseResponseBodyUniversityCourseCommonResponse getUniversityCourseCommonResponse() {
        return this.universityCourseCommonResponse;
    }

    public static class EndCourseResponseBodyUniversityCourseCommonResponse extends TeaModel {
        // 课程编码
        @NameInMap("courseCode")
        public String courseCode;

        // 调用是否成功
        @NameInMap("success")
        public Boolean success;

        public static EndCourseResponseBodyUniversityCourseCommonResponse build(java.util.Map<String, ?> map) throws Exception {
            EndCourseResponseBodyUniversityCourseCommonResponse self = new EndCourseResponseBodyUniversityCourseCommonResponse();
            return TeaModel.build(map, self);
        }

        public EndCourseResponseBodyUniversityCourseCommonResponse setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public EndCourseResponseBodyUniversityCourseCommonResponse setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
