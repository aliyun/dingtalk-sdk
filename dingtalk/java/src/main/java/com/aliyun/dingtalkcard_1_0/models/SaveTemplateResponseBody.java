// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class SaveTemplateResponseBody extends TeaModel {
    @NameInMap("data")
    public SaveTemplateResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static SaveTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveTemplateResponseBody self = new SaveTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveTemplateResponseBody setData(SaveTemplateResponseBodyData data) {
        this.data = data;
        return this;
    }
    public SaveTemplateResponseBodyData getData() {
        return this.data;
    }

    public SaveTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SaveTemplateResponseBodyData extends TeaModel {
        @NameInMap("blockTemplate")
        public Boolean blockTemplate;

        @NameInMap("commonVariableList")
        public Object commonVariableList;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("expVariableList")
        public Object expVariableList;

        @NameInMap("extendType")
        public String extendType;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("localVariableList")
        public Object localVariableList;

        @NameInMap("miniAppId")
        public String miniAppId;

        @NameInMap("name")
        public String name;

        @NameInMap("preview")
        public String preview;

        @NameInMap("status")
        public String status;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("type")
        public String type;

        public static SaveTemplateResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            SaveTemplateResponseBodyData self = new SaveTemplateResponseBodyData();
            return TeaModel.build(map, self);
        }

        public SaveTemplateResponseBodyData setBlockTemplate(Boolean blockTemplate) {
            this.blockTemplate = blockTemplate;
            return this;
        }
        public Boolean getBlockTemplate() {
            return this.blockTemplate;
        }

        public SaveTemplateResponseBodyData setCommonVariableList(Object commonVariableList) {
            this.commonVariableList = commonVariableList;
            return this;
        }
        public Object getCommonVariableList() {
            return this.commonVariableList;
        }

        public SaveTemplateResponseBodyData setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SaveTemplateResponseBodyData setExpVariableList(Object expVariableList) {
            this.expVariableList = expVariableList;
            return this;
        }
        public Object getExpVariableList() {
            return this.expVariableList;
        }

        public SaveTemplateResponseBodyData setExtendType(String extendType) {
            this.extendType = extendType;
            return this;
        }
        public String getExtendType() {
            return this.extendType;
        }

        public SaveTemplateResponseBodyData setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public SaveTemplateResponseBodyData setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public SaveTemplateResponseBodyData setLocalVariableList(Object localVariableList) {
            this.localVariableList = localVariableList;
            return this;
        }
        public Object getLocalVariableList() {
            return this.localVariableList;
        }

        public SaveTemplateResponseBodyData setMiniAppId(String miniAppId) {
            this.miniAppId = miniAppId;
            return this;
        }
        public String getMiniAppId() {
            return this.miniAppId;
        }

        public SaveTemplateResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveTemplateResponseBodyData setPreview(String preview) {
            this.preview = preview;
            return this;
        }
        public String getPreview() {
            return this.preview;
        }

        public SaveTemplateResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public SaveTemplateResponseBodyData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public SaveTemplateResponseBodyData setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
