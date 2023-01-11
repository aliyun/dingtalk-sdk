// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerResponseBody extends TeaModel {
    /**
     * <p>联系人保存结果</p>
     */
    @NameInMap("contacts")
    public java.util.List<CreateCustomerResponseBodyContacts> contacts;

    /**
     * <p>客户实例id</p>
     */
    @NameInMap("customerInstanceId")
    public String customerInstanceId;

    /**
     * <p>保存客户类型</p>
     */
    @NameInMap("objectType")
    public String objectType;

    public static CreateCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomerResponseBody self = new CreateCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomerResponseBody setContacts(java.util.List<CreateCustomerResponseBodyContacts> contacts) {
        this.contacts = contacts;
        return this;
    }
    public java.util.List<CreateCustomerResponseBodyContacts> getContacts() {
        return this.contacts;
    }

    public CreateCustomerResponseBody setCustomerInstanceId(String customerInstanceId) {
        this.customerInstanceId = customerInstanceId;
        return this;
    }
    public String getCustomerInstanceId() {
        return this.customerInstanceId;
    }

    public CreateCustomerResponseBody setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public static class CreateCustomerResponseBodyContacts extends TeaModel {
        /**
         * <p>联系人实例id</p>
         */
        @NameInMap("contactInstanceId")
        public String contactInstanceId;

        public static CreateCustomerResponseBodyContacts build(java.util.Map<String, ?> map) throws Exception {
            CreateCustomerResponseBodyContacts self = new CreateCustomerResponseBodyContacts();
            return TeaModel.build(map, self);
        }

        public CreateCustomerResponseBodyContacts setContactInstanceId(String contactInstanceId) {
            this.contactInstanceId = contactInstanceId;
            return this;
        }
        public String getContactInstanceId() {
            return this.contactInstanceId;
        }

    }

}
