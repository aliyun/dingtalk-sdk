// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerRequest extends TeaModel {
    /**
     * <p>关联联系人数据</p>
     */
    @NameInMap("contacts")
    public java.util.List<CreateCustomerRequestContacts> contacts;

    /**
     * <p>创建人的userId</p>
     */
    @NameInMap("creatorUserId")
    public String creatorUserId;

    /**
     * <p>客户实例数据（表单数据）</p>
     */
    @NameInMap("data")
    public java.util.Map<String, ?> data;

    /**
     * <p>客户实例扩展数据</p>
     */
    @NameInMap("extendData")
    public java.util.Map<String, ?> extendData;

    /**
     * <p>已存在客户时，添加联系人，可以传入客户的instanceId用作关联绑定</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <p>写入客户类型：个人客户crm_customer_personal; 企业客户crm_customer</p>
     */
    @NameInMap("objectType")
    public String objectType;

    /**
     * <p>权限</p>
     */
    @NameInMap("permission")
    public CreateCustomerRequestPermission permission;

    /**
     * <p>保存配置项</p>
     */
    @NameInMap("saveOption")
    public CreateCustomerRequestSaveOption saveOption;

    public static CreateCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomerRequest self = new CreateCustomerRequest();
        return TeaModel.build(map, self);
    }

    public CreateCustomerRequest setContacts(java.util.List<CreateCustomerRequestContacts> contacts) {
        this.contacts = contacts;
        return this;
    }
    public java.util.List<CreateCustomerRequestContacts> getContacts() {
        return this.contacts;
    }

    public CreateCustomerRequest setCreatorUserId(String creatorUserId) {
        this.creatorUserId = creatorUserId;
        return this;
    }
    public String getCreatorUserId() {
        return this.creatorUserId;
    }

    public CreateCustomerRequest setData(java.util.Map<String, ?> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, ?> getData() {
        return this.data;
    }

    public CreateCustomerRequest setExtendData(java.util.Map<String, ?> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.Map<String, ?> getExtendData() {
        return this.extendData;
    }

    public CreateCustomerRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public CreateCustomerRequest setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public CreateCustomerRequest setPermission(CreateCustomerRequestPermission permission) {
        this.permission = permission;
        return this;
    }
    public CreateCustomerRequestPermission getPermission() {
        return this.permission;
    }

    public CreateCustomerRequest setSaveOption(CreateCustomerRequestSaveOption saveOption) {
        this.saveOption = saveOption;
        return this;
    }
    public CreateCustomerRequestSaveOption getSaveOption() {
        return this.saveOption;
    }

    public static class CreateCustomerRequestContacts extends TeaModel {
        /**
         * <p>联系人表单数据</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <p>联系人扩展数据</p>
         */
        @NameInMap("extendData")
        public java.util.Map<String, ?> extendData;

        public static CreateCustomerRequestContacts build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomerRequestContacts self = new CreateCustomerRequestContacts();
            return TeaModel.build(map, self);
        }

        public CreateCustomerRequestContacts setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public CreateCustomerRequestContacts setExtendData(java.util.Map<String, ?> extendData) {
            this.extendData = extendData;
            return this;
        }
        public java.util.Map<String, ?> getExtendData() {
            return this.extendData;
        }

    }

    public static class CreateCustomerRequestPermission extends TeaModel {
        /**
         * <p>负责人</p>
         */
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        /**
         * <p>协同人</p>
         */
        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        public static CreateCustomerRequestPermission build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomerRequestPermission self = new CreateCustomerRequestPermission();
            return TeaModel.build(map, self);
        }

        public CreateCustomerRequestPermission setOwnerStaffIds(java.util.List<String> ownerStaffIds) {
            this.ownerStaffIds = ownerStaffIds;
            return this;
        }
        public java.util.List<String> getOwnerStaffIds() {
            return this.ownerStaffIds;
        }

        public CreateCustomerRequestPermission setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

    }

    public static class CreateCustomerRequestSaveOption extends TeaModel {
        /**
         * <p>客户已存在时的处理策略：APPEND_CONTACT_FORCE 直接追加联系人； REJECT 返回失败</p>
         */
        @NameInMap("customerExistedPolicy")
        public String customerExistedPolicy;

        /**
         * <p>跳过uk查重</p>
         */
        @NameInMap("skipDuplicateCheck")
        public Boolean skipDuplicateCheck;

        /**
         * <p>关注配置：0 不处理， 1 自动关注（需要单独申请白名单）</p>
         */
        @NameInMap("subscribePolicy")
        public Long subscribePolicy;

        /**
         * <p>保存联系人失败时是否阻断</p>
         */
        @NameInMap("throwExceptionWhileSavingContactFailed")
        public Boolean throwExceptionWhileSavingContactFailed;

        public static CreateCustomerRequestSaveOption build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomerRequestSaveOption self = new CreateCustomerRequestSaveOption();
            return TeaModel.build(map, self);
        }

        public CreateCustomerRequestSaveOption setCustomerExistedPolicy(String customerExistedPolicy) {
            this.customerExistedPolicy = customerExistedPolicy;
            return this;
        }
        public String getCustomerExistedPolicy() {
            return this.customerExistedPolicy;
        }

        public CreateCustomerRequestSaveOption setSkipDuplicateCheck(Boolean skipDuplicateCheck) {
            this.skipDuplicateCheck = skipDuplicateCheck;
            return this;
        }
        public Boolean getSkipDuplicateCheck() {
            return this.skipDuplicateCheck;
        }

        public CreateCustomerRequestSaveOption setSubscribePolicy(Long subscribePolicy) {
            this.subscribePolicy = subscribePolicy;
            return this;
        }
        public Long getSubscribePolicy() {
            return this.subscribePolicy;
        }

        public CreateCustomerRequestSaveOption setThrowExceptionWhileSavingContactFailed(Boolean throwExceptionWhileSavingContactFailed) {
            this.throwExceptionWhileSavingContactFailed = throwExceptionWhileSavingContactFailed;
            return this;
        }
        public Boolean getThrowExceptionWhileSavingContactFailed() {
            return this.throwExceptionWhileSavingContactFailed;
        }

    }

}
