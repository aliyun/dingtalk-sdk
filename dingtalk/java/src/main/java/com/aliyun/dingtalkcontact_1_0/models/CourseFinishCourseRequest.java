// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CourseFinishCourseRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>isv_code_cert_id_001</p>
     */
    @NameInMap("certId")
    public String certId;

    /**
     * <strong>example:</strong>
     * <p>data:image/(?:png|jpeg|gif|bmp|webp);base64</p>
     */
    @NameInMap("certMediaBase64")
    public String certMediaBase64;

    /**
     * <strong>example:</strong>
     * <p>isv_code_course_01</p>
     */
    @NameInMap("courseId")
    public String courseId;

    /**
     * <strong>example:</strong>
     * <p>pass</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>xxxxx001</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CourseFinishCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        CourseFinishCourseRequest self = new CourseFinishCourseRequest();
        return TeaModel.build(map, self);
    }

    public CourseFinishCourseRequest setCertId(String certId) {
        this.certId = certId;
        return this;
    }
    public String getCertId() {
        return this.certId;
    }

    public CourseFinishCourseRequest setCertMediaBase64(String certMediaBase64) {
        this.certMediaBase64 = certMediaBase64;
        return this;
    }
    public String getCertMediaBase64() {
        return this.certMediaBase64;
    }

    public CourseFinishCourseRequest setCourseId(String courseId) {
        this.courseId = courseId;
        return this;
    }
    public String getCourseId() {
        return this.courseId;
    }

    public CourseFinishCourseRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public CourseFinishCourseRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
