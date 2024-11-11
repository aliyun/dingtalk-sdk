// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCourseRequest extends TeaModel {
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
     * <p>classRoom_xxx</p>
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
     * <p>dingxxx</p>
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
     * <p>memo_xxx</p>
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

    @NameInMap("teacherList")
    public java.util.List<CreateCourseRequestTeacherList> teacherList;

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

    public static CreateCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCourseRequest self = new CreateCourseRequest();
        return TeaModel.build(map, self);
    }

    public CreateCourseRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public CreateCourseRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public CreateCourseRequest setClassName(String className) {
        this.className = className;
        return this;
    }
    public String getClassName() {
        return this.className;
    }

    public CreateCourseRequest setClassRoomId(String classRoomId) {
        this.classRoomId = classRoomId;
        return this;
    }
    public String getClassRoomId() {
        return this.classRoomId;
    }

    public CreateCourseRequest setClassRoomName(String classRoomName) {
        this.classRoomName = classRoomName;
        return this;
    }
    public String getClassRoomName() {
        return this.classRoomName;
    }

    public CreateCourseRequest setClassType(Integer classType) {
        this.classType = classType;
        return this;
    }
    public Integer getClassType() {
        return this.classType;
    }

    public CreateCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateCourseRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public CreateCourseRequest setCourseDate(Long courseDate) {
        this.courseDate = courseDate;
        return this;
    }
    public Long getCourseDate() {
        return this.courseDate;
    }

    public CreateCourseRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public CreateCourseRequest setCourseWeek(Integer courseWeek) {
        this.courseWeek = courseWeek;
        return this;
    }
    public Integer getCourseWeek() {
        return this.courseWeek;
    }

    public CreateCourseRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public CreateCourseRequest setIsvCourseId(String isvCourseId) {
        this.isvCourseId = isvCourseId;
        return this;
    }
    public String getIsvCourseId() {
        return this.isvCourseId;
    }

    public CreateCourseRequest setMemo(String memo) {
        this.memo = memo;
        return this;
    }
    public String getMemo() {
        return this.memo;
    }

    public CreateCourseRequest setSchoolYear(String schoolYear) {
        this.schoolYear = schoolYear;
        return this;
    }
    public String getSchoolYear() {
        return this.schoolYear;
    }

    public CreateCourseRequest setSemester(Integer semester) {
        this.semester = semester;
        return this;
    }
    public Integer getSemester() {
        return this.semester;
    }

    public CreateCourseRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateCourseRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public CreateCourseRequest setTeachWeek(Integer teachWeek) {
        this.teachWeek = teachWeek;
        return this;
    }
    public Integer getTeachWeek() {
        return this.teachWeek;
    }

    public CreateCourseRequest setTeacherList(java.util.List<CreateCourseRequestTeacherList> teacherList) {
        this.teacherList = teacherList;
        return this;
    }
    public java.util.List<CreateCourseRequestTeacherList> getTeacherList() {
        return this.teacherList;
    }

    public CreateCourseRequest setTimeslotName(String timeslotName) {
        this.timeslotName = timeslotName;
        return this;
    }
    public String getTimeslotName() {
        return this.timeslotName;
    }

    public CreateCourseRequest setTimeslotNum(Integer timeslotNum) {
        this.timeslotNum = timeslotNum;
        return this;
    }
    public Integer getTimeslotNum() {
        return this.timeslotNum;
    }

    public CreateCourseRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public static class CreateCourseRequestTeacherList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>李老师</p>
         */
        @NameInMap("teacherName")
        public String teacherName;

        /**
         * <strong>example:</strong>
         * <p>staff_xxx</p>
         */
        @NameInMap("teacherUserId")
        public String teacherUserId;

        public static CreateCourseRequestTeacherList build(java.util.Map<String, ?> map) throws Exception {
            CreateCourseRequestTeacherList self = new CreateCourseRequestTeacherList();
            return TeaModel.build(map, self);
        }

        public CreateCourseRequestTeacherList setTeacherName(String teacherName) {
            this.teacherName = teacherName;
            return this;
        }
        public String getTeacherName() {
            return this.teacherName;
        }

        public CreateCourseRequestTeacherList setTeacherUserId(String teacherUserId) {
            this.teacherUserId = teacherUserId;
            return this;
        }
        public String getTeacherUserId() {
            return this.teacherUserId;
        }

    }

}
