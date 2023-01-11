// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentUserRequest extends TeaModel {
    /**
     * <p>家庭住址</p>
     */
    @NameInMap("address")
    public String address;

    /**
     * <p>所在新的户/租户部门id</p>
     */
    @NameInMap("departmentId")
    public Long departmentId;

    /**
     * <p>扩展字段（包括身份证/性别/民族）</p>
     */
    @NameInMap("extField")
    public java.util.List<UpdateResidentUserRequestExtField> extField;

    /**
     * <p>是否保留原部门</p>
     */
    @NameInMap("isRetainOldDept")
    public Boolean isRetainOldDept;

    /**
     * <p>手机号码</p>
     */
    @NameInMap("mobile")
    public String mobile;

    /**
     * <p>原所在部门id</p>
     */
    @NameInMap("oldDepartmentId")
    public Long oldDepartmentId;

    /**
     * <p>与户主的关系</p>
     */
    @NameInMap("relateType")
    public String relateType;

    /**
     * <p>人员userId</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>居民名字</p>
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
         * <p>扩展字段名字</p>
         */
        @NameInMap("itemName")
        public String itemName;

        /**
         * <p>扩展字段值</p>
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
