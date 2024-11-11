// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AdjustCourseRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;&quot;}</p>
     */
    @NameInMap("attributes")
    public String attributes;

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
     * <p>1</p>
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

    public static AdjustCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        AdjustCourseRequest self = new AdjustCourseRequest();
        return TeaModel.build(map, self);
    }

    public AdjustCourseRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public AdjustCourseRequest setClassName(String className) {
        this.className = className;
        return this;
    }
    public String getClassName() {
        return this.className;
    }

    public AdjustCourseRequest setClassRoomId(String classRoomId) {
        this.classRoomId = classRoomId;
        return this;
    }
    public String getClassRoomId() {
        return this.classRoomId;
    }

    public AdjustCourseRequest setClassRoomName(String classRoomName) {
        this.classRoomName = classRoomName;
        return this;
    }
    public String getClassRoomName() {
        return this.classRoomName;
    }

    public AdjustCourseRequest setClassType(Integer classType) {
        this.classType = classType;
        return this;
    }
    public Integer getClassType() {
        return this.classType;
    }

    public AdjustCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AdjustCourseRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public AdjustCourseRequest setCourseDate(Long courseDate) {
        this.courseDate = courseDate;
        return this;
    }
    public Long getCourseDate() {
        return this.courseDate;
    }

    public AdjustCourseRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public AdjustCourseRequest setCourseWeek(Integer courseWeek) {
        this.courseWeek = courseWeek;
        return this;
    }
    public Integer getCourseWeek() {
        return this.courseWeek;
    }

    public AdjustCourseRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public AdjustCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public AdjustCourseRequest setIsvCourseId(String isvCourseId) {
        this.isvCourseId = isvCourseId;
        return this;
    }
    public String getIsvCourseId() {
        return this.isvCourseId;
    }

    public AdjustCourseRequest setMemo(String memo) {
        this.memo = memo;
        return this;
    }
    public String getMemo() {
        return this.memo;
    }

    public AdjustCourseRequest setSchoolYear(String schoolYear) {
        this.schoolYear = schoolYear;
        return this;
    }
    public String getSchoolYear() {
        return this.schoolYear;
    }

    public AdjustCourseRequest setSemester(Integer semester) {
        this.semester = semester;
        return this;
    }
    public Integer getSemester() {
        return this.semester;
    }

    public AdjustCourseRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public AdjustCourseRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public AdjustCourseRequest setTeachWeek(Integer teachWeek) {
        this.teachWeek = teachWeek;
        return this;
    }
    public Integer getTeachWeek() {
        return this.teachWeek;
    }

    public AdjustCourseRequest setTimeslotName(String timeslotName) {
        this.timeslotName = timeslotName;
        return this;
    }
    public String getTimeslotName() {
        return this.timeslotName;
    }

    public AdjustCourseRequest setTimeslotNum(Integer timeslotNum) {
        this.timeslotNum = timeslotNum;
        return this;
    }
    public Integer getTimeslotNum() {
        return this.timeslotNum;
    }

    public AdjustCourseRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

}
