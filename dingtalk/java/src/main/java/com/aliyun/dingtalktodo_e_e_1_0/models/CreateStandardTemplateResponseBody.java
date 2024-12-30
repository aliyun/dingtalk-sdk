// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class CreateStandardTemplateResponseBody extends TeaModel {
    @NameInMap("actions")
    public java.util.List<CreateStandardTemplateResponseBodyActions> actions;

    @NameInMap("description")
    public String description;

    @NameInMap("name")
    public String name;

    @NameInMap("templateKey")
    public String templateKey;

    public static CreateStandardTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateStandardTemplateResponseBody self = new CreateStandardTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateStandardTemplateResponseBody setActions(java.util.List<CreateStandardTemplateResponseBodyActions> actions) {
        this.actions = actions;
        return this;
    }
    public java.util.List<CreateStandardTemplateResponseBodyActions> getActions() {
        return this.actions;
    }

    public CreateStandardTemplateResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateStandardTemplateResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateStandardTemplateResponseBody setTemplateKey(String templateKey) {
        this.templateKey = templateKey;
        return this;
    }
    public String getTemplateKey() {
        return this.templateKey;
    }

    public static class CreateStandardTemplateResponseBodyActions extends TeaModel {
        @NameInMap("actionKey")
        public String actionKey;

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

        public static CreateStandardTemplateResponseBodyActions build(java.util.Map<String, ?> map) throws Exception {
            CreateStandardTemplateResponseBodyActions self = new CreateStandardTemplateResponseBodyActions();
            return TeaModel.build(map, self);
        }

        public CreateStandardTemplateResponseBodyActions setActionKey(String actionKey) {
            this.actionKey = actionKey;
            return this;
        }
        public String getActionKey() {
            return this.actionKey;
        }

        public CreateStandardTemplateResponseBodyActions setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateStandardTemplateResponseBodyActions setNeedReason(Boolean needReason) {
            this.needReason = needReason;
            return this;
        }
        public Boolean getNeedReason() {
            return this.needReason;
        }

        public CreateStandardTemplateResponseBodyActions setNeedReasonRequired(Boolean needReasonRequired) {
            this.needReasonRequired = needReasonRequired;
            return this;
        }
        public Boolean getNeedReasonRequired() {
            return this.needReasonRequired;
        }

        public CreateStandardTemplateResponseBodyActions setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public CreateStandardTemplateResponseBodyActions setStyleType(Long styleType) {
            this.styleType = styleType;
            return this;
        }
        public Long getStyleType() {
            return this.styleType;
        }

    }

}
