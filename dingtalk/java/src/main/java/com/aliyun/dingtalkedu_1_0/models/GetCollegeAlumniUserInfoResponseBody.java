// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniUserInfoResponseBody extends TeaModel {
    @NameInMap("address")
    public String address;

    @NameInMap("avatar")
    public String avatar;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("depts")
    public java.util.List<GetCollegeAlumniUserInfoResponseBodyDepts> depts;

    @NameInMap("email")
    public String email;

    @NameInMap("intake")
    public String intake;

    @NameInMap("inviteId")
    public String inviteId;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("name")
    public String name;

    @NameInMap("outtake")
    public String outtake;

    @NameInMap("studentNumber")
    public String studentNumber;

    @NameInMap("userId")
    public String userId;

    public static GetCollegeAlumniUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniUserInfoResponseBody self = new GetCollegeAlumniUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniUserInfoResponseBody setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public GetCollegeAlumniUserInfoResponseBody setAvatar(String avatar) {
        this.avatar = avatar;
        return this;
    }
    public String getAvatar() {
        return this.avatar;
    }

    public GetCollegeAlumniUserInfoResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetCollegeAlumniUserInfoResponseBody setDepts(java.util.List<GetCollegeAlumniUserInfoResponseBodyDepts> depts) {
        this.depts = depts;
        return this;
    }
    public java.util.List<GetCollegeAlumniUserInfoResponseBodyDepts> getDepts() {
        return this.depts;
    }

    public GetCollegeAlumniUserInfoResponseBody setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public GetCollegeAlumniUserInfoResponseBody setIntake(String intake) {
        this.intake = intake;
        return this;
    }
    public String getIntake() {
        return this.intake;
    }

    public GetCollegeAlumniUserInfoResponseBody setInviteId(String inviteId) {
        this.inviteId = inviteId;
        return this;
    }
    public String getInviteId() {
        return this.inviteId;
    }

    public GetCollegeAlumniUserInfoResponseBody setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public GetCollegeAlumniUserInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCollegeAlumniUserInfoResponseBody setOuttake(String outtake) {
        this.outtake = outtake;
        return this;
    }
    public String getOuttake() {
        return this.outtake;
    }

    public GetCollegeAlumniUserInfoResponseBody setStudentNumber(String studentNumber) {
        this.studentNumber = studentNumber;
        return this;
    }
    public String getStudentNumber() {
        return this.studentNumber;
    }

    public GetCollegeAlumniUserInfoResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class GetCollegeAlumniUserInfoResponseBodyDepts extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("hasSubDept")
        public Boolean hasSubDept;

        @NameInMap("isIndustryDept")
        public Boolean isIndustryDept;

        @NameInMap("name")
        public String name;

        public static GetCollegeAlumniUserInfoResponseBodyDepts build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeAlumniUserInfoResponseBodyDepts self = new GetCollegeAlumniUserInfoResponseBodyDepts();
            return TeaModel.build(map, self);
        }

        public GetCollegeAlumniUserInfoResponseBodyDepts setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCollegeAlumniUserInfoResponseBodyDepts setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetCollegeAlumniUserInfoResponseBodyDepts setHasSubDept(Boolean hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public Boolean getHasSubDept() {
            return this.hasSubDept;
        }

        public GetCollegeAlumniUserInfoResponseBodyDepts setIsIndustryDept(Boolean isIndustryDept) {
            this.isIndustryDept = isIndustryDept;
            return this;
        }
        public Boolean getIsIndustryDept() {
            return this.isIndustryDept;
        }

        public GetCollegeAlumniUserInfoResponseBodyDepts setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
