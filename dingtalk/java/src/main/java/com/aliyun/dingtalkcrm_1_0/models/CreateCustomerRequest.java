// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerRequest extends TeaModel {
    @NameInMap("contacts")
    public java.util.List<CreateCustomerRequestContacts> contacts;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("creatorUserId")
    public String creatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public java.util.Map<String, ?> data;

    @NameInMap("extendData")
    public java.util.Map<String, ?> extendData;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("objectType")
    public String objectType;

    @NameInMap("permission")
    public CreateCustomerRequestPermission permission;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

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
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

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
        @NameInMap("customerExistedPolicy")
        public String customerExistedPolicy;

        @NameInMap("skipDuplicateCheck")
        public Boolean skipDuplicateCheck;

        @NameInMap("subscribePolicy")
        public Long subscribePolicy;

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
