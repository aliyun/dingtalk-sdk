// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCrmPersonalCustomerRequest extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("modifierUserId")
    public String modifierUserId;

    @NameInMap("modifierNick")
    public String modifierNick;

    @NameInMap("data")
    public java.util.Map<String, ?> data;

    @NameInMap("extendData")
    public java.util.Map<String, ?> extendData;

    @NameInMap("permission")
    public UpdateCrmPersonalCustomerRequestPermission permission;

    @NameInMap("relationType")
    public String relationType;

    // 跳过uk查重
    @NameInMap("skipDuplicateCheck")
    public Boolean skipDuplicateCheck;

    // 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
    @NameInMap("action")
    public String action;

    public static UpdateCrmPersonalCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCrmPersonalCustomerRequest self = new UpdateCrmPersonalCustomerRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCrmPersonalCustomerRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public UpdateCrmPersonalCustomerRequest setModifierUserId(String modifierUserId) {
        this.modifierUserId = modifierUserId;
        return this;
    }
    public String getModifierUserId() {
        return this.modifierUserId;
    }

    public UpdateCrmPersonalCustomerRequest setModifierNick(String modifierNick) {
        this.modifierNick = modifierNick;
        return this;
    }
    public String getModifierNick() {
        return this.modifierNick;
    }

    public UpdateCrmPersonalCustomerRequest setData(java.util.Map<String, ?> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, ?> getData() {
        return this.data;
    }

    public UpdateCrmPersonalCustomerRequest setExtendData(java.util.Map<String, ?> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.Map<String, ?> getExtendData() {
        return this.extendData;
    }

    public UpdateCrmPersonalCustomerRequest setPermission(UpdateCrmPersonalCustomerRequestPermission permission) {
        this.permission = permission;
        return this;
    }
    public UpdateCrmPersonalCustomerRequestPermission getPermission() {
        return this.permission;
    }

    public UpdateCrmPersonalCustomerRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

    public UpdateCrmPersonalCustomerRequest setSkipDuplicateCheck(Boolean skipDuplicateCheck) {
        this.skipDuplicateCheck = skipDuplicateCheck;
        return this;
    }
    public Boolean getSkipDuplicateCheck() {
        return this.skipDuplicateCheck;
    }

    public UpdateCrmPersonalCustomerRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public static class UpdateCrmPersonalCustomerRequestPermission extends TeaModel {
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        public static UpdateCrmPersonalCustomerRequestPermission build(java.util.Map<String, ?> map) throws Exception {
            UpdateCrmPersonalCustomerRequestPermission self = new UpdateCrmPersonalCustomerRequestPermission();
            return TeaModel.build(map, self);
        }

        public UpdateCrmPersonalCustomerRequestPermission setOwnerStaffIds(java.util.List<String> ownerStaffIds) {
            this.ownerStaffIds = ownerStaffIds;
            return this;
        }
        public java.util.List<String> getOwnerStaffIds() {
            return this.ownerStaffIds;
        }

        public UpdateCrmPersonalCustomerRequestPermission setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

    }

}
