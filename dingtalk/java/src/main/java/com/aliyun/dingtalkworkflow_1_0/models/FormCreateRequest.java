// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormCreateRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("RequestId")
    public String requestId;

    @NameInMap("processCode")
    public String processCode;

    // 表单模板名称
    @NameInMap("name")
    public String name;

    // 表单模板描述
    @NameInMap("description")
    public String description;

    // 表单控件列表
    @NameInMap("formComponents")
    public java.util.List<FormComponent> formComponents;

    // 模板配置信息
    @NameInMap("templateConfig")
    public FormCreateRequestTemplateConfig templateConfig;

    public static FormCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        FormCreateRequest self = new FormCreateRequest();
        return TeaModel.build(map, self);
    }

    public FormCreateRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public FormCreateRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public FormCreateRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public FormCreateRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public FormCreateRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public FormCreateRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public FormCreateRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public FormCreateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public FormCreateRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public FormCreateRequest setFormComponents(java.util.List<FormComponent> formComponents) {
        this.formComponents = formComponents;
        return this;
    }
    public java.util.List<FormComponent> getFormComponents() {
        return this.formComponents;
    }

    public FormCreateRequest setTemplateConfig(FormCreateRequestTemplateConfig templateConfig) {
        this.templateConfig = templateConfig;
        return this;
    }
    public FormCreateRequestTemplateConfig getTemplateConfig() {
        return this.templateConfig;
    }

    public static class FormCreateRequestTemplateConfig extends TeaModel {
        // 禁用停止按钮
        @NameInMap("disableStopProcessButton")
        public Boolean disableStopProcessButton;

        // 审批场景内隐藏模板
        @NameInMap("hidden")
        public Boolean hidden;

        // 禁用模板删除按钮
        @NameInMap("disableDeleteProcess")
        public Boolean disableDeleteProcess;

        // 禁用表单编辑
        @NameInMap("disableFormEdit")
        public Boolean disableFormEdit;

        // 禁用再次提交
        @NameInMap("disableResubmit")
        public Boolean disableResubmit;

        // 首页工作台是否可见
        @NameInMap("disableHomepage")
        public Boolean disableHomepage;

        // 更新后模板目录id
        @NameInMap("dirId")
        public String dirId;

        // 源模板目录id
        @NameInMap("originDirId")
        public String originDirId;

        public static FormCreateRequestTemplateConfig build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestTemplateConfig self = new FormCreateRequestTemplateConfig();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestTemplateConfig setDisableStopProcessButton(Boolean disableStopProcessButton) {
            this.disableStopProcessButton = disableStopProcessButton;
            return this;
        }
        public Boolean getDisableStopProcessButton() {
            return this.disableStopProcessButton;
        }

        public FormCreateRequestTemplateConfig setHidden(Boolean hidden) {
            this.hidden = hidden;
            return this;
        }
        public Boolean getHidden() {
            return this.hidden;
        }

        public FormCreateRequestTemplateConfig setDisableDeleteProcess(Boolean disableDeleteProcess) {
            this.disableDeleteProcess = disableDeleteProcess;
            return this;
        }
        public Boolean getDisableDeleteProcess() {
            return this.disableDeleteProcess;
        }

        public FormCreateRequestTemplateConfig setDisableFormEdit(Boolean disableFormEdit) {
            this.disableFormEdit = disableFormEdit;
            return this;
        }
        public Boolean getDisableFormEdit() {
            return this.disableFormEdit;
        }

        public FormCreateRequestTemplateConfig setDisableResubmit(Boolean disableResubmit) {
            this.disableResubmit = disableResubmit;
            return this;
        }
        public Boolean getDisableResubmit() {
            return this.disableResubmit;
        }

        public FormCreateRequestTemplateConfig setDisableHomepage(Boolean disableHomepage) {
            this.disableHomepage = disableHomepage;
            return this;
        }
        public Boolean getDisableHomepage() {
            return this.disableHomepage;
        }

        public FormCreateRequestTemplateConfig setDirId(String dirId) {
            this.dirId = dirId;
            return this;
        }
        public String getDirId() {
            return this.dirId;
        }

        public FormCreateRequestTemplateConfig setOriginDirId(String originDirId) {
            this.originDirId = originDirId;
            return this;
        }
        public String getOriginDirId() {
            return this.originDirId;
        }

    }

}