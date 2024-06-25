// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryAllSubjectsFromClassScheduleResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryAllSubjectsFromClassScheduleResponseBodyResult> result;

    public static QueryAllSubjectsFromClassScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllSubjectsFromClassScheduleResponseBody self = new QueryAllSubjectsFromClassScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllSubjectsFromClassScheduleResponseBody setResult(java.util.List<QueryAllSubjectsFromClassScheduleResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryAllSubjectsFromClassScheduleResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>url</p>
         */
        @NameInMap("avator")
        public String avator;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>李老师</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>5824343</p>
         */
        @NameInMap("uid")
        public Long uid;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2534523452</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList build(java.util.Map<String, ?> map) throws Exception {
            QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList self = new QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList();
            return TeaModel.build(map, self);
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList setAvator(String avator) {
            this.avator = avator;
            return this;
        }
        public String getAvator() {
            return this.avator;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList setUid(Long uid) {
            this.uid = uid;
            return this;
        }
        public Long getUid() {
            return this.uid;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryAllSubjectsFromClassScheduleResponseBodyResultExt extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>#000000</p>
         */
        @NameInMap("backgroundColor")
        public String backgroundColor;

        /**
         * <strong>example:</strong>
         * <p>2345</p>
         */
        @NameInMap("classId")
        public Long classId;

        /**
         * <strong>example:</strong>
         * <p>#000000</p>
         */
        @NameInMap("fontColor")
        public String fontColor;

        @NameInMap("teacherList")
        public java.util.List<QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList> teacherList;

        public static QueryAllSubjectsFromClassScheduleResponseBodyResultExt build(java.util.Map<String, ?> map) throws Exception {
            QueryAllSubjectsFromClassScheduleResponseBodyResultExt self = new QueryAllSubjectsFromClassScheduleResponseBodyResultExt();
            return TeaModel.build(map, self);
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExt setBackgroundColor(String backgroundColor) {
            this.backgroundColor = backgroundColor;
            return this;
        }
        public String getBackgroundColor() {
            return this.backgroundColor;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExt setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExt setFontColor(String fontColor) {
            this.fontColor = fontColor;
            return this;
        }
        public String getFontColor() {
            return this.fontColor;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResultExt setTeacherList(java.util.List<QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList> teacherList) {
            this.teacherList = teacherList;
            return this;
        }
        public java.util.List<QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList> getTeacherList() {
            return this.teacherList;
        }

    }

    public static class QueryAllSubjectsFromClassScheduleResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>创建者orgId</p>
         */
        @NameInMap("creatorOrgId")
        public Long creatorOrgId;

        @NameInMap("ext")
        public QueryAllSubjectsFromClassScheduleResponseBodyResultExt ext;

        /**
         * <strong>example:</strong>
         * <p>HIGH_SCHOOL</p>
         */
        @NameInMap("periodCode")
        public String periodCode;

        /**
         * <strong>example:</strong>
         * <p>cn_yuwen</p>
         */
        @NameInMap("subjectCode")
        public String subjectCode;

        /**
         * <strong>example:</strong>
         * <p>语文</p>
         */
        @NameInMap("subjectName")
        public String subjectName;

        public static QueryAllSubjectsFromClassScheduleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAllSubjectsFromClassScheduleResponseBodyResult self = new QueryAllSubjectsFromClassScheduleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResult setCreatorOrgId(Long creatorOrgId) {
            this.creatorOrgId = creatorOrgId;
            return this;
        }
        public Long getCreatorOrgId() {
            return this.creatorOrgId;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResult setExt(QueryAllSubjectsFromClassScheduleResponseBodyResultExt ext) {
            this.ext = ext;
            return this;
        }
        public QueryAllSubjectsFromClassScheduleResponseBodyResultExt getExt() {
            return this.ext;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResult setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResult setSubjectCode(String subjectCode) {
            this.subjectCode = subjectCode;
            return this;
        }
        public String getSubjectCode() {
            return this.subjectCode;
        }

        public QueryAllSubjectsFromClassScheduleResponseBodyResult setSubjectName(String subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public String getSubjectName() {
            return this.subjectName;
        }

    }

}
