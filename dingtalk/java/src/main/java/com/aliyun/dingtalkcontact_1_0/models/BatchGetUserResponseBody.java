// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchGetUserResponseBody extends TeaModel {
    @NameInMap("unauthorizedUserIdList")
    public java.util.List<String> unauthorizedUserIdList;

    @NameInMap("userList")
    public java.util.List<BatchGetUserResponseBodyUserList> userList;

    public static BatchGetUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetUserResponseBody self = new BatchGetUserResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetUserResponseBody setUnauthorizedUserIdList(java.util.List<String> unauthorizedUserIdList) {
        this.unauthorizedUserIdList = unauthorizedUserIdList;
        return this;
    }
    public java.util.List<String> getUnauthorizedUserIdList() {
        return this.unauthorizedUserIdList;
    }

    public BatchGetUserResponseBody setUserList(java.util.List<BatchGetUserResponseBodyUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<BatchGetUserResponseBodyUserList> getUserList() {
        return this.userList;
    }

    public static class BatchGetUserResponseBodyUserList extends TeaModel {
        @NameInMap("job_number")
        public String jobNumber;

        @NameInMap("mobile")
        public String mobile;

        @NameInMap("name")
        public String name;

        @NameInMap("nickname")
        public String nickname;

        @NameInMap("remark")
        public String remark;

        @NameInMap("senior")
        public Boolean senior;

        @NameInMap("state_code")
        public String stateCode;

        @NameInMap("unionid")
        public String unionid;

        @NameInMap("userid")
        public String userid;

        public static BatchGetUserResponseBodyUserList build(java.util.Map<String, ?> map) throws Exception {
            BatchGetUserResponseBodyUserList self = new BatchGetUserResponseBodyUserList();
            return TeaModel.build(map, self);
        }

        public BatchGetUserResponseBodyUserList setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public BatchGetUserResponseBodyUserList setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public BatchGetUserResponseBodyUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchGetUserResponseBodyUserList setNickname(String nickname) {
            this.nickname = nickname;
            return this;
        }
        public String getNickname() {
            return this.nickname;
        }

        public BatchGetUserResponseBodyUserList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public BatchGetUserResponseBodyUserList setSenior(Boolean senior) {
            this.senior = senior;
            return this;
        }
        public Boolean getSenior() {
            return this.senior;
        }

        public BatchGetUserResponseBodyUserList setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

        public BatchGetUserResponseBodyUserList setUnionid(String unionid) {
            this.unionid = unionid;
            return this;
        }
        public String getUnionid() {
            return this.unionid;
        }

        public BatchGetUserResponseBodyUserList setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
