// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateDepartmentRequest extends TeaModel {
    // 认证信息
    @NameInMap("authInfo")
    public String authInfo;

    // 认证方式
    @NameInMap("authType")
    public String authType;

    // 业务扩展
    @NameInMap("bizExt")
    public String bizExt;

    // 部门名称
    @NameInMap("departmentName")
    public String departmentName;

    // 部门类型
    @NameInMap("departmentType")
    public String departmentType;

    // 部门描述
    @NameInMap("description")
    public String description;

    // 业务系统地址
    @NameInMap("systemUrl")
    public String systemUrl;

    // 创建人工号
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
