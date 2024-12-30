// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class CreateStandardTemplateRequest extends TeaModel {
    @NameInMap("actions")
    public java.util.List<CreateStandardTemplateRequestActions> actions;

    @NameInMap("description")
    public String description;

    @NameInMap("name")
    public String name;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("service")
    public CreateStandardTemplateRequestService service;

    public static CreateStandardTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateStandardTemplateRequest self = new CreateStandardTemplateRequest();
        return TeaModel.build(map, self);
    }

    public CreateStandardTemplateRequest setActions(java.util.List<CreateStandardTemplateRequestActions> actions) {
        this.actions = actions;
        return this;
    }
    public java.util.List<CreateStandardTemplateRequestActions> getActions() {
        return this.actions;
    }

    public CreateStandardTemplateRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateStandardTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateStandardTemplateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateStandardTemplateRequest setService(CreateStandardTemplateRequestService service) {
        this.service = service;
        return this;
    }
    public CreateStandardTemplateRequestService getService() {
        return this.service;
    }

    public static class CreateStandardTemplateRequestActions extends TeaModel {
        @NameInMap("actionGroup")
        public String actionGroup;

        @NameInMap("name")
        public String name;

        @NameInMap("needReason")
        public Boolean needReason;

        @NameInMap("needReasonRequired")
        public Boolean needReasonRequired;

        @NameInMap("order")
        public Long order;

        @NameInMap("styleType")
        public Long styleType;

        public static CreateStandardTemplateRequestActions build(java.util.Map<String, ?> map) throws Exception {
            CreateStandardTemplateRequestActions self = new CreateStandardTemplateRequestActions();
            return TeaModel.build(map, self);
        }

        public CreateStandardTemplateRequestActions setActionGroup(String actionGroup) {
            this.actionGroup = actionGroup;
            return this;
        }
        public String getActionGroup() {
            return this.actionGroup;
        }

        public CreateStandardTemplateRequestActions setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateStandardTemplateRequestActions setNeedReason(Boolean needReason) {
            this.needReason = needReason;
            return this;
        }
        public Boolean getNeedReason() {
            return this.needReason;
        }

        public CreateStandardTemplateRequestActions setNeedReasonRequired(Boolean needReasonRequired) {
            this.needReasonRequired = needReasonRequired;
            return this;
        }
        public Boolean getNeedReasonRequired() {
            return this.needReasonRequired;
        }

        public CreateStandardTemplateRequestActions setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public CreateStandardTemplateRequestActions setStyleType(Long styleType) {
            this.styleType = styleType;
            return this;
        }
        public Long getStyleType() {
            return this.styleType;
        }

    }

    public static class CreateStandardTemplateRequestService extends TeaModel {
        @NameInMap("callbackUrl")
        public String callbackUrl;

        public static CreateStandardTemplateRequestService build(java.util.Map<String, ?> map) throws Exception {
            CreateStandardTemplateRequestService self = new CreateStandardTemplateRequestService();
            return TeaModel.build(map, self);
        }

        public CreateStandardTemplateRequestService setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

    }

}
