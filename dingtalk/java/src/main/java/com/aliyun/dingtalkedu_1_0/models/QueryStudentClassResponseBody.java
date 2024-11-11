// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryStudentClassResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryStudentClassResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryStudentClassResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryStudentClassResponseBody self = new QueryStudentClassResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryStudentClassResponseBody setResult(QueryStudentClassResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryStudentClassResponseBodyResult getResult() {
        return this.result;
    }

    public QueryStudentClassResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryStudentClassResponseBodyResultStudentList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;&quot;}</p>
         */
        @NameInMap("attributes")
        public String attributes;

        /**
         * <strong>example:</strong>
         * <p>小明</p>
         */
        @NameInMap("studentName")
        public String studentName;

        /**
         * <strong>example:</strong>
         * <p>studentxxx</p>
         */
        @NameInMap("studentUserId")
        public String studentUserId;

        public static QueryStudentClassResponseBodyResultStudentList build(java.util.Map<String, ?> map) throws Exception {
            QueryStudentClassResponseBodyResultStudentList self = new QueryStudentClassResponseBodyResultStudentList();
            return TeaModel.build(map, self);
        }

        public QueryStudentClassResponseBodyResultStudentList setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public QueryStudentClassResponseBodyResultStudentList setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public QueryStudentClassResponseBodyResultStudentList setStudentUserId(String studentUserId) {
            this.studentUserId = studentUserId;
            return this;
        }
        public String getStudentUserId() {
            return this.studentUserId;
        }

    }

    public static class QueryStudentClassResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>classIdxxx</p>
         */
        @NameInMap("classId")
        public String classId;

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
         * <p>ISV_XXX</p>
         */
        @NameInMap("isvCode")
        public String isvCode;

        @NameInMap("studentList")
        public java.util.List<QueryStudentClassResponseBodyResultStudentList> studentList;

        public static QueryStudentClassResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryStudentClassResponseBodyResult self = new QueryStudentClassResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryStudentClassResponseBodyResult setClassId(String classId) {
            this.classId = classId;
            return this;
        }
        public String getClassId() {
            return this.classId;
        }

        public QueryStudentClassResponseBodyResult setClassType(Integer classType) {
            this.classType = classType;
            return this;
        }
        public Integer getClassType() {
            return this.classType;
        }

        public QueryStudentClassResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryStudentClassResponseBodyResult setIsvCode(String isvCode) {
            this.isvCode = isvCode;
            return this;
        }
        public String getIsvCode() {
            return this.isvCode;
        }

        public QueryStudentClassResponseBodyResult setStudentList(java.util.List<QueryStudentClassResponseBodyResultStudentList> studentList) {
            this.studentList = studentList;
            return this;
        }
        public java.util.List<QueryStudentClassResponseBodyResultStudentList> getStudentList() {
            return this.studentList;
        }

    }

}
