// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectTeachersResponseBody extends TeaModel {
    /**
     * <p>结果</p>
     */
    @NameInMap("result")
    public java.util.List<QuerySubjectTeachersResponseBodyResult> result;

    public static QuerySubjectTeachersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySubjectTeachersResponseBody self = new QuerySubjectTeachersResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySubjectTeachersResponseBody setResult(java.util.List<QuerySubjectTeachersResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QuerySubjectTeachersResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QuerySubjectTeachersResponseBodyResult extends TeaModel {
        /**
         * <p>班级id</p>
         */
        @NameInMap("classId")
        public Long classId;

        /**
         * <p>学校corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>学段code</p>
         */
        @NameInMap("periodCode")
        public String periodCode;

        /**
         * <p>学科code</p>
         */
        @NameInMap("subjectCode")
        public String subjectCode;

        /**
         * <p>学科名称</p>
         */
        @NameInMap("subjectName")
        public String subjectName;

        /**
         * <p>老师名称</p>
         */
        @NameInMap("teacherName")
        public String teacherName;

        /**
         * <p>老师Userid</p>
         */
        @NameInMap("teacherUserId")
        public String teacherUserId;

        public static QuerySubjectTeachersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectTeachersResponseBodyResult self = new QuerySubjectTeachersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySubjectTeachersResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QuerySubjectTeachersResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QuerySubjectTeachersResponseBodyResult setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

        public QuerySubjectTeachersResponseBodyResult setSubjectCode(String subjectCode) {
            this.subjectCode = subjectCode;
            return this;
        }
        public String getSubjectCode() {
            return this.subjectCode;
        }

        public QuerySubjectTeachersResponseBodyResult setSubjectName(String subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public String getSubjectName() {
            return this.subjectName;
        }

        public QuerySubjectTeachersResponseBodyResult setTeacherName(String teacherName) {
            this.teacherName = teacherName;
            return this;
        }
        public String getTeacherName() {
            return this.teacherName;
        }

        public QuerySubjectTeachersResponseBodyResult setTeacherUserId(String teacherUserId) {
            this.teacherUserId = teacherUserId;
            return this;
        }
        public String getTeacherUserId() {
            return this.teacherUserId;
        }

    }

}
