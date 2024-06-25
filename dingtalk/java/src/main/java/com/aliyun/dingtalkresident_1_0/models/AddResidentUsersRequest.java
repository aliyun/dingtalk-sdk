// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentUsersRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>美好社区创景街道万通公寓</p>
     */
    @NameInMap("address")
    public String address;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("departmentId")
    public Long departmentId;

    @NameInMap("extField")
    public java.util.List<AddResidentUsersRequestExtField> extField;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("isLeaseholder")
    public Boolean isLeaseholder;

    /**
     * <strong>example:</strong>
     * <p>15612345678</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <strong>example:</strong>
     * <p>SELF</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("relateType")
    public String relateType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>王建国</p>
     */
    @NameInMap("userName")
    public String userName;

    public static AddResidentUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        AddResidentUsersRequest self = new AddResidentUsersRequest();
        return TeaModel.build(map, self);
    }

    public AddResidentUsersRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public AddResidentUsersRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public AddResidentUsersRequest setExtField(java.util.List<AddResidentUsersRequestExtField> extField) {
        this.extField = extField;
        return this;
    }
    public java.util.List<AddResidentUsersRequestExtField> getExtField() {
        return this.extField;
    }

    public AddResidentUsersRequest setIsLeaseholder(Boolean isLeaseholder) {
        this.isLeaseholder = isLeaseholder;
        return this;
    }
    public Boolean getIsLeaseholder() {
        return this.isLeaseholder;
    }

    public AddResidentUsersRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public AddResidentUsersRequest setRelateType(String relateType) {
        this.relateType = relateType;
        return this;
    }
    public String getRelateType() {
        return this.relateType;
    }

    public AddResidentUsersRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public static class AddResidentUsersRequestExtField extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>性别</p>
         */
        @NameInMap("itemName")
        public String itemName;

        /**
         * <strong>example:</strong>
         * <p>女</p>
         */
        @NameInMap("itemValue")
        public String itemValue;

        public static AddResidentUsersRequestExtField build(java.util.Map<String, ?> map) throws Exception {
            AddResidentUsersRequestExtField self = new AddResidentUsersRequestExtField();
            return TeaModel.build(map, self);
        }

        public AddResidentUsersRequestExtField setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

        public AddResidentUsersRequestExtField setItemValue(String itemValue) {
            this.itemValue = itemValue;
            return this;
        }
        public String getItemValue() {
            return this.itemValue;
        }

    }

}
