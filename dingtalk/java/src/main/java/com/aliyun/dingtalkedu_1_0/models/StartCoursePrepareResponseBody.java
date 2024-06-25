// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCoursePrepareResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("universityCourseCommonResponse")
    public StartCoursePrepareResponseBodyUniversityCourseCommonResponse universityCourseCommonResponse;

    public static StartCoursePrepareResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartCoursePrepareResponseBody self = new StartCoursePrepareResponseBody();
        return TeaModel.build(map, self);
    }

    public StartCoursePrepareResponseBody setUniversityCourseCommonResponse(StartCoursePrepareResponseBodyUniversityCourseCommonResponse universityCourseCommonResponse) {
        this.universityCourseCommonResponse = universityCourseCommonResponse;
        return this;
    }
    public StartCoursePrepareResponseBodyUniversityCourseCommonResponse getUniversityCourseCommonResponse() {
        return this.universityCourseCommonResponse;
    }

    public static class StartCoursePrepareResponseBodyUniversityCourseCommonResponse extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>testCourseCode</p>
         */
        @NameInMap("courseCode")
        public String courseCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static StartCoursePrepareResponseBodyUniversityCourseCommonResponse build(java.util.Map<String, ?> map) throws Exception {
            StartCoursePrepareResponseBodyUniversityCourseCommonResponse self = new StartCoursePrepareResponseBodyUniversityCourseCommonResponse();
            return TeaModel.build(map, self);
        }

        public StartCoursePrepareResponseBodyUniversityCourseCommonResponse setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public StartCoursePrepareResponseBodyUniversityCourseCommonResponse setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
