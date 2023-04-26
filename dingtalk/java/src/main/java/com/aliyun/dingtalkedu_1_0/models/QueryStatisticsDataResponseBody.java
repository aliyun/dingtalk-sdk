// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryStatisticsDataResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryStatisticsDataResponseBodyResult> result;

    public static QueryStatisticsDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryStatisticsDataResponseBody self = new QueryStatisticsDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryStatisticsDataResponseBody setResult(java.util.List<QueryStatisticsDataResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryStatisticsDataResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryStatisticsDataResponseBodyResult extends TeaModel {
        @NameInMap("classId")
        public Long classId;

        @NameInMap("courseCount")
        public Long courseCount;

        @NameInMap("courseHours")
        public Float courseHours;

        @NameInMap("subjectCode")
        public String subjectCode;

        @NameInMap("subjectName")
        public Long subjectName;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static QueryStatisticsDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryStatisticsDataResponseBodyResult self = new QueryStatisticsDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryStatisticsDataResponseBodyResult setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
            return this.classId;
        }

        public QueryStatisticsDataResponseBodyResult setCourseCount(Long courseCount) {
            this.courseCount = courseCount;
            return this;
        }
        public Long getCourseCount() {
            return this.courseCount;
        }

        public QueryStatisticsDataResponseBodyResult setCourseHours(Float courseHours) {
            this.courseHours = courseHours;
            return this;
        }
        public Float getCourseHours() {
            return this.courseHours;
        }

        public QueryStatisticsDataResponseBodyResult setSubjectCode(String subjectCode) {
            this.subjectCode = subjectCode;
            return this;
        }
        public String getSubjectCode() {
            return this.subjectCode;
        }

        public QueryStatisticsDataResponseBodyResult setSubjectName(Long subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public Long getSubjectName() {
            return this.subjectName;
        }

        public QueryStatisticsDataResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryStatisticsDataResponseBodyResult setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
