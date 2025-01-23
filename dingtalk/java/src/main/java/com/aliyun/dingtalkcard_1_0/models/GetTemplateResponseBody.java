// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateResponseBody extends TeaModel {
    @NameInMap("data")
    public GetTemplateResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static GetTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTemplateResponseBody self = new GetTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTemplateResponseBody setData(GetTemplateResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetTemplateResponseBodyData getData() {
        return this.data;
    }

    public GetTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetTemplateResponseBodyData extends TeaModel {
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

        public static GetTemplateResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetTemplateResponseBodyData self = new GetTemplateResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetTemplateResponseBodyData setCommonVariableList(Object commonVariableList) {
            this.commonVariableList = commonVariableList;
            return this;
        }
        public Object getCommonVariableList() {
            return this.commonVariableList;
        }

        public GetTemplateResponseBodyData setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetTemplateResponseBodyData setExpVariableList(Object expVariableList) {
            this.expVariableList = expVariableList;
            return this;
        }
        public Object getExpVariableList() {
            return this.expVariableList;
        }

        public GetTemplateResponseBodyData setExtendType(String extendType) {
            this.extendType = extendType;
            return this;
        }
        public String getExtendType() {
            return this.extendType;
        }

        public GetTemplateResponseBodyData setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetTemplateResponseBodyData setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public GetTemplateResponseBodyData setLocalVariableList(Object localVariableList) {
            this.localVariableList = localVariableList;
            return this;
        }
        public Object getLocalVariableList() {
            return this.localVariableList;
        }

        public GetTemplateResponseBodyData setMiniAppId(String miniAppId) {
            this.miniAppId = miniAppId;
            return this;
        }
        public String getMiniAppId() {
            return this.miniAppId;
        }

        public GetTemplateResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTemplateResponseBodyData setPreview(String preview) {
            this.preview = preview;
            return this;
        }
        public String getPreview() {
            return this.preview;
        }

        public GetTemplateResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetTemplateResponseBodyData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public GetTemplateResponseBodyData setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
