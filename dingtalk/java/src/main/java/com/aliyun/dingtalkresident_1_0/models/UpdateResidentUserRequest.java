// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentUserRequest extends TeaModel {
    // 家庭住址
    @NameInMap("address")
    public String address;

    // 是否保留原部门
    @NameInMap("isRetainOldDept")
    public Boolean isRetainOldDept;

    // 居民名字
    @NameInMap("name")
    public String name;

    // 手机号码
    @NameInMap("mobile")
    public String mobile;

    // 所在新的户/租户部门id
    @NameInMap("departmentId")
    public Long departmentId;

    // 扩展字段（包括身份证/性别/民族）
    @NameInMap("extField")
    public java.util.List<UpdateResidentUserRequestExtField> extField;

    // 与户主的关系
    @NameInMap("relateType")
    public String relateType;

    // 人员userId
    @NameInMap("userId")
    public String userId;

    // 原所在部门id
    @NameInMap("oldDepartmentId")
    public Long oldDepartmentId;

    public static UpdateResidentUserRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentUserRequest self = new UpdateResidentUserRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidentUserRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public UpdateResidentUserRequest setIsRetainOldDept(Boolean isRetainOldDept) {
        this.isRetainOldDept = isRetainOldDept;
        return this;
    }
    public Boolean getIsRetainOldDept() {
        return this.isRetainOldDept;
    }

    public UpdateResidentUserRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateResidentUserRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public UpdateResidentUserRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public UpdateResidentUserRequest setExtField(java.util.List<UpdateResidentUserRequestExtField> extField) {
        this.extField = extField;
        return this;
    }
    public java.util.List<UpdateResidentUserRequestExtField> getExtField() {
        return this.extField;
    }

    public UpdateResidentUserRequest setRelateType(String relateType) {
        this.relateType = relateType;
        return this;
    }
    public String getRelateType() {
        return this.relateType;
    }

    public UpdateResidentUserRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public UpdateResidentUserRequest setOldDepartmentId(Long oldDepartmentId) {
        this.oldDepartmentId = oldDepartmentId;
        return this;
    }
    public Long getOldDepartmentId() {
        return this.oldDepartmentId;
    }

    public static class UpdateResidentUserRequestExtField extends TeaModel {
        // 扩展字段值
        @NameInMap("itemValue")
        public String itemValue;

        // 扩展字段名字
        @NameInMap("itemName")
        public String itemName;

        public static UpdateResidentUserRequestExtField build(java.util.Map<String, ?> map) throws Exception {
            UpdateResidentUserRequestExtField self = new UpdateResidentUserRequestExtField();
            return TeaModel.build(map, self);
        }

        public UpdateResidentUserRequestExtField setItemValue(String itemValue) {
            this.itemValue = itemValue;
            return this;
        }
        public String getItemValue() {
            return this.itemValue;
        }

        public UpdateResidentUserRequestExtField setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

    }

}
