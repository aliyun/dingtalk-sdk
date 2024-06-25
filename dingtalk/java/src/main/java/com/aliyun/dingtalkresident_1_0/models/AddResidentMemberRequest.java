// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>A栋</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>11112</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("isPropertyOwner")
        public Boolean isPropertyOwner;

        /**
         * <strong>example:</strong>
         * <p>{&quot;startTime&quot;:1652358627106,&quot;endTime&quot;:1652445027106}</p>
         */
        @NameInMap("memberDeptExtension")
        public java.util.Map<String, ?> memberDeptExtension;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>148********</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
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
