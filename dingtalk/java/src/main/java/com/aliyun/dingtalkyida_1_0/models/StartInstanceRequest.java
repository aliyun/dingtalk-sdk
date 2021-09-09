// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class StartInstanceRequest extends TeaModel {
    // 应用编码
    @NameInMap("appType")
    public String appType;

    // 应用秘钥。在应用数据中获取。
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉userId
    @NameInMap("userId")
    public String userId;

    // 语言。可选值：zh_CN/en_US 默认：zh_CN
    @NameInMap("language")
    public String language;

    // 表单唯一编码
    @NameInMap("formUuid")
    public String formUuid;

    // 表单数据
    @NameInMap("formDataJson")
    public String formDataJson;

    // 流程编码
    @NameInMap("processCode")
    public String processCode;

    // 发起人所在部门编号
    @NameInMap("departmentId")
    public String departmentId;

    public static StartInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        StartInstanceRequest self = new StartInstanceRequest();
        return TeaModel.build(map, self);
    }

    public StartInstanceRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public StartInstanceRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public StartInstanceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public StartInstanceRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public StartInstanceRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public StartInstanceRequest setFormDataJson(String formDataJson) {
        this.formDataJson = formDataJson;
        return this;
    }
    public String getFormDataJson() {
        return this.formDataJson;
    }

    public StartInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public StartInstanceRequest setDepartmentId(String departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public String getDepartmentId() {
        return this.departmentId;
    }

}
