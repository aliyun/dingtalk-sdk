// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleByTimeSchoolResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResult> result;

    public static QueryClassScheduleByTimeSchoolResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleByTimeSchoolResponseBody self = new QueryClassScheduleByTimeSchoolResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleByTimeSchoolResponseBody setResult(java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms extends TeaModel {
        // 课堂唯一标识
        @NameInMap("targetId")
        public String targetId;

        // 交互信息
        @NameInMap("interactInfo")
        public String interactInfo;

        public static QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms self = new QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms setTargetId(String targetId) {
            this.targetId = targetId;
            return this;
        }
        public String getTargetId() {
            return this.targetId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms setInteractInfo(String interactInfo) {
            this.interactInfo = interactInfo;
            return this;
        }
        public String getInteractInfo() {
            return this.interactInfo;
        }

    }

    public static class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels extends TeaModel {
        // 用户userid
        @NameInMap("userId")
        public String userId;

        // 用户uid
        @NameInMap("uid")
        public Long uid;

        @NameInMap("name")
        public String name;

        public static QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels self = new QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels setUid(Long uid) {
            this.uid = uid;
            return this;
        }
        public Long getUid() {
            return this.uid;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QueryClassScheduleByTimeSchoolResponseBodyResult extends TeaModel {
        // 课程编码
        @NameInMap("code")
        public String code;

        // 课程名称
        @NameInMap("name")
        public String name;

        // 课程介绍
        @NameInMap("introduce")
        public String introduce;

        // 课程封面地址
        @NameInMap("coverUrl")
        public String coverUrl;

        // 开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 结束时间
        @NameInMap("endTime")
        public Long endTime;

        // 创建者组织id
        @NameInMap("creatorCorpId")
        public String creatorCorpId;

        // 创建者UserId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 创建者UserName
        @NameInMap("creatorUserName")
        public String creatorUserName;

        // 老师CorpId
        @NameInMap("teacherCorpId")
        public String teacherCorpId;

        // 老师UserId
        @NameInMap("teacherUserId")
        public String teacherUserId;

        // 老师UserName
        @NameInMap("teacherUserName")
        public String teacherUserName;

        // 业务唯一键
        @NameInMap("bizKey")
        public String bizKey;

        // 学科编码
        @NameInMap("subjectCode")
        public String subjectCode;

        // 课程组编码
        @NameInMap("courseGroupCode")
        public String courseGroupCode;

        // 课程状态
        @NameInMap("status")
        public Long status;

        // 课堂列表
        @NameInMap("classrooms")
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> classrooms;

        // 课程参与人列表
        @NameInMap("eduUserModels")
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> eduUserModels;

        // 课程编码
        @NameInMap("sectionName")
        public String sectionName;

        // 课程所在节次序列号
        @NameInMap("sectionIndex")
        public Long sectionIndex;

        // 课程所在班级id
        @NameInMap("classId")
        public Long classId;

        // 课程扩展信息
        @NameInMap("extInfo")
        public String extInfo;

        public static QueryClassScheduleByTimeSchoolResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleByTimeSchoolResponseBodyResult self = new QueryClassScheduleByTimeSchoolResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setIntroduce(String introduce) {
            this.introduce = introduce;
            return this;
        }
        public String getIntroduce() {
            return this.introduce;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCreatorCorpId(String creatorCorpId) {
            this.creatorCorpId = creatorCorpId;
            return this;
        }
        public String getCreatorCorpId() {
            return this.creatorCorpId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCreatorUserName(String creatorUserName) {
            this.creatorUserName = creatorUserName;
            return this;
        }
        public String getCreatorUserName() {
            return this.creatorUserName;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setTeacherCorpId(String teacherCorpId) {
            this.teacherCorpId = teacherCorpId;
            return this;
        }
        public String getTeacherCorpId() {
            return this.teacherCorpId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setTeacherUserId(String teacherUserId) {
            this.teacherUserId = teacherUserId;
            return this;
        }
        public String getTeacherUserId() {
            return this.teacherUserId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setTeacherUserName(String teacherUserName) {
            this.teacherUserName = teacherUserName;
            return this;
        }
        public String getTeacherUserName() {
            return this.teacherUserName;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setBizKey(String bizKey) {
            this.bizKey = bizKey;
            return this;
        }
        public String getBizKey() {
            return this.bizKey;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setSubjectCode(String subjectCode) {
            this.subjectCode = subjectCode;
            return this;
        }
        public String getSubjectCode() {
            return this.subjectCode;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCourseGroupCode(String courseGroupCode) {
            this.courseGroupCode = courseGroupCode;
            return this;
        }
        public String getCourseGroupCode() {
            return this.courseGroupCode;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setClassrooms(java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> classrooms) {
            this.classrooms = classrooms;
            return this;
        }
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> getClassrooms() {
            return this.classrooms;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setEduUserModels(java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> eduUserModels) {
            this.eduUserModels = eduUserModels;
            return this;
        }
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> getEduUserModels() {
            return this.eduUserModels;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setSectionIndex(Long sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Long getSectionIndex() {
            return this.sectionIndex;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

    }

}
