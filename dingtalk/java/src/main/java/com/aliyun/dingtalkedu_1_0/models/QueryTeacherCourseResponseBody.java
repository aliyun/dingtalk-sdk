// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTeacherCourseResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryTeacherCourseResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryTeacherCourseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTeacherCourseResponseBody self = new QueryTeacherCourseResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTeacherCourseResponseBody setResult(QueryTeacherCourseResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryTeacherCourseResponseBodyResult getResult() {
        return this.result;
    }

    public QueryTeacherCourseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList extends TeaModel {
        @NameInMap("attributes")
        public String attributes;

        @NameInMap("isvCourseId")
        public String isvCourseId;

        public static QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList build(java.util.Map<String, ?> map) throws Exception {
            QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList self = new QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList();
            return TeaModel.build(map, self);
        }

        public QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList setIsvCourseId(String isvCourseId) {
            this.isvCourseId = isvCourseId;
            return this;
        }
        public String getIsvCourseId() {
            return this.isvCourseId;
        }

    }

    public static class QueryTeacherCourseResponseBodyResult extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("isvCode")
        public String isvCode;

        @NameInMap("teacherCourseDetailItemList")
        public java.util.List<QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList> teacherCourseDetailItemList;

        @NameInMap("teacherName")
        public String teacherName;

        @NameInMap("teacherUserId")
        public String teacherUserId;

        public static QueryTeacherCourseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryTeacherCourseResponseBodyResult self = new QueryTeacherCourseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryTeacherCourseResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryTeacherCourseResponseBodyResult setIsvCode(String isvCode) {
            this.isvCode = isvCode;
            return this;
        }
        public String getIsvCode() {
            return this.isvCode;
        }

        public QueryTeacherCourseResponseBodyResult setTeacherCourseDetailItemList(java.util.List<QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList> teacherCourseDetailItemList) {
            this.teacherCourseDetailItemList = teacherCourseDetailItemList;
            return this;
        }
        public java.util.List<QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList> getTeacherCourseDetailItemList() {
            return this.teacherCourseDetailItemList;
        }

        public QueryTeacherCourseResponseBodyResult setTeacherName(String teacherName) {
            this.teacherName = teacherName;
            return this;
        }
        public String getTeacherName() {
            return this.teacherName;
        }

        public QueryTeacherCourseResponseBodyResult setTeacherUserId(String teacherUserId) {
            this.teacherUserId = teacherUserId;
            return this;
        }
        public String getTeacherUserId() {
            return this.teacherUserId;
        }

    }

}
