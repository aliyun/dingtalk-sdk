// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetOpenCourseDetailResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courseId")
    public String courseId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courseType")
    public Long courseType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("coverUrl")
    public String coverUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("introduction")
    public String introduction;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pushModel")
    public GetOpenCourseDetailResponseBodyPushModel pushModel;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teacherId")
    public String teacherId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teacherName")
    public String teacherName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    public static GetOpenCourseDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOpenCourseDetailResponseBody self = new GetOpenCourseDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOpenCourseDetailResponseBody setCourseId(String courseId) {
        this.courseId = courseId;
        return this;
    }
    public String getCourseId() {
        return this.courseId;
    }

    public GetOpenCourseDetailResponseBody setCourseType(Long courseType) {
        this.courseType = courseType;
        return this;
    }
    public Long getCourseType() {
        return this.courseType;
    }

    public GetOpenCourseDetailResponseBody setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
    }

    public GetOpenCourseDetailResponseBody setIntroduction(String introduction) {
        this.introduction = introduction;
        return this;
    }
    public String getIntroduction() {
        return this.introduction;
    }

    public GetOpenCourseDetailResponseBody setPushModel(GetOpenCourseDetailResponseBodyPushModel pushModel) {
        this.pushModel = pushModel;
        return this;
    }
    public GetOpenCourseDetailResponseBodyPushModel getPushModel() {
        return this.pushModel;
    }

    public GetOpenCourseDetailResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetOpenCourseDetailResponseBody setTeacherId(String teacherId) {
        this.teacherId = teacherId;
        return this;
    }
    public String getTeacherId() {
        return this.teacherId;
    }

    public GetOpenCourseDetailResponseBody setTeacherName(String teacherName) {
        this.teacherName = teacherName;
        return this;
    }
    public String getTeacherName() {
        return this.teacherName;
    }

    public GetOpenCourseDetailResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class GetOpenCourseDetailResponseBodyPushModel extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("pushOrgNameList")
        public java.util.List<String> pushOrgNameList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("pushRoleNameList")
        public java.util.List<String> pushRoleNameList;

        public static GetOpenCourseDetailResponseBodyPushModel build(java.util.Map<String, ?> map) throws Exception {
            GetOpenCourseDetailResponseBodyPushModel self = new GetOpenCourseDetailResponseBodyPushModel();
            return TeaModel.build(map, self);
        }

        public GetOpenCourseDetailResponseBodyPushModel setPushOrgNameList(java.util.List<String> pushOrgNameList) {
            this.pushOrgNameList = pushOrgNameList;
            return this;
        }
        public java.util.List<String> getPushOrgNameList() {
            return this.pushOrgNameList;
        }

        public GetOpenCourseDetailResponseBodyPushModel setPushRoleNameList(java.util.List<String> pushRoleNameList) {
            this.pushRoleNameList = pushRoleNameList;
            return this;
        }
        public java.util.List<String> getPushRoleNameList() {
            return this.pushRoleNameList;
        }

    }

}
