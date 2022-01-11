// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentUsersRequest extends TeaModel {
    // 家庭住址
    @NameInMap("address")
    public String address;

    // 户/租户部门id
    @NameInMap("departmentId")
    public Long departmentId;

    // 扩展字段（包括身份证/性别/民族）
    @NameInMap("extField")
    public java.util.List<AddResidentUsersRequestExtField> extField;

    // 是否是租客
    @NameInMap("isLeaseholder")
    public Boolean isLeaseholder;

    // 手机号码
    @NameInMap("mobile")
    public String mobile;

    // 与户主的关系
    @NameInMap("relateType")
    public String relateType;

    // 居民名字
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
        // 扩展字段名字
        @NameInMap("itemName")
        public String itemName;

        // 扩展字段值
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
