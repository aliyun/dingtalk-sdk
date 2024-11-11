// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryClassCourseResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryClassCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryClassCourseResponseBody self = new QueryClassCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryClassCourseResponseBody setResult(QueryClassCourseResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryClassCourseResponseBodyResult getResult() {
        return this.result;
    }

    public QueryClassCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryClassCourseResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;&quot;}</p>
         */
        @NameInMap("attributes")
        public String attributes;

        /**
         * <strong>example:</strong>
         * <p>class_xxx</p>
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
         * <p>classroom_xxx</p>
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
         * <p>1</p>
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
         * <p>course_xxx</p>
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
         * <p>0</p>
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
         * <p>isv_xxx</p>
         */
        @NameInMap("isvCode")
        public String isvCode;

        /**
         * <strong>example:</strong>
         * <p>course_xxx</p>
         */
        @NameInMap("isvCourseId")
        public String isvCourseId;

        /**
         * <strong>example:</strong>
         * <p>memo</p>
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

        public static QueryClassCourseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryClassCourseResponseBodyResult self = new QueryClassCourseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryClassCourseResponseBodyResult setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public QueryClassCourseResponseBodyResult setClassId(String classId) {
            this.classId = classId;
            return this;
        }
        public String getClassId() {
            return this.classId;
        }

        public QueryClassCourseResponseBodyResult setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public QueryClassCourseResponseBodyResult setClassRoomId(String classRoomId) {
            this.classRoomId = classRoomId;
            return this;
        }
        public String getClassRoomId() {
            return this.classRoomId;
        }

        public QueryClassCourseResponseBodyResult setClassRoomName(String classRoomName) {
            this.classRoomName = classRoomName;
            return this;
        }
        public String getClassRoomName() {
            return this.classRoomName;
        }

        public QueryClassCourseResponseBodyResult setClassType(Integer classType) {
            this.classType = classType;
            return this;
        }
        public Integer getClassType() {
            return this.classType;
        }

        public QueryClassCourseResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryClassCourseResponseBodyResult setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public QueryClassCourseResponseBodyResult setCourseDate(Long courseDate) {
            this.courseDate = courseDate;
            return this;
        }
        public Long getCourseDate() {
            return this.courseDate;
        }

        public QueryClassCourseResponseBodyResult setCourseName(String courseName) {
            this.courseName = courseName;
            return this;
        }
        public String getCourseName() {
            return this.courseName;
        }

        public QueryClassCourseResponseBodyResult setCourseWeek(Integer courseWeek) {
            this.courseWeek = courseWeek;
            return this;
        }
        public Integer getCourseWeek() {
            return this.courseWeek;
        }

        public QueryClassCourseResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryClassCourseResponseBodyResult setIsvCode(String isvCode) {
            this.isvCode = isvCode;
            return this;
        }
        public String getIsvCode() {
            return this.isvCode;
        }

        public QueryClassCourseResponseBodyResult setIsvCourseId(String isvCourseId) {
            this.isvCourseId = isvCourseId;
            return this;
        }
        public String getIsvCourseId() {
            return this.isvCourseId;
        }

        public QueryClassCourseResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public QueryClassCourseResponseBodyResult setSchoolYear(String schoolYear) {
            this.schoolYear = schoolYear;
            return this;
        }
        public String getSchoolYear() {
            return this.schoolYear;
        }

        public QueryClassCourseResponseBodyResult setSemester(Integer semester) {
            this.semester = semester;
            return this;
        }
        public Integer getSemester() {
            return this.semester;
        }

        public QueryClassCourseResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryClassCourseResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryClassCourseResponseBodyResult setTeachWeek(Integer teachWeek) {
            this.teachWeek = teachWeek;
            return this;
        }
        public Integer getTeachWeek() {
            return this.teachWeek;
        }

        public QueryClassCourseResponseBodyResult setTimeslotName(String timeslotName) {
            this.timeslotName = timeslotName;
            return this;
        }
        public String getTimeslotName() {
            return this.timeslotName;
        }

        public QueryClassCourseResponseBodyResult setTimeslotNum(Integer timeslotNum) {
            this.timeslotNum = timeslotNum;
            return this;
        }
        public Integer getTimeslotNum() {
            return this.timeslotNum;
        }

        public QueryClassCourseResponseBodyResult setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
