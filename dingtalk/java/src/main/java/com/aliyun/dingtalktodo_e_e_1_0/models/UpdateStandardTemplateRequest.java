// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateStandardTemplateRequest extends TeaModel {
    @NameInMap("actions")
    public java.util.List<UpdateStandardTemplateRequestActions> actions;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("service")
    public UpdateStandardTemplateRequestService service;

    @NameInMap("templateKey")
    public String templateKey;

    public static UpdateStandardTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateStandardTemplateRequest self = new UpdateStandardTemplateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateStandardTemplateRequest setActions(java.util.List<UpdateStandardTemplateRequestActions> actions) {
        this.actions = actions;
        return this;
    }
    public java.util.List<UpdateStandardTemplateRequestActions> getActions() {
        return this.actions;
    }

    public UpdateStandardTemplateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public UpdateStandardTemplateRequest setService(UpdateStandardTemplateRequestService service) {
        this.service = service;
        return this;
    }
    public UpdateStandardTemplateRequestService getService() {
        return this.service;
    }

    public UpdateStandardTemplateRequest setTemplateKey(String templateKey) {
        this.templateKey = templateKey;
        return this;
    }
    public String getTemplateKey() {
        return this.templateKey;
    }

    public static class UpdateStandardTemplateRequestActions extends TeaModel {
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

        public static UpdateStandardTemplateRequestActions build(java.util.Map<String, ?> map) throws Exception {
            UpdateStandardTemplateRequestActions self = new UpdateStandardTemplateRequestActions();
            return TeaModel.build(map, self);
        }

        public UpdateStandardTemplateRequestActions setActionGroup(String actionGroup) {
            this.actionGroup = actionGroup;
            return this;
        }
        public String getActionGroup() {
            return this.actionGroup;
        }

        public UpdateStandardTemplateRequestActions setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateStandardTemplateRequestActions setNeedReason(Boolean needReason) {
            this.needReason = needReason;
            return this;
        }
        public Boolean getNeedReason() {
            return this.needReason;
        }

        public UpdateStandardTemplateRequestActions setNeedReasonRequired(Boolean needReasonRequired) {
            this.needReasonRequired = needReasonRequired;
            return this;
        }
        public Boolean getNeedReasonRequired() {
            return this.needReasonRequired;
        }

        public UpdateStandardTemplateRequestActions setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public UpdateStandardTemplateRequestActions setStyleType(Long styleType) {
            this.styleType = styleType;
            return this;
        }
        public Long getStyleType() {
            return this.styleType;
        }

    }

    public static class UpdateStandardTemplateRequestService extends TeaModel {
        @NameInMap("callbackUrl")
        public String callbackUrl;

        public static UpdateStandardTemplateRequestService build(java.util.Map<String, ?> map) throws Exception {
            UpdateStandardTemplateRequestService self = new UpdateStandardTemplateRequestService();
            return TeaModel.build(map, self);
        }

        public UpdateStandardTemplateRequestService setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

    }

}
