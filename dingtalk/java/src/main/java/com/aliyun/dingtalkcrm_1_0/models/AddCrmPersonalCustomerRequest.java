// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCrmPersonalCustomerRequest extends TeaModel {
    // 记录创建人的用户ID
    @NameInMap("creatorUserId")
    public String creatorUserId;

    // 记录创建人的昵称
    @NameInMap("creatorNick")
    public String creatorNick;

    // 数据内容
    @NameInMap("data")
    public java.util.Map<String, ?> data;

    // 扩展数据内容
    @NameInMap("extendData")
    public java.util.Map<String, ?> extendData;

    // 权限
    @NameInMap("permission")
    public AddCrmPersonalCustomerRequestPermission permission;

    // 跳过uk查重
    @NameInMap("skipDuplicateCheck")
    public Boolean skipDuplicateCheck;

    // 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
    @NameInMap("action")
    public String action;

    public static AddCrmPersonalCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCrmPersonalCustomerRequest self = new AddCrmPersonalCustomerRequest();
        return TeaModel.build(map, self);
    }

    public AddCrmPersonalCustomerRequest setCreatorUserId(String creatorUserId) {
        this.creatorUserId = creatorUserId;
        return this;
    }
    public String getCreatorUserId() {
        return this.creatorUserId;
    }

    public AddCrmPersonalCustomerRequest setCreatorNick(String creatorNick) {
        this.creatorNick = creatorNick;
        return this;
    }
    public String getCreatorNick() {
        return this.creatorNick;
    }

    public AddCrmPersonalCustomerRequest setData(java.util.Map<String, ?> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, ?> getData() {
        return this.data;
    }

    public AddCrmPersonalCustomerRequest setExtendData(java.util.Map<String, ?> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.Map<String, ?> getExtendData() {
        return this.extendData;
    }

    public AddCrmPersonalCustomerRequest setPermission(AddCrmPersonalCustomerRequestPermission permission) {
        this.permission = permission;
        return this;
    }
    public AddCrmPersonalCustomerRequestPermission getPermission() {
        return this.permission;
    }

    public AddCrmPersonalCustomerRequest setSkipDuplicateCheck(Boolean skipDuplicateCheck) {
        this.skipDuplicateCheck = skipDuplicateCheck;
        return this;
    }
    public Boolean getSkipDuplicateCheck() {
        return this.skipDuplicateCheck;
    }

    public AddCrmPersonalCustomerRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public static class AddCrmPersonalCustomerRequestPermission extends TeaModel {
        // 负责人的用户ID
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        // 协同人的用户ID
        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        public static AddCrmPersonalCustomerRequestPermission build(java.util.Map<String, ?> map) throws Exception {
            AddCrmPersonalCustomerRequestPermission self = new AddCrmPersonalCustomerRequestPermission();
            return TeaModel.build(map, self);
        }

        public AddCrmPersonalCustomerRequestPermission setOwnerStaffIds(java.util.List<String> ownerStaffIds) {
            this.ownerStaffIds = ownerStaffIds;
            return this;
        }
        public java.util.List<String> getOwnerStaffIds() {
            return this.ownerStaffIds;
        }

        public AddCrmPersonalCustomerRequestPermission setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

    }

}
