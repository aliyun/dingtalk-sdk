// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryAllSubjectsFromClassScheduleResponseBody extends TeaModel {
    /**
     * <p>查询结果。</p>
     */
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
         * <p>老师的头像url</p>
         */
        @NameInMap("avator")
        public String avator;

        /**
         * <p>老师名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>老师的uid。</p>
         */
        @NameInMap("uid")
        public Long uid;

        /**
         * <p>老师的userid。</p>
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
         * <p>学科背景颜色</p>
         */
        @NameInMap("backgroundColor")
        public String backgroundColor;

        /**
         * <p>班级id。</p>
         */
        @NameInMap("classId")
        public Long classId;

        /**
         * <p>学科字体颜色</p>
         */
        @NameInMap("fontColor")
        public String fontColor;

        /**
         * <p>老师列表</p>
         */
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
         * <p>creatorOrgId</p>
         */
        @NameInMap("creatorOrgId")
        public Long creatorOrgId;

        /**
         * <p>拓展信息</p>
         */
        @NameInMap("ext")
        public QueryAllSubjectsFromClassScheduleResponseBodyResultExt ext;

        /**
         * <p>学段编码：  KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段</p>
         */
        @NameInMap("periodCode")
        public String periodCode;

        /**
         * <p>学科code。</p>
         */
        @NameInMap("subjectCode")
        public String subjectCode;

        /**
         * <p>学科名称。</p>
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
