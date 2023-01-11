// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListUncheckedStudentResponseBody extends TeaModel {
    /**
     * <p>学生信息列表</p>
     */
    @NameInMap("studentInfoSimpleList")
    public java.util.List<CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList> studentInfoSimpleList;

    /**
     * <p>条目总数</p>
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
         * <p>人员在组织的状态</p>
         */
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        /**
         * <p>账号是否激活</p>
         */
        @NameInMap("isActive")
        public Boolean isActive;

        /**
         * <p>学生id</p>
         */
        @NameInMap("studentId")
        public Long studentId;

        /**
         * <p>学生姓名</p>
         */
        @NameInMap("studentName")
        public String studentName;

        /**
         * <p>unionId</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>userId</p>
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
