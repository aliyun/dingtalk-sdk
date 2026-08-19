// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateTemplateProcessTaskRequest extends TeaModel {
    @NameInMap("fillData")
    public java.util.List<CreateTemplateProcessTaskRequestFillData> fillData;

    @NameInMap("formId")
    public String formId;

    @NameInMap("mode")
    public String mode;

    public static CreateTemplateProcessTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTemplateProcessTaskRequest self = new CreateTemplateProcessTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateTemplateProcessTaskRequest setFillData(java.util.List<CreateTemplateProcessTaskRequestFillData> fillData) {
        this.fillData = fillData;
        return this;
    }
    public java.util.List<CreateTemplateProcessTaskRequestFillData> getFillData() {
        return this.fillData;
    }

    public CreateTemplateProcessTaskRequest setFormId(String formId) {
        this.formId = formId;
        return this;
    }
    public String getFormId() {
        return this.formId;
    }

    public CreateTemplateProcessTaskRequest setMode(String mode) {
        this.mode = mode;
        return this;
    }
    public String getMode() {
        return this.mode;
    }

    public static class CreateTemplateProcessTaskRequestFillData extends TeaModel {
        @NameInMap("structKey")
        public String structKey;

        @NameInMap("structValue")
        public String structValue;

        public static CreateTemplateProcessTaskRequestFillData build(java.util.Map<String, ?> map) throws Exception {
            CreateTemplateProcessTaskRequestFillData self = new CreateTemplateProcessTaskRequestFillData();
            return TeaModel.build(map, self);
        }

        public CreateTemplateProcessTaskRequestFillData setStructKey(String structKey) {
            this.structKey = structKey;
            return this;
        }
        public String getStructKey() {
            return this.structKey;
        }

        public CreateTemplateProcessTaskRequestFillData setStructValue(String structValue) {
            this.structValue = structValue;
            return this;
        }
        public String getStructValue() {
            return this.structValue;
        }

    }

}
