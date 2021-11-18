// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCourseResponseBody extends TeaModel {
    @NameInMap("universityCourseCommonResponse")
    public StartCourseResponseBodyUniversityCourseCommonResponse universityCourseCommonResponse;

    public static StartCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartCourseResponseBody self = new StartCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public StartCourseResponseBody setUniversityCourseCommonResponse(StartCourseResponseBodyUniversityCourseCommonResponse universityCourseCommonResponse) {
        this.universityCourseCommonResponse = universityCourseCommonResponse;
        return this;
    }
    public StartCourseResponseBodyUniversityCourseCommonResponse getUniversityCourseCommonResponse() {
        return this.universityCourseCommonResponse;
    }

    public static class StartCourseResponseBodyUniversityCourseCommonResponse extends TeaModel {
        // 调用是否成功
        @NameInMap("success")
        public Boolean success;

        // 课程编码
        @NameInMap("courseCode")
        public String courseCode;

        public static StartCourseResponseBodyUniversityCourseCommonResponse build(java.util.Map<String, ?> map) throws Exception {
            StartCourseResponseBodyUniversityCourseCommonResponse self = new StartCourseResponseBodyUniversityCourseCommonResponse();
            return TeaModel.build(map, self);
        }

        public StartCourseResponseBodyUniversityCourseCommonResponse setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public StartCourseResponseBodyUniversityCourseCommonResponse setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

    }

}
