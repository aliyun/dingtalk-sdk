// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListUncheckedStudentResponseBody extends TeaModel {
    @NameInMap("studentInfoSimpleList")
    public java.util.List<CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList> studentInfoSimpleList;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static CollegeListUncheckedStudentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeListUncheckedStudentResponseBody self = new CollegeListUncheckedStudentResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeListUncheckedStudentResponseBody setStudentInfoSimpleList(java.util.List<CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList> studentInfoSimpleList) {
        this.studentInfoSimpleList = studentInfoSimpleList;
        return this;
    }
    public java.util.List<CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList> getStudentInfoSimpleList() {
        return this.studentInfoSimpleList;
    }

    public CollegeListUncheckedStudentResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>NORMAL</p>
         */
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        @NameInMap("isActive")
        public Boolean isActive;

        /**
         * <strong>example:</strong>
         * <p>1111111</p>
         */
        @NameInMap("studentId")
        public Long studentId;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("studentName")
        public String studentName;

        /**
         * <strong>example:</strong>
         * <p>11111111</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>0324124</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList build(java.util.Map<String, ?> map) throws Exception {
            CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList self = new CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList();
            return TeaModel.build(map, self);
        }

        public CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList setDingMemberStatus(String dingMemberStatus) {
            this.dingMemberStatus = dingMemberStatus;
            return this;
        }
        public String getDingMemberStatus() {
            return this.dingMemberStatus;
        }

        public CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList setIsActive(Boolean isActive) {
            this.isActive = isActive;
            return this;
        }
        public Boolean getIsActive() {
            return this.isActive;
        }

        public CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList setStudentId(Long studentId) {
            this.studentId = studentId;
            return this;
        }
        public Long getStudentId() {
            return this.studentId;
        }

        public CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
