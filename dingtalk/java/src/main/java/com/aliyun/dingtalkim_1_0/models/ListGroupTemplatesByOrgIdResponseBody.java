// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListGroupTemplatesByOrgIdResponseBody extends TeaModel {
    @NameInMap("count")
    public Integer count;

    @NameInMap("sceneGroupDetailModels")
    public java.util.List<ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels> sceneGroupDetailModels;

    @NameInMap("success")
    public Boolean success;

    public static ListGroupTemplatesByOrgIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListGroupTemplatesByOrgIdResponseBody self = new ListGroupTemplatesByOrgIdResponseBody();
        return TeaModel.build(map, self);
    }

    public ListGroupTemplatesByOrgIdResponseBody setCount(Integer count) {
        this.count = count;
        return this;
    }
    public Integer getCount() {
        return this.count;
    }

    public ListGroupTemplatesByOrgIdResponseBody setSceneGroupDetailModels(java.util.List<ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels> sceneGroupDetailModels) {
        this.sceneGroupDetailModels = sceneGroupDetailModels;
        return this;
    }
    public java.util.List<ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels> getSceneGroupDetailModels() {
        return this.sceneGroupDetailModels;
    }

    public ListGroupTemplatesByOrgIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("icon")
        public String icon;

        @NameInMap("msgOpen")
        public Boolean msgOpen;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("templateName")
        public String templateName;

        public static ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels build(java.util.Map<String, ?> map) throws Exception {
            ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels self = new ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels();
            return TeaModel.build(map, self);
        }

        public ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels setMsgOpen(Boolean msgOpen) {
            this.msgOpen = msgOpen;
            return this;
        }
        public Boolean getMsgOpen() {
            return this.msgOpen;
        }

        public ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public ListGroupTemplatesByOrgIdResponseBodySceneGroupDetailModels setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

    }

}
