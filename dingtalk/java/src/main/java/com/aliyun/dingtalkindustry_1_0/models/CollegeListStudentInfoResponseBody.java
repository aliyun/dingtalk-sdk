// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListStudentInfoResponseBody extends TeaModel {
    // 学生信息列表
    @NameInMap("studentInfoSimpleList")
    public java.util.List<CollegeListStudentInfoResponseBodyStudentInfoSimpleList> studentInfoSimpleList;

    // 条目总数
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
        // 人员在组织的状态
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        // 账号是否激活
        @NameInMap("isActive")
        public Boolean isActive;

        // 学生id
        @NameInMap("studentId")
        public Long studentId;

        // 学生姓名
        @NameInMap("studentName")
        public String studentName;

        // unionId
        @NameInMap("unionId")
        public String unionId;

        // userId
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
