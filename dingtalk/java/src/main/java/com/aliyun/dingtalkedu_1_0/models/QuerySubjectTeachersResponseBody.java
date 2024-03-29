// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectTeachersResponseBody extends TeaModel {
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
        @NameInMap("classId")
        public Long classId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("periodCode")
        public String periodCode;

        @NameInMap("subjectCode")
        public String subjectCode;

        @NameInMap("subjectName")
        public String subjectName;

        @NameInMap("teacherName")
        public String teacherName;

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
