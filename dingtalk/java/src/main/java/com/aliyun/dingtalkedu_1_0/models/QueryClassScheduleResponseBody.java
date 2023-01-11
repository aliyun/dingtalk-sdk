// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleResponseBody extends TeaModel {
    /**
     * <p>课表时间节次配置。</p>
     */
    @NameInMap("config")
    public QueryClassScheduleResponseBodyConfig config;

    /**
     * <p>课程列表</p>
     */
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
        /**
         * <p>一个月中第几天</p>
         */
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        /**
         * <p>月份。</p>
         */
        @NameInMap("month")
        public Long month;

        /**
         * <p>年份。</p>
         */
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
        /**
         * <p>小时。</p>
         */
        @NameInMap("hour")
        public Long hour;

        /**
         * <p>分钟。</p>
         */
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
        /**
         * <p>小时。</p>
         */
        @NameInMap("hour")
        public Long hour;

        /**
         * <p>分钟</p>
         */
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
        /**
         * <p>结束时间（时分级别）</p>
         */
        @NameInMap("end")
        public QueryClassScheduleResponseBodyConfigSectionModelsEnd end;

        /**
         * <p>节次序列。</p>
         */
        @NameInMap("sectionIndex")
        public Long sectionIndex;

        /**
         * <p>节次名称。</p>
         */
        @NameInMap("sectionName")
        public String sectionName;

        /**
         * <p>节次类型：  COURSE：上课节次 REST：休息节次</p>
         */
        @NameInMap("sectionType")
        public String sectionType;

        /**
         * <p>开始时间（时分级别）。</p>
         */
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
        /**
         * <p>一个月中第几天</p>
         */
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        /**
         * <p>月份。</p>
         */
        @NameInMap("month")
        public Long month;

        /**
         * <p>年份。</p>
         */
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
        /**
         * <p>开始时间（到日）。</p>
         */
        @NameInMap("end")
        public QueryClassScheduleResponseBodyConfigEnd end;

        /**
         * <p>节次模型。</p>
         */
        @NameInMap("sectionModels")
        public java.util.List<QueryClassScheduleResponseBodyConfigSectionModels> sectionModels;

        /**
         * <p>开始时间（到日）。</p>
         */
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
        /**
         * <p>交互信息</p>
         */
        @NameInMap("interactInfo")
        public String interactInfo;

        /**
         * <p>课堂唯一标识</p>
         */
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

        /**
         * <p>用户uid</p>
         */
        @NameInMap("uid")
        public Long uid;

        /**
         * <p>用户userid</p>
         */
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
        /**
         * <p>课程所在班级id</p>
         */
        @NameInMap("classId")
        public Long classId;

        /**
         * <p>课堂列表</p>
         */
        @NameInMap("classrooms")
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSClassrooms> classrooms;

        /**
         * <p>课程编码</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>课程组编码</p>
         */
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        /**
         * <p>课程封面地址</p>
         */
        @NameInMap("coverUrl")
        public String coverUrl;

        /**
         * <p>创建者组织id</p>
         */
        @NameInMap("creatorCorpId")
        public String creatorCorpId;

        /**
         * <p>创建者UserId</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>创建者UserName</p>
         */
        @NameInMap("creatorUserName")
        public String creatorUserName;

        /**
         * <p>课程参与人列表</p>
         */
        @NameInMap("eduUserModels")
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSEduUserModels> eduUserModels;

        /**
         * <p>结束时间</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>课程扩展信息</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>课程介绍</p>
         */
        @NameInMap("introduce")
        public String introduce;

        /**
         * <p>课程名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>课程所在节次序列号</p>
         */
        @NameInMap("sectionIndex")
        public Long sectionIndex;

        /**
         * <p>课程名称</p>
         */
        @NameInMap("sectionName")
        public String sectionName;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>课程状态</p>
         */
        @NameInMap("status")
        public Long status;

        /**
         * <p>学科编码</p>
         */
        @NameInMap("subjectCode")
        public String subjectCode;

        /**
         * <p>老师CorpId</p>
         */
        @NameInMap("teacherCorpId")
        public String teacherCorpId;

        /**
         * <p>老师UserId</p>
         */
        @NameInMap("teacherUserId")
        public String teacherUserId;

        /**
         * <p>老师UserName</p>
         */
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
