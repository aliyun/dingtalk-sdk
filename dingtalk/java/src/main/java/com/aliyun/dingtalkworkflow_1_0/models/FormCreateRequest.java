// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormCreateRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formComponents")
    public java.util.List<FormComponent> formComponents;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("processCode")
    public String processCode;

    @NameInMap("templateConfig")
    public FormCreateRequestTemplateConfig templateConfig;

    public static FormCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        FormCreateRequest self = new FormCreateRequest();
        return TeaModel.build(map, self);
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

    public FormCreateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public FormCreateRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public FormCreateRequest setTemplateConfig(FormCreateRequestTemplateConfig templateConfig) {
        this.templateConfig = templateConfig;
        return this;
    }
    public FormCreateRequestTemplateConfig getTemplateConfig() {
        return this.templateConfig;
    }

    public static class FormCreateRequestTemplateConfig extends TeaModel {
        @NameInMap("dirId")
        public String dirId;

        @NameInMap("disableDeleteProcess")
        public Boolean disableDeleteProcess;

        @NameInMap("disableFormEdit")
        public Boolean disableFormEdit;

        @NameInMap("disableHomepage")
        public Boolean disableHomepage;

        @NameInMap("disableResubmit")
        public Boolean disableResubmit;

        @NameInMap("disableStopProcessButton")
        public Boolean disableStopProcessButton;

        @NameInMap("hidden")
        public Boolean hidden;

        @NameInMap("originDirId")
        public String originDirId;

        public static FormCreateRequestTemplateConfig build(java.util.Map<String, ?> map) throws Exception {
            FormCreateRequestTemplateConfig self = new FormCreateRequestTemplateConfig();
            return TeaModel.build(map, self);
        }

        public FormCreateRequestTemplateConfig setDirId(String dirId) {
            this.dirId = dirId;
            return this;
        }
        public String getDirId() {
            return this.dirId;
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

        public FormCreateRequestTemplateConfig setDisableHomepage(Boolean disableHomepage) {
            this.disableHomepage = disableHomepage;
            return this;
        }
        public Boolean getDisableHomepage() {
            return this.disableHomepage;
        }

        public FormCreateRequestTemplateConfig setDisableResubmit(Boolean disableResubmit) {
            this.disableResubmit = disableResubmit;
            return this;
        }
        public Boolean getDisableResubmit() {
            return this.disableResubmit;
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

        public FormCreateRequestTemplateConfig setOriginDirId(String originDirId) {
            this.originDirId = originDirId;
            return this;
        }
        public String getOriginDirId() {
            return this.originDirId;
        }

    }

}
