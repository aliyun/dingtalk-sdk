// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySelfBuildGroupBaseInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySelfBuildGroupBaseInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QuerySelfBuildGroupBaseInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySelfBuildGroupBaseInfoResponseBody self = new QuerySelfBuildGroupBaseInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySelfBuildGroupBaseInfoResponseBody setResult(QuerySelfBuildGroupBaseInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySelfBuildGroupBaseInfoResponseBodyResult getResult() {
        return this.result;
    }

    public QuerySelfBuildGroupBaseInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QuerySelfBuildGroupBaseInfoResponseBodyResult extends TeaModel {
        @NameInMap("classId")
        public Long classId;

        @NameInMap("className")
        public String className;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("gradeLevel")
        public Integer gradeLevel;

        @NameInMap("groupType")
        public String groupType;

        @NameInMap("periodCode")
        public String periodCode;

        @NameInMap("requestId")
        public String requestId;

        public static QuerySelfBuildGroupBaseInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySelfBuildGroupBaseInfoResponseBodyResult self = new QuerySelfBuildGroupBaseInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySelfBuildGroupBaseInfoResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QuerySelfBuildGroupBaseInfoResponseBodyResult setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public QuerySelfBuildGroupBaseInfoResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QuerySelfBuildGroupBaseInfoResponseBodyResult setGradeLevel(Integer gradeLevel) {
            this.gradeLevel = gradeLevel;
            return this;
        }
        public Integer getGradeLevel() {
            return this.gradeLevel;
        }

        public QuerySelfBuildGroupBaseInfoResponseBodyResult setGroupType(String groupType) {
            this.groupType = groupType;
            return this;
        }
        public String getGroupType() {
            return this.groupType;
        }

        public QuerySelfBuildGroupBaseInfoResponseBodyResult setPeriodCode(String periodCode) {
            this.periodCode = periodCode;
            return this;
        }
        public String getPeriodCode() {
            return this.periodCode;
        }

        public QuerySelfBuildGroupBaseInfoResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
