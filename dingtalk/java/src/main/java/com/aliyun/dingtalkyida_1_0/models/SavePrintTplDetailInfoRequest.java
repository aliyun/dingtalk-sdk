// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SavePrintTplDetailInfoRequest extends TeaModel {
    // 表单id
    @NameInMap("formUuid")
    public String formUuid;

    // 应用代码
    @NameInMap("appType")
    public String appType;

    // 模板的VM
    @NameInMap("vm")
    public String vm;

    // 表单版本
    @NameInMap("formVersion")
    public Integer formVersion;

    // 打印模板id
    @NameInMap("templateId")
    public Long templateId;

    // 用户id
    @NameInMap("userId")
    public String userId;

    // 模板的其他配置信息
    @NameInMap("setting")
    public String setting;

    // 模板标题
    @NameInMap("title")
    public String title;

    // 模板描述
    @NameInMap("description")
    public String description;

    // 文件名配置
    @NameInMap("fileNameConfig")
    public String fileNameConfig;

    public static SavePrintTplDetailInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SavePrintTplDetailInfoRequest self = new SavePrintTplDetailInfoRequest();
        return TeaModel.build(map, self);
    }

    public SavePrintTplDetailInfoRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SavePrintTplDetailInfoRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public SavePrintTplDetailInfoRequest setVm(String vm) {
        this.vm = vm;
        return this;
    }
    public String getVm() {
        return this.vm;
    }

    public SavePrintTplDetailInfoRequest setFormVersion(Integer formVersion) {
        this.formVersion = formVersion;
        return this;
    }
    public Integer getFormVersion() {
        return this.formVersion;
    }

    public SavePrintTplDetailInfoRequest setTemplateId(Long templateId) {
        this.templateId = templateId;
        return this;
    }
    public Long getTemplateId() {
        return this.templateId;
    }

    public SavePrintTplDetailInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public SavePrintTplDetailInfoRequest setSetting(String setting) {
        this.setting = setting;
        return this;
    }
    public String getSetting() {
        return this.setting;
    }

    public SavePrintTplDetailInfoRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SavePrintTplDetailInfoRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public SavePrintTplDetailInfoRequest setFileNameConfig(String fileNameConfig) {
        this.fileNameConfig = fileNameConfig;
        return this;
    }
    public String getFileNameConfig() {
        return this.fileNameConfig;
    }

}
