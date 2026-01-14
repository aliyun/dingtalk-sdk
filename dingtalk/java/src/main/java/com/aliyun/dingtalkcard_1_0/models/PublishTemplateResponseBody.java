// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class PublishTemplateResponseBody extends TeaModel {
    @NameInMap("data")
    public PublishTemplateResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static PublishTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PublishTemplateResponseBody self = new PublishTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public PublishTemplateResponseBody setData(PublishTemplateResponseBodyData data) {
        this.data = data;
        return this;
    }
    public PublishTemplateResponseBodyData getData() {
        return this.data;
    }

    public PublishTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PublishTemplateResponseBodyData extends TeaModel {
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

        public static PublishTemplateResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            PublishTemplateResponseBodyData self = new PublishTemplateResponseBodyData();
            return TeaModel.build(map, self);
        }

        public PublishTemplateResponseBodyData setBlockTemplate(Boolean blockTemplate) {
            this.blockTemplate = blockTemplate;
            return this;
        }
        public Boolean getBlockTemplate() {
            return this.blockTemplate;
        }

        public PublishTemplateResponseBodyData setCommonVariableList(Object commonVariableList) {
            this.commonVariableList = commonVariableList;
            return this;
        }
        public Object getCommonVariableList() {
            return this.commonVariableList;
        }

        public PublishTemplateResponseBodyData setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public PublishTemplateResponseBodyData setExpVariableList(Object expVariableList) {
            this.expVariableList = expVariableList;
            return this;
        }
        public Object getExpVariableList() {
            return this.expVariableList;
        }

        public PublishTemplateResponseBodyData setExtendType(String extendType) {
            this.extendType = extendType;
            return this;
        }
        public String getExtendType() {
            return this.extendType;
        }

        public PublishTemplateResponseBodyData setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public PublishTemplateResponseBodyData setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public PublishTemplateResponseBodyData setLocalVariableList(Object localVariableList) {
            this.localVariableList = localVariableList;
            return this;
        }
        public Object getLocalVariableList() {
            return this.localVariableList;
        }

        public PublishTemplateResponseBodyData setMiniAppId(String miniAppId) {
            this.miniAppId = miniAppId;
            return this;
        }
        public String getMiniAppId() {
            return this.miniAppId;
        }

        public PublishTemplateResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PublishTemplateResponseBodyData setPreview(String preview) {
            this.preview = preview;
            return this;
        }
        public String getPreview() {
            return this.preview;
        }

        public PublishTemplateResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public PublishTemplateResponseBodyData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public PublishTemplateResponseBodyData setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
