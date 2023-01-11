// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListStudentInfoResponseBody extends TeaModel {
    /**
     * <p>学生信息列表</p>
     */
    @NameInMap("studentInfoSimpleList")
    public java.util.List<CollegeListStudentInfoResponseBodyStudentInfoSimpleList> studentInfoSimpleList;

    /**
     * <p>条目总数</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static CollegeListStudentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeListStudentInfoResponseBody self = new CollegeListStudentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeListStudentInfoResponseBody setStudentInfoSimpleList(java.util.List<CollegeListStudentInfoResponseBodyStudentInfoSimpleList> studentInfoSimpleList) {
        this.studentInfoSimpleList = studentInfoSimpleList;
        return this;
    }
    public java.util.List<CollegeListStudentInfoResponseBodyStudentInfoSimpleList> getStudentInfoSimpleList() {
        return this.studentInfoSimpleList;
    }

    public CollegeListStudentInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class CollegeListStudentInfoResponseBodyStudentInfoSimpleList extends TeaModel {
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

        public static CollegeListStudentInfoResponseBodyStudentInfoSimpleList build(java.util.Map<String, ?> map) throws Exception {
            CollegeListStudentInfoResponseBodyStudentInfoSimpleList self = new CollegeListStudentInfoResponseBodyStudentInfoSimpleList();
            return TeaModel.build(map, self);
        }

        public CollegeListStudentInfoResponseBodyStudentInfoSimpleList setDingMemberStatus(String dingMemberStatus) {
            this.dingMemberStatus = dingMemberStatus;
            return this;
        }
        public String getDingMemberStatus() {
            return this.dingMemberStatus;
        }

        public CollegeListStudentInfoResponseBodyStudentInfoSimpleList setIsActive(Boolean isActive) {
            this.isActive = isActive;
            return this;
        }
        public Boolean getIsActive() {
            return this.isActive;
        }

        public CollegeListStudentInfoResponseBodyStudentInfoSimpleList setStudentId(Long studentId) {
            this.studentId = studentId;
            return this;
        }
        public Long getStudentId() {
            return this.studentId;
        }

        public CollegeListStudentInfoResponseBodyStudentInfoSimpleList setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public CollegeListStudentInfoResponseBodyStudentInfoSimpleList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public CollegeListStudentInfoResponseBodyStudentInfoSimpleList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
