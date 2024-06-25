// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleResponseBody extends TeaModel {
    @NameInMap("config")
    public QueryClassScheduleResponseBodyConfig config;

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
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("month")
        public Long month;

        /**
         * <strong>example:</strong>
         * <p>2020</p>
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
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("hour")
        public Long hour;

        /**
         * <strong>example:</strong>
         * <p>45</p>
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
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("hour")
        public Long hour;

        /**
         * <strong>example:</strong>
         * <p>0</p>
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
        @NameInMap("end")
        public QueryClassScheduleResponseBodyConfigSectionModelsEnd end;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("sectionIndex")
        public Long sectionIndex;

        /**
         * <strong>example:</strong>
         * <p>第一节</p>
         */
        @NameInMap("sectionName")
        public String sectionName;

        /**
         * <strong>example:</strong>
         * <p>COURSE</p>
         */
        @NameInMap("sectionType")
        public String sectionType;

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
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("dayOfMonth")
        public Long dayOfMonth;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("month")
        public Long month;

        /**
         * <strong>example:</strong>
         * <p>2020</p>
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
        @NameInMap("end")
        public QueryClassScheduleResponseBodyConfigEnd end;

        @NameInMap("sectionModels")
        public java.util.List<QueryClassScheduleResponseBodyConfigSectionModels> sectionModels;

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
        @NameInMap("interactInfo")
        public String interactInfo;

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

        @NameInMap("uid")
        public Long uid;

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
         * <strong>example:</strong>
         * <p>2345</p>
         */
        @NameInMap("classId")
        public Long classId;

        @NameInMap("classrooms")
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSClassrooms> classrooms;

        /**
         * <strong>example:</strong>
         * <p>cn_yuwen</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>Ekk24352534</p>
         */
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        /**
         * <strong>example:</strong>
         * <p>ruu</p>
         */
        @NameInMap("coverUrl")
        public String coverUrl;

        /**
         * <strong>example:</strong>
         * <p>ding32534536235</p>
         */
        @NameInMap("creatorCorpId")
        public String creatorCorpId;

        /**
         * <strong>example:</strong>
         * <p>234525235</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>行政老师A</p>
         */
        @NameInMap("creatorUserName")
        public String creatorUserName;

        @NameInMap("eduUserModels")
        public java.util.List<QueryClassScheduleResponseBodyCourseDTOSEduUserModels> eduUserModels;

        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>ext</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <strong>example:</strong>
         * <p>这是语文</p>
         */
        @NameInMap("introduce")
        public String introduce;

        /**
         * <strong>example:</strong>
         * <p>语文</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("sectionIndex")
        public Long sectionIndex;

        /**
         * <strong>example:</strong>
         * <p>语文</p>
         */
        @NameInMap("sectionName")
        public String sectionName;

        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("status")
        public Long status;

        /**
         * <strong>example:</strong>
         * <p>cn_yuwen</p>
         */
        @NameInMap("subjectCode")
        public String subjectCode;

        /**
         * <strong>example:</strong>
         * <p>ding32534536235</p>
         */
        @NameInMap("teacherCorpId")
        public String teacherCorpId;

        /**
         * <strong>example:</strong>
         * <p>25354252543</p>
         */
        @NameInMap("teacherUserId")
        public String teacherUserId;

        /**
         * <strong>example:</strong>
         * <p>李老师</p>
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
