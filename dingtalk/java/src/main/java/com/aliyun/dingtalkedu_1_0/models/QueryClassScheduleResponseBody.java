// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleResponseBody extends TeaModel {
    // 课表时间节次配置。
    @NameInMap("config")
    public QueryClassScheduleResponseBodyConfig config;

    // 课程列表
    @NameInMap("courseDTOS")
    public java.util.List<QueryClassScheduleResponseBodyCourseDTOS> courseDTOS;

    public static QueryClassScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleResponseBody self = new QueryClassScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleResponseBody setConfig(QueryClassScheduleResponseBodyConfig config) {
        this.config = config;
        return this;
    }
    public QueryClassScheduleResponseBodyConfig getConfig() {
        return this.config;
    }

    public QueryClassScheduleResponseBody setCourseDTOS(java.util.List<QueryClassScheduleResponseBodyCourseDTOS> courseDTOS) {
        this.courseDTOS = courseDTOS;
        return this;
    }
    public java.util.List<QueryClassScheduleResponseBodyCourseDTOS> getCourseDTOS() {
        return this.courseDTOS;
    }

    public static class QueryClassScheduleResponseBodyConfigEnd extends TeaModel {
        // 一个月中第几天
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        // 月份。
        @NameInMap("month")
        public Long month;

        // 年份。
        @NameInMap("year")
        public Long year;

        public static QueryClassScheduleResponseBodyConfigEnd build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyConfigEnd self = new QueryClassScheduleResponseBodyConfigEnd();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyConfigEnd setDayOfMonth(Long dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Long getDayOfMonth() {
            return this.dayOfMonth;
        }

        public QueryClassScheduleResponseBodyConfigEnd setMonth(Long month) {
            this.month = month;
            return this;
        }
        public Long getMonth() {
            return this.month;
        }

        public QueryClassScheduleResponseBodyConfigEnd setYear(Long year) {
            this.year = year;
            return this;
        }
        public Long getYear() {
            return this.year;
        }

    }

    public static class QueryClassScheduleResponseBodyConfigSectionModelsEnd extends TeaModel {
        // 小时。
        @NameInMap("hour")
        public Long hour;

        // 分钟。
        @NameInMap("min")
        public Long min;

        public static QueryClassScheduleResponseBodyConfigSectionModelsEnd build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyConfigSectionModelsEnd self = new QueryClassScheduleResponseBodyConfigSectionModelsEnd();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyConfigSectionModelsEnd setHour(Long hour) {
            this.hour = hour;
            return this;
        }
        public Long getHour() {
            return this.hour;
        }

        public QueryClassScheduleResponseBodyConfigSectionModelsEnd setMin(Long min) {
            this.min = min;
            return this;
        }
        public Long getMin() {
            return this.min;
        }

    }

    public static class QueryClassScheduleResponseBodyConfigSectionModelsStart extends TeaModel {
        // 小时。
        @NameInMap("hour")
        public Long hour;

        // 分钟
        @NameInMap("min")
        public Long min;

        public static QueryClassScheduleResponseBodyConfigSectionModelsStart build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyConfigSectionModelsStart self = new QueryClassScheduleResponseBodyConfigSectionModelsStart();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyConfigSectionModelsStart setHour(Long hour) {
            this.hour = hour;
            return this;
        }
        public Long getHour() {
            return this.hour;
        }

        public QueryClassScheduleResponseBodyConfigSectionModelsStart setMin(Long min) {
            this.min = min;
            return this;
        }
        public Long getMin() {
            return this.min;
        }

    }

    public static class QueryClassScheduleResponseBodyConfigSectionModels extends TeaModel {
        // 结束时间（时分级别）
        @NameInMap("end")
        public QueryClassScheduleResponseBodyConfigSectionModelsEnd end;

        // 节次序列。
        @NameInMap("sectionIndex")
        public Long sectionIndex;

        // 节次名称。
        @NameInMap("sectionName")
        public String sectionName;

        // 节次类型：  COURSE：上课节次 REST：休息节次
        @NameInMap("sectionType")
        public String sectionType;

        // 开始时间（时分级别）。
        @NameInMap("start")
        public QueryClassScheduleResponseBodyConfigSectionModelsStart start;

        public static QueryClassScheduleResponseBodyConfigSectionModels build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyConfigSectionModels self = new QueryClassScheduleResponseBodyConfigSectionModels();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyConfigSectionModels setEnd(QueryClassScheduleResponseBodyConfigSectionModelsEnd end) {
            this.end = end;
            return this;
        }
        public QueryClassScheduleResponseBodyConfigSectionModelsEnd getEnd() {
            return this.end;
        }

        public QueryClassScheduleResponseBodyConfigSectionModels setSectionIndex(Long sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Long getSectionIndex() {
            return this.sectionIndex;
        }

        public QueryClassScheduleResponseBodyConfigSectionModels setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

        public QueryClassScheduleResponseBodyConfigSectionModels setSectionType(String sectionType) {
            this.sectionType = sectionType;
            return this;
        }
        public String getSectionType() {
            return this.sectionType;
        }

        public QueryClassScheduleResponseBodyConfigSectionModels setStart(QueryClassScheduleResponseBodyConfigSectionModelsStart start) {
            this.start = start;
            return this;
        }
        public QueryClassScheduleResponseBodyConfigSectionModelsStart getStart() {
            return this.start;
        }

    }

    public static class QueryClassScheduleResponseBodyConfigStart extends TeaModel {
        // 一个月中第几天
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        // 月份。
        @NameInMap("month")
        public Long month;

        // 年份。
        @NameInMap("year")
        public Long year;

        public static QueryClassScheduleResponseBodyConfigStart build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyConfigStart self = new QueryClassScheduleResponseBodyConfigStart();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyConfigStart setDayOfMonth(Long dayOfMonth) {
            this.dayOfMonth = dayOfMonth;
            return this;
        }
        public Long getDayOfMonth() {
            return this.dayOfMonth;
        }

        public QueryClassScheduleResponseBodyConfigStart setMonth(Long month) {
            this.month = month;
            return this;
        }
        public Long getMonth() {
            return this.month;
        }

        public QueryClassScheduleResponseBodyConfigStart setYear(Long year) {
            this.year = year;
            return this;
        }
        public Long getYear() {
            return this.year;
        }

    }

    public static class QueryClassScheduleResponseBodyConfig extends TeaModel {
        // 开始时间（到日）。
        @NameInMap("end")
        public QueryClassScheduleResponseBodyConfigEnd end;

        // 节次模型。
        @NameInMap("sectionModels")
        public java.util.List<QueryClassScheduleResponseBodyConfigSectionModels> sectionModels;

        // 开始时间（到日）。
        @NameInMap("start")
        public QueryClassScheduleResponseBodyConfigStart start;

        public static QueryClassScheduleResponseBodyConfig build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyConfig self = new QueryClassScheduleResponseBodyConfig();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyConfig setEnd(QueryClassScheduleResponseBodyConfigEnd end) {
            this.end = end;
            return this;
        }
        public QueryClassScheduleResponseBodyConfigEnd getEnd() {
            return this.end;
        }

        public QueryClassScheduleResponseBodyConfig setSectionModels(java.util.List<QueryClassScheduleResponseBodyConfigSectionModels> sectionModels) {
            this.sectionModels = sectionModels;
            return this;
        }
        public java.util.List<QueryClassScheduleResponseBodyConfigSectionModels> getSectionModels() {
            return this.sectionModels;
        }

        public QueryClassScheduleResponseBodyConfig setStart(QueryClassScheduleResponseBodyConfigStart start) {
            this.start = start;
            return this;
        }
        public QueryClassScheduleResponseBodyConfigStart getStart() {
            return this.start;
        }

    }

    public static class QueryClassScheduleResponseBodyCourseDTOSClassrooms extends TeaModel {
        // 交互信息
        @NameInMap("interactInfo")
        public String interactInfo;

        // 课堂唯一标识
        @NameInMap("targetId")
        public String targetId;

        public static QueryClassScheduleResponseBodyCourseDTOSClassrooms build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyCourseDTOSClassrooms self = new QueryClassScheduleResponseBodyCourseDTOSClassrooms();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyCourseDTOSClassrooms setInteractInfo(String interactInfo) {
            this.interactInfo = interactInfo;
            return this;
        }
        public String getInteractInfo() {
            return this.interactInfo;
        }

        public QueryClassScheduleResponseBodyCourseDTOSClassrooms setTargetId(String targetId) {
            this.targetId = targetId;
            return this;
        }
        public String getTargetId() {
            return this.targetId;
        }

    }

    public static class QueryClassScheduleResponseBodyCourseDTOSEduUserModels extends TeaModel {
        @NameInMap("name")
        public String name;

        // 用户uid
        @NameInMap("uid")
        public Long uid;

        // 用户userid
        @NameInMap("userId")
        public String userId;

        public static QueryClassScheduleResponseBodyCourseDTOSEduUserModels build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyCourseDTOSEduUserModels self = new QueryClassScheduleResponseBodyCourseDTOSEduUserModels();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyCourseDTOSEduUserModels setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryClassScheduleResponseBodyCourseDTOSEduUserModels setUid(Long uid) {
            this.uid = uid;
            return this;
        }
        public Long getUid() {
            return this.uid;
        }

        public QueryClassScheduleResponseBodyCourseDTOSEduUserModels setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryClassScheduleResponseBodyCourseDTOS extends TeaModel {
        // 课程所在班级id
        @NameInMap("classId")
        public Long classId;

        // 课堂列表
        @NameInMap("classrooms")
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSClassrooms> classrooms;

        // 课程编码
        @NameInMap("code")
        public String code;

        // 课程组编码
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        // 课程封面地址
        @NameInMap("coverUrl")
        public String coverUrl;

        // 创建者组织id
        @NameInMap("creatorCorpId")
        public String creatorCorpId;

        // 创建者UserId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 创建者UserName
        @NameInMap("creatorUserName")
        public String creatorUserName;

        // 课程参与人列表
        @NameInMap("eduUserModels")
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSEduUserModels> eduUserModels;

        // 结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 课程扩展信息
        @NameInMap("extInfo")
        public String extInfo;

        // 课程介绍
        @NameInMap("introduce")
        public String introduce;

        // 课程名称
        @NameInMap("name")
        public String name;

        // 课程所在节次序列号
        @NameInMap("sectionIndex")
        public Long sectionIndex;

        // 课程名称
        @NameInMap("sectionName")
        public String sectionName;

        // 开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 课程状态
        @NameInMap("status")
        public Long status;

        // 学科编码
        @NameInMap("subjectCode")
        public String subjectCode;

        // 老师CorpId
        @NameInMap("teacherCorpId")
        public String teacherCorpId;

        // 老师UserId
        @NameInMap("teacherUserId")
        public String teacherUserId;

        // 老师UserName
        @NameInMap("teacherUserName")
        public String teacherUserName;

        public static QueryClassScheduleResponseBodyCourseDTOS build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleResponseBodyCourseDTOS self = new QueryClassScheduleResponseBodyCourseDTOS();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleResponseBodyCourseDTOS setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setClassrooms(java.util.List<QueryClassScheduleResponseBodyCourseDTOSClassrooms> classrooms) {
            this.classrooms = classrooms;
            return this;
        }
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSClassrooms> getClassrooms() {
            return this.classrooms;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setCourseGroupCode(String courseGroupCode) {
            this.courseGroupCode = courseGroupCode;
            return this;
        }
        public String getCourseGroupCode() {
            return this.courseGroupCode;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setCreatorCorpId(String creatorCorpId) {
            this.creatorCorpId = creatorCorpId;
            return this;
        }
        public String getCreatorCorpId() {
            return this.creatorCorpId;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setCreatorUserName(String creatorUserName) {
            this.creatorUserName = creatorUserName;
            return this;
        }
        public String getCreatorUserName() {
            return this.creatorUserName;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setEduUserModels(java.util.List<QueryClassScheduleResponseBodyCourseDTOSEduUserModels> eduUserModels) {
            this.eduUserModels = eduUserModels;
            return this;
        }
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSEduUserModels> getEduUserModels() {
            return this.eduUserModels;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setIntroduce(String introduce) {
            this.introduce = introduce;
            return this;
        }
        public String getIntroduce() {
            return this.introduce;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setSectionIndex(Long sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Long getSectionIndex() {
            return this.sectionIndex;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setSubjectCode(String subjectCode) {
            this.subjectCode = subjectCode;
            return this;
        }
        public String getSubjectCode() {
            return this.subjectCode;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setTeacherCorpId(String teacherCorpId) {
            this.teacherCorpId = teacherCorpId;
            return this;
        }
        public String getTeacherCorpId() {
            return this.teacherCorpId;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setTeacherUserId(String teacherUserId) {
            this.teacherUserId = teacherUserId;
            return this;
        }
        public String getTeacherUserId() {
            return this.teacherUserId;
        }

        public QueryClassScheduleResponseBodyCourseDTOS setTeacherUserName(String teacherUserName) {
            this.teacherUserName = teacherUserName;
            return this;
        }
        public String getTeacherUserName() {
            return this.teacherUserName;
        }

    }

}
