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

        public static QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms self = new QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms setInteractInfo(String interactInfo) {
            this.interactInfo = interactInfo;
            return this;
        }
        public String getInteractInfo() {
            return this.interactInfo;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms setTargetId(String targetId) {
            this.targetId = targetId;
            return this;
        }
        public String getTargetId() {
            return this.targetId;
        }

    }

    public static class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels extends TeaModel {
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

        public static QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels self = new QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels setUid(Long uid) {
            this.uid = uid;
            return this;
        }
        public Long getUid() {
            return this.uid;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryClassScheduleByTimeSchoolResponseBodyResult extends TeaModel {
        /**
         * <p>业务唯一键</p>
         */
        @NameInMap("bizKey")
        public String bizKey;

        /**
         * <p>课程所在班级id</p>
         */
        @NameInMap("classId")
        public Long classId;

        /**
         * <p>课堂列表</p>
         */
        @NameInMap("classrooms")
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> classrooms;

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
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> eduUserModels;

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
         * <p>课程编码</p>
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

        public static QueryClassScheduleByTimeSchoolResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryClassScheduleByTimeSchoolResponseBodyResult self = new QueryClassScheduleByTimeSchoolResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setBizKey(String bizKey) {
            this.bizKey = bizKey;
            return this;
        }
        public String getBizKey() {
            return this.bizKey;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setClassrooms(java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> classrooms) {
            this.classrooms = classrooms;
            return this;
        }
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> getClassrooms() {
            return this.classrooms;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCourseGroupCode(String courseGroupCode) {
            this.courseGroupCode = courseGroupCode;
            return this;
        }
        public String getCourseGroupCode() {
            return this.courseGroupCode;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
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

        public QueryClassScheduleByTimeSchoolResponseBodyResult setEduUserModels(java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> eduUserModels) {
            this.eduUserModels = eduUserModels;
            return this;
        }
        public java.util.List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> getEduUserModels() {
            return this.eduUserModels;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setIntroduce(String introduce) {
            this.introduce = introduce;
            return this;
        }
        public String getIntroduce() {
            return this.introduce;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setSectionIndex(Long sectionIndex) {
            this.sectionIndex = sectionIndex;
            return this;
        }
        public Long getSectionIndex() {
            return this.sectionIndex;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setSectionName(String sectionName) {
            this.sectionName = sectionName;
            return this;
        }
        public String getSectionName() {
            return this.sectionName;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public QueryClassScheduleByTimeSchoolResponseBodyResult setSubjectCode(String subjectCode) {
            this.subjectCode = subjectCode;
            return this;
        }
        public String getSubjectCode() {
            return this.subjectCode;
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

    }

}
