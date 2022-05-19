// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentMemberRequest extends TeaModel {
    // 人员更新信息
    @NameInMap("residentUpdateInfo")
    public UpdateResidentMemberRequestResidentUpdateInfo residentUpdateInfo;

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

    public static class UpdateResidentMemberRequestResidentUpdateInfo extends TeaModel {
        // 部门id
        @NameInMap("deptId")
        public Long deptId;

        // 是否是产权人
        @NameInMap("isPropertyOwner")
        public Boolean isPropertyOwner;

        // 是否保留旧部门，默认不保存
        @NameInMap("isRetainOldDept")
        public Boolean isRetainOldDept;

        // 人员扩展信息，目前只有租客的起止时间
        @NameInMap("memberDeptExtension")
        public java.util.Map<String, ?> memberDeptExtension;

        // 姓名
        @NameInMap("name")
        public String name;

        // 旧部门id
        @NameInMap("oldDeptId")
        public Long oldDeptId;

        // 身份，1：业主，2：租客，3：亲友
        @NameInMap("relateType")
        public String relateType;

        // 用户id
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

        public UpdateResidentMemberRequestResidentUpdateInfo setIsRetainOldDept(Boolean isRetainOldDept) {
            this.isRetainOldDept = isRetainOldDept;
            return this;
        }
        public Boolean getIsRetainOldDept() {
            return this.isRetainOldDept;
        }

        public UpdateResidentMemberRequestResidentUpdateInfo setMemberDeptExtension(java.util.Map<String, ?> memberDeptExtension) {
            this.memberDeptExtension = memberDeptExtension;
            return this;
        }
        public java.util.Map<String, ?> getMemberDeptExtension() {
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
