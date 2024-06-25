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
     * 
     * <strong>example:</strong>
     * <p>68</p>
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
         * 
         * <strong>example:</strong>
         * <p>fdjakl-fdaf-ds</p>
         */
        @NameInMap("courseId")
        public String courseId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://static.dingtalk.com/media/lALPDgCwRt4FagzMi8yZ_153_139.png">https://static.dingtalk.com/media/lALPDgCwRt4FagzMi8yZ_153_139.png</a></p>
         */
        @NameInMap("coverUrl")
        public String coverUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("feedType")
        public Long feedType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://h5.dingtalk.com/live/video_lesson.htm?feedId=4aa5ter-05d8-4aac-834a-3b3847cf642e&mcnId=7536041420201104593&feedProperty=1&itemId=4aa563e1-05d8-4aac-841a-3b3847cf642e&dd_nav_bgcolor=FF2C2D2F#/live">https://h5.dingtalk.com/live/video_lesson.htm?feedId=4aa5ter-05d8-4aac-834a-3b3847cf642e&amp;mcnId=7536041420201104593&amp;feedProperty=1&amp;itemId=4aa563e1-05d8-4aac-841a-3b3847cf642e&amp;dd_nav_bgcolor=FF2C2D2F#/live</a></p>
         */
        @NameInMap("jumpUrl")
        public String jumpUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1618369786000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123124312314</p>
         */
        @NameInMap("teacherId")
        public String teacherId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张老师</p>
         */
        @NameInMap("teacherName")
        public String teacherName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>开学第一课</p>
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
