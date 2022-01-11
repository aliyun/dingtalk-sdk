// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerResponseBody extends TeaModel {
    // 联系人保存结果
    @NameInMap("contacts")
    public java.util.List<CreateCustomerResponseBodyContacts> contacts;

    // 客户实例id
    @NameInMap("customerInstanceId")
    public String customerInstanceId;

    // 保存客户类型
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
        // 联系人实例id
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
