// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试小区1</p>
     */
    @NameInMap("residentUpdateInfo")
    public UpdateResidentMemberRequestResidentUpdateInfo residentUpdateInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1212</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateResidentMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentMemberRequest self = new UpdateResidentMemberRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidentMemberRequest setResidentUpdateInfo(UpdateResidentMemberRequestResidentUpdateInfo residentUpdateInfo) {
        this.residentUpdateInfo = residentUpdateInfo;
        return this;
    }
    public UpdateResidentMemberRequestResidentUpdateInfo getResidentUpdateInfo() {
        return this.residentUpdateInfo;
    }

    public UpdateResidentMemberRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class UpdateResidentMemberRequestResidentUpdateInfo extends TeaModel {
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
        public java.util.Map<String, String> memberDeptExtension;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>11123</p>
         */
        @NameInMap("oldDeptId")
        public Long oldDeptId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("relateType")
        public String relateType;

        /**
         * <strong>example:</strong>
         * <p>11123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UpdateResidentMemberRequestResidentUpdateInfo build(java.util.Map<String, ?> map) throws Exception {
            UpdateResidentMemberRequestResidentUpdateInfo self = new UpdateResidentMemberRequestResidentUpdateInfo();
            return TeaModel.build(map, self);
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setIsPropertyOwner(Boolean isPropertyOwner) {
            this.isPropertyOwner = isPropertyOwner;
            return this;
        }
        public Boolean getIsPropertyOwner() {
            return this.isPropertyOwner;
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setMemberDeptExtension(java.util.Map<String, String> memberDeptExtension) {
            this.memberDeptExtension = memberDeptExtension;
            return this;
        }
        public java.util.Map<String, String> getMemberDeptExtension() {
            return this.memberDeptExtension;
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setOldDeptId(Long oldDeptId) {
            this.oldDeptId = oldDeptId;
            return this;
        }
        public Long getOldDeptId() {
            return this.oldDeptId;
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setRelateType(String relateType) {
            this.relateType = relateType;
            return this;
        }
        public String getRelateType() {
            return this.relateType;
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
