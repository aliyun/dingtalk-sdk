// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniUserInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCollegeAlumniUserInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetCollegeAlumniUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniUserInfoResponseBody self = new GetCollegeAlumniUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniUserInfoResponseBody setResult(GetCollegeAlumniUserInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCollegeAlumniUserInfoResponseBodyResult getResult() {
        return this.result;
    }

    public GetCollegeAlumniUserInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetCollegeAlumniUserInfoResponseBodyResultDepts extends TeaModel {
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

        public static GetCollegeAlumniUserInfoResponseBodyResultDepts build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeAlumniUserInfoResponseBodyResultDepts self = new GetCollegeAlumniUserInfoResponseBodyResultDepts();
            return TeaModel.build(map, self);
        }

        public GetCollegeAlumniUserInfoResponseBodyResultDepts setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCollegeAlumniUserInfoResponseBodyResultDepts setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetCollegeAlumniUserInfoResponseBodyResultDepts setHasSubDept(Boolean hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public Boolean getHasSubDept() {
            return this.hasSubDept;
        }

        public GetCollegeAlumniUserInfoResponseBodyResultDepts setIsIndustryDept(Boolean isIndustryDept) {
            this.isIndustryDept = isIndustryDept;
            return this;
        }
        public Boolean getIsIndustryDept() {
            return this.isIndustryDept;
        }

        public GetCollegeAlumniUserInfoResponseBodyResultDepts setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetCollegeAlumniUserInfoResponseBodyResult extends TeaModel {
        @NameInMap("address")
        public String address;

        @NameInMap("avatar")
        public String avatar;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("depts")
        public java.util.List<GetCollegeAlumniUserInfoResponseBodyResultDepts> depts;

        @NameInMap("email")
        public String email;

        @NameInMap("intake")
        public String intake;

        @NameInMap("inviteId")
        public Long inviteId;

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

        public static GetCollegeAlumniUserInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCollegeAlumniUserInfoResponseBodyResult self = new GetCollegeAlumniUserInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setDepts(java.util.List<GetCollegeAlumniUserInfoResponseBodyResultDepts> depts) {
            this.depts = depts;
            return this;
        }
        public java.util.List<GetCollegeAlumniUserInfoResponseBodyResultDepts> getDepts() {
            return this.depts;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setIntake(String intake) {
            this.intake = intake;
            return this;
        }
        public String getIntake() {
            return this.intake;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setInviteId(Long inviteId) {
            this.inviteId = inviteId;
            return this;
        }
        public Long getInviteId() {
            return this.inviteId;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setOuttake(String outtake) {
            this.outtake = outtake;
            return this;
        }
        public String getOuttake() {
            return this.outtake;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setStudentNumber(String studentNumber) {
            this.studentNumber = studentNumber;
            return this;
        }
        public String getStudentNumber() {
            return this.studentNumber;
        }

        public GetCollegeAlumniUserInfoResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
