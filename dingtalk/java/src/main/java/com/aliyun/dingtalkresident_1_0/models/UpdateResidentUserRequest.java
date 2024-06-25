// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentUserRequest extends TeaModel {
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
    public java.util.List<UpdateResidentUserRequestExtField> extField;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("isRetainOldDept")
    public Boolean isRetainOldDept;

    /**
     * <strong>example:</strong>
     * <p>15612345678</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("oldDepartmentId")
    public Long oldDepartmentId;

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
     * <p>12345</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>王建国</p>
     */
    @NameInMap("userName")
    public String userName;

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

    public UpdateResidentUserRequest setIsRetainOldDept(Boolean isRetainOldDept) {
        this.isRetainOldDept = isRetainOldDept;
        return this;
    }
    public Boolean getIsRetainOldDept() {
        return this.isRetainOldDept;
    }

    public UpdateResidentUserRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public UpdateResidentUserRequest setOldDepartmentId(Long oldDepartmentId) {
        this.oldDepartmentId = oldDepartmentId;
        return this;
    }
    public Long getOldDepartmentId() {
        return this.oldDepartmentId;
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

    public UpdateResidentUserRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public static class UpdateResidentUserRequestExtField extends TeaModel {
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

        public static UpdateResidentUserRequestExtField build(java.util.Map<String, ?> map) throws Exception {
            UpdateResidentUserRequestExtField self = new UpdateResidentUserRequestExtField();
            return TeaModel.build(map, self);
        }

        public UpdateResidentUserRequestExtField setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

        public UpdateResidentUserRequestExtField setItemValue(String itemValue) {
            this.itemValue = itemValue;
            return this;
        }
        public String getItemValue() {
            return this.itemValue;
        }

    }

}
