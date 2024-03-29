// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfStaffResp extends TeaModel {
    @NameInMap("deptCode")
    public String deptCode;

    @NameInMap("deptName")
    public String deptName;

    @NameInMap("email")
    public String email;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("name")
    public String name;

    @NameInMap("nickName")
    public String nickName;

    @NameInMap("workNumbers")
    public String workNumbers;

    public static CfStaffResp build(java.util.Map<String, ?> map) throws Exception {
        CfStaffResp self = new CfStaffResp();
        return TeaModel.build(map, self);
    }

    public CfStaffResp setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

    public CfStaffResp setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public CfStaffResp setEmail(String email) {
        this.email = email;
        return this;
    }
    public String getEmail() {
        return this.email;
    }

    public CfStaffResp setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public CfStaffResp setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CfStaffResp setNickName(String nickName) {
        this.nickName = nickName;
        return this;
    }
    public String getNickName() {
        return this.nickName;
    }

    public CfStaffResp setWorkNumbers(String workNumbers) {
        this.workNumbers = workNumbers;
        return this;
    }
    public String getWorkNumbers() {
        return this.workNumbers;
    }

}
