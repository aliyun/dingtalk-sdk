// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetOpenCoursesResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("courseList")
    public java.util.List<GetOpenCoursesResponseBodyCourseList> courseList;

    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("courseId")
        public String courseId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("coverUrl")
        public String coverUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("feedType")
        public Long feedType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jumpUrl")
        public String jumpUrl;

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
