// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryClassCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<PageQueryClassCourseResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static PageQueryClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageQueryClassCourseResponseBody self = new PageQueryClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public PageQueryClassCourseResponseBody setResult(java.util.List<PageQueryClassCourseResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<PageQueryClassCourseResponseBodyResult> getResult() {
        return this.result;
    }

    public PageQueryClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PageQueryClassCourseResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;&quot;}</p>
         */
        @NameInMap("attributes")
        public String attributes;

        /**
         * <strong>example:</strong>
         * <p>classId_xxx</p>
         */
        @NameInMap("classId")
        public String classId;

        /**
         * <strong>example:</strong>
         * <p>一年级一班</p>
         */
        @NameInMap("className")
        public String className;

        /**
         * <strong>example:</strong>
         * <p>room_xxx</p>
         */
        @NameInMap("classRoomId")
        public String classRoomId;

        /**
         * <strong>example:</strong>
         * <p>音乐教室</p>
         */
        @NameInMap("classRoomName")
        public String classRoomName;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("classType")
        public Integer classType;

        /**
         * <strong>example:</strong>
         * <p>ding_xxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>code_xxx</p>
         */
        @NameInMap("courseCode")
        public String courseCode;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("courseDate")
        public Long courseDate;

        /**
         * <strong>example:</strong>
         * <p>语文</p>
         */
        @NameInMap("courseName")
        public String courseName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("courseWeek")
        public Integer courseWeek;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>ISV_XXX</p>
         */
        @NameInMap("isvCode")
        public String isvCode;

        /**
         * <strong>example:</strong>
         * <p>courseId</p>
         */
        @NameInMap("isvCourseId")
        public String isvCourseId;

        /**
         * <strong>example:</strong>
         * <p>备注</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <strong>example:</strong>
         * <p>2024</p>
         */
        @NameInMap("schoolYear")
        public String schoolYear;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("semester")
        public Integer semester;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("teachWeek")
        public Integer teachWeek;

        /**
         * <strong>example:</strong>
         * <p>第一节</p>
         */
        @NameInMap("timeslotName")
        public String timeslotName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("timeslotNum")
        public Integer timeslotNum;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("type")
        public Integer type;

        public static PageQueryClassCourseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PageQueryClassCourseResponseBodyResult self = new PageQueryClassCourseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PageQueryClassCourseResponseBodyResult setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public PageQueryClassCourseResponseBodyResult setClassId(String classId) {
            this.classId = classId;
            return this;
        }
        public String getClassId() {
            return this.classId;
        }

        public PageQueryClassCourseResponseBodyResult setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public PageQueryClassCourseResponseBodyResult setClassRoomId(String classRoomId) {
            this.classRoomId = classRoomId;
            return this;
        }
        public String getClassRoomId() {
            return this.classRoomId;
        }

        public PageQueryClassCourseResponseBodyResult setClassRoomName(String classRoomName) {
            this.classRoomName = classRoomName;
            return this;
        }
        public String getClassRoomName() {
            return this.classRoomName;
        }

        public PageQueryClassCourseResponseBodyResult setClassType(Integer classType) {
            this.classType = classType;
            return this;
        }
        public Integer getClassType() {
            return this.classType;
        }

        public PageQueryClassCourseResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public PageQueryClassCourseResponseBodyResult setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public PageQueryClassCourseResponseBodyResult setCourseDate(Long courseDate) {
            this.courseDate = courseDate;
            return this;
        }
        public Long getCourseDate() {
            return this.courseDate;
        }

        public PageQueryClassCourseResponseBodyResult setCourseName(String courseName) {
            this.courseName = courseName;
            return this;
        }
        public String getCourseName() {
            return this.courseName;
        }

        public PageQueryClassCourseResponseBodyResult setCourseWeek(Integer courseWeek) {
            this.courseWeek = courseWeek;
            return this;
        }
        public Integer getCourseWeek() {
            return this.courseWeek;
        }

        public PageQueryClassCourseResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public PageQueryClassCourseResponseBodyResult setIsvCode(String isvCode) {
            this.isvCode = isvCode;
            return this;
        }
        public String getIsvCode() {
            return this.isvCode;
        }

        public PageQueryClassCourseResponseBodyResult setIsvCourseId(String isvCourseId) {
            this.isvCourseId = isvCourseId;
            return this;
        }
        public String getIsvCourseId() {
            return this.isvCourseId;
        }

        public PageQueryClassCourseResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public PageQueryClassCourseResponseBodyResult setSchoolYear(String schoolYear) {
            this.schoolYear = schoolYear;
            return this;
        }
        public String getSchoolYear() {
            return this.schoolYear;
        }

        public PageQueryClassCourseResponseBodyResult setSemester(Integer semester) {
            this.semester = semester;
            return this;
        }
        public Integer getSemester() {
            return this.semester;
        }

        public PageQueryClassCourseResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public PageQueryClassCourseResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public PageQueryClassCourseResponseBodyResult setTeachWeek(Integer teachWeek) {
            this.teachWeek = teachWeek;
            return this;
        }
        public Integer getTeachWeek() {
            return this.teachWeek;
        }

        public PageQueryClassCourseResponseBodyResult setTimeslotName(String timeslotName) {
            this.timeslotName = timeslotName;
            return this;
        }
        public String getTimeslotName() {
            return this.timeslotName;
        }

        public PageQueryClassCourseResponseBodyResult setTimeslotNum(Integer timeslotNum) {
            this.timeslotNum = timeslotNum;
            return this;
        }
        public Integer getTimeslotNum() {
            return this.timeslotNum;
        }

        public PageQueryClassCourseResponseBodyResult setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
