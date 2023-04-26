// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentMemberRequest extends TeaModel {
    @NameInMap("residentAddInfo")
    public AddResidentMemberRequestResidentAddInfo residentAddInfo;

    public static AddResidentMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddResidentMemberRequest self = new AddResidentMemberRequest();
        return TeaModel.build(map, self);
    }

    public AddResidentMemberRequest setResidentAddInfo(AddResidentMemberRequestResidentAddInfo residentAddInfo) {
        this.residentAddInfo = residentAddInfo;
        return this;
    }
    public AddResidentMemberRequestResidentAddInfo getResidentAddInfo() {
        return this.residentAddInfo;
    }

    public static class AddResidentMemberRequestResidentAddInfo extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("isPropertyOwner")
        public Boolean isPropertyOwner;

        @NameInMap("memberDeptExtension")
        public java.util.Map<String, ?> memberDeptExtension;

        @NameInMap("mobile")
        public String mobile;

        @NameInMap("name")
        public String name;

        @NameInMap("relateType")
        public String relateType;

        public static AddResidentMemberRequestResidentAddInfo build(java.util.Map<String, ?> map) throws Exception {
            AddResidentMemberRequestResidentAddInfo self = new AddResidentMemberRequestResidentAddInfo();
            return TeaModel.build(map, self);
        }

        public AddResidentMemberRequestResidentAddInfo setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public AddResidentMemberRequestResidentAddInfo setIsPropertyOwner(Boolean isPropertyOwner) {
            this.isPropertyOwner = isPropertyOwner;
            return this;
        }
        public Boolean getIsPropertyOwner() {
            return this.isPropertyOwner;
        }

        public AddResidentMemberRequestResidentAddInfo setMemberDeptExtension(java.util.Map<String, ?> memberDeptExtension) {
            this.memberDeptExtension = memberDeptExtension;
            return this;
        }
        public java.util.Map<String, ?> getMemberDeptExtension() {
            return this.memberDeptExtension;
        }

        public AddResidentMemberRequestResidentAddInfo setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public AddResidentMemberRequestResidentAddInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddResidentMemberRequestResidentAddInfo setRelateType(String relateType) {
            this.relateType = relateType;
            return this;
        }
        public String getRelateType() {
            return this.relateType;
        }

    }

}
