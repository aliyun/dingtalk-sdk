// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateDepartmentRequest extends TeaModel {
    /**
     * <p>认证信息</p>
     */
    @NameInMap("authInfo")
    public String authInfo;

    /**
     * <p>认证方式</p>
     */
    @NameInMap("authType")
    public String authType;

    /**
     * <p>业务扩展</p>
     */
    @NameInMap("bizExt")
    public String bizExt;

    /**
     * <p>部门名称</p>
     */
    @NameInMap("departmentName")
    public String departmentName;

    /**
     * <p>部门类型</p>
     */
    @NameInMap("departmentType")
    public String departmentType;

    /**
     * <p>部门描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>业务系统地址</p>
     */
    @NameInMap("systemUrl")
    public String systemUrl;

    /**
     * <p>创建人工号</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CreateDepartmentRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDepartmentRequest self = new CreateDepartmentRequest();
        return TeaModel.build(map, self);
    }

    public CreateDepartmentRequest setAuthInfo(String authInfo) {
        this.authInfo = authInfo;
        return this;
    }
    public String getAuthInfo() {
        return this.authInfo;
    }

    public CreateDepartmentRequest setAuthType(String authType) {
        this.authType = authType;
        return this;
    }
    public String getAuthType() {
        return this.authType;
    }

    public CreateDepartmentRequest setBizExt(String bizExt) {
        this.bizExt = bizExt;
        return this;
    }
    public String getBizExt() {
        return this.bizExt;
    }

    public CreateDepartmentRequest setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public CreateDepartmentRequest setDepartmentType(String departmentType) {
        this.departmentType = departmentType;
        return this;
    }
    public String getDepartmentType() {
        return this.departmentType;
    }

    public CreateDepartmentRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateDepartmentRequest setSystemUrl(String systemUrl) {
        this.systemUrl = systemUrl;
        return this;
    }
    public String getSystemUrl() {
        return this.systemUrl;
    }

    public CreateDepartmentRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
