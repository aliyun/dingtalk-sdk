// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetOpenCoursesResponseBody extends TeaModel {
    @NameInMap("courseList")
    public java.util.List<GetOpenCoursesResponseBodyCourseList> courseList;

    // 总记录数
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetOpenCoursesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOpenCoursesResponseBody self = new GetOpenCoursesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOpenCoursesResponseBody setCourseList(java.util.List<GetOpenCoursesResponseBodyCourseList> courseList) {
        this.courseList = courseList;
        return this;
    }
    public java.util.List<GetOpenCoursesResponseBodyCourseList> getCourseList() {
        return this.courseList;
    }

    public GetOpenCoursesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetOpenCoursesResponseBodyCourseList extends TeaModel {
        // 课程id
        @NameInMap("courseId")
        public String courseId;

        // 封面图片地址
        @NameInMap("coverUrl")
        public String coverUrl;

        // 课程类型: 0-直播 2-视频内容
        @NameInMap("feedType")
        public Long feedType;

        // 课程观看地址
        @NameInMap("jumpUrl")
        public String jumpUrl;

        // 课程开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 老师的userId
        @NameInMap("teacherId")
        public String teacherId;

        // 老师名称
        @NameInMap("teacherName")
        public String teacherName;

        // 课程标题
        @NameInMap("title")
        public String title;

        public static GetOpenCoursesResponseBodyCourseList build(java.util.Map<String, ?> map) throws Exception {
            GetOpenCoursesResponseBodyCourseList self = new GetOpenCoursesResponseBodyCourseList();
            return TeaModel.build(map, self);
        }

        public GetOpenCoursesResponseBodyCourseList setCourseId(String courseId) {
            this.courseId = courseId;
            return this;
        }
        public String getCourseId() {
            return this.courseId;
        }

        public GetOpenCoursesResponseBodyCourseList setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public GetOpenCoursesResponseBodyCourseList setFeedType(Long feedType) {
            this.feedType = feedType;
            return this;
        }
        public Long getFeedType() {
            return this.feedType;
        }

        public GetOpenCoursesResponseBodyCourseList setJumpUrl(String jumpUrl) {
            this.jumpUrl = jumpUrl;
            return this;
        }
        public String getJumpUrl() {
            return this.jumpUrl;
        }

        public GetOpenCoursesResponseBodyCourseList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetOpenCoursesResponseBodyCourseList setTeacherId(String teacherId) {
            this.teacherId = teacherId;
            return this;
        }
        public String getTeacherId() {
            return this.teacherId;
        }

        public GetOpenCoursesResponseBodyCourseList setTeacherName(String teacherName) {
            this.teacherName = teacherName;
            return this;
        }
        public String getTeacherName() {
            return this.teacherName;
        }

        public GetOpenCoursesResponseBodyCourseList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
