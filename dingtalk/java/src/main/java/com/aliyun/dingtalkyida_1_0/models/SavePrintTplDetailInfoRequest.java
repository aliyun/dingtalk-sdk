// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SavePrintTplDetailInfoRequest extends TeaModel {
    /**
     * <p>应用代码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>模板描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>文件名配置</p>
     */
    @NameInMap("fileNameConfig")
    public String fileNameConfig;

    /**
     * <p>表单id</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>表单版本</p>
     */
    @NameInMap("formVersion")
    public Integer formVersion;

    /**
     * <p>模板的其他配置信息</p>
     */
    @NameInMap("setting")
    public String setting;

    /**
     * <p>打印模板id</p>
     */
    @NameInMap("templateId")
    public Long templateId;

    /**
     * <p>模板标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>模板的VM</p>
     */
    @NameInMap("vm")
    public String vm;

    public static SavePrintTplDetailInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SavePrintTplDetailInfoRequest self = new SavePrintTplDetailInfoRequest();
        return TeaModel.build(map, self);
    }

    public SavePrintTplDetailInfoRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
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

    public SavePrintTplDetailInfoRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SavePrintTplDetailInfoRequest setFormVersion(Integer formVersion) {
        this.formVersion = formVersion;
        return this;
    }
    public Integer getFormVersion() {
        return this.formVersion;
    }

    public SavePrintTplDetailInfoRequest setSetting(String setting) {
        this.setting = setting;
        return this;
    }
    public String getSetting() {
        return this.setting;
    }

    public SavePrintTplDetailInfoRequest setTemplateId(Long templateId) {
        this.templateId = templateId;
        return this;
    }
    public Long getTemplateId() {
        return this.templateId;
    }

    public SavePrintTplDetailInfoRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SavePrintTplDetailInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public SavePrintTplDetailInfoRequest setVm(String vm) {
        this.vm = vm;
        return this;
    }
    public String getVm() {
        return this.vm;
    }

}
