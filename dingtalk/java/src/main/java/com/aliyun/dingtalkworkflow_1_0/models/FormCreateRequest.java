// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class FormCreateRequest extends TeaModel {
    /**
     * <p>表单模板描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>表单控件列表</p>
     */
    @NameInMap("formComponents")
    public java.util.List<FormComponent> formComponents;

    /**
     * <p>表单模板名称</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>模板配置信息</p>
     */
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
        /**
         * <p>更新后模板目录id</p>
         */
        @NameInMap("dirId")
        public String dirId;

        /**
         * <p>禁用模板删除按钮</p>
         */
        @NameInMap("disableDeleteProcess")
        public Boolean disableDeleteProcess;

        /**
         * <p>禁用表单编辑</p>
         */
        @NameInMap("disableFormEdit")
        public Boolean disableFormEdit;

        /**
         * <p>首页工作台是否可见</p>
         */
        @NameInMap("disableHomepage")
        public Boolean disableHomepage;

        /**
         * <p>禁用再次提交</p>
         */
        @NameInMap("disableResubmit")
        public Boolean disableResubmit;

        /**
         * <p>禁用停止按钮</p>
         */
        @NameInMap("disableStopProcessButton")
        public Boolean disableStopProcessButton;

        /**
         * <p>审批场景内隐藏模板</p>
         */
        @NameInMap("hidden")
        public Boolean hidden;

        /**
         * <p>源模板目录id</p>
         */
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
