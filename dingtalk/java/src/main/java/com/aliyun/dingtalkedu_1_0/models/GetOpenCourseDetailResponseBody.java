// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetOpenCourseDetailResponseBody extends TeaModel {
    // 课程id
    @NameInMap("courseId")
    public String courseId;

    // 课程标题
    @NameInMap("title")
    public String title;

    // 课程类型: 0-直播 2-视频内容
    @NameInMap("courseType")
    public Long courseType;

    // 老师名称
    @NameInMap("teacherName")
    public String teacherName;

    // 封面图片地址
    @NameInMap("coverUrl")
    public String coverUrl;

    // 课程开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 老师的userId
    @NameInMap("teacherId")
    public String teacherId;

    // 课程介绍
    @NameInMap("introduction")
    public String introduction;

    // 发布详情model
    @NameInMap("pushModel")
    public GetOpenCourseDetailResponseBodyPushModel pushModel;

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

    public GetOpenCourseDetailResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetOpenCourseDetailResponseBody setCourseType(Long courseType) {
        this.courseType = courseType;
        return this;
    }
    public Long getCourseType() {
        return this.courseType;
    }

    public GetOpenCourseDetailResponseBody setTeacherName(String teacherName) {
        this.teacherName = teacherName;
        return this;
    }
    public String getTeacherName() {
        return this.teacherName;
    }

    public GetOpenCourseDetailResponseBody setCoverUrl(String coverUrl) {
        this.coverUrl = coverUrl;
        return this;
    }
    public String getCoverUrl() {
        return this.coverUrl;
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

    public static class GetOpenCourseDetailResponseBodyPushModel extends TeaModel {
        // 参与学校的名称列表
        @NameInMap("pushOrgNameList")
        public java.util.List<String> pushOrgNameList;

        // 参与角色的名称列表
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
