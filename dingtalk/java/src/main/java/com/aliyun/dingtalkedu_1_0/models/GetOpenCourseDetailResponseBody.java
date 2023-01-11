// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetOpenCourseDetailResponseBody extends TeaModel {
    /**
     * <p>课程id</p>
     */
    @NameInMap("courseId")
    public String courseId;

    /**
     * <p>课程类型: 0-直播 2-视频内容</p>
     */
    @NameInMap("courseType")
    public Long courseType;

    /**
     * <p>封面图片地址</p>
     */
    @NameInMap("coverUrl")
    public String coverUrl;

    /**
     * <p>课程介绍</p>
     */
    @NameInMap("introduction")
    public String introduction;

    /**
     * <p>发布详情model</p>
     */
    @NameInMap("pushModel")
    public GetOpenCourseDetailResponseBodyPushModel pushModel;

    /**
     * <p>课程开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>老师的userId</p>
     */
    @NameInMap("teacherId")
    public String teacherId;

    /**
     * <p>老师名称</p>
     */
    @NameInMap("teacherName")
    public String teacherName;

    /**
     * <p>课程标题</p>
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
         * <p>参与学校的名称列表</p>
         */
        @NameInMap("pushOrgNameList")
        public java.util.List<String> pushOrgNameList;

        /**
         * <p>参与角色的名称列表</p>
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
