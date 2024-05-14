// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTypeConfigRequest extends TeaModel {
    @NameInMap("actionList")
    public java.util.List<CreateTodoTypeConfigRequestActionList> actionList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardType")
    public Integer cardType;

    @NameInMap("contentFieldList")
    public java.util.List<CreateTodoTypeConfigRequestContentFieldList> contentFieldList;

    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pcDetailUrlOpenMode")
    public String pcDetailUrlOpenMode;

    @NameInMap("operatorId")
    public String operatorId;

    public static CreateTodoTypeConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTypeConfigRequest self = new CreateTodoTypeConfigRequest();
        return TeaModel.build(map, self);
    }

    public CreateTodoTypeConfigRequest setActionList(java.util.List<CreateTodoTypeConfigRequestActionList> actionList) {
        this.actionList = actionList;
        return this;
    }
    public java.util.List<CreateTodoTypeConfigRequestActionList> getActionList() {
        return this.actionList;
    }

    public CreateTodoTypeConfigRequest setCardType(Integer cardType) {
        this.cardType = cardType;
        return this;
    }
    public Integer getCardType() {
        return this.cardType;
    }

    public CreateTodoTypeConfigRequest setContentFieldList(java.util.List<CreateTodoTypeConfigRequestContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<CreateTodoTypeConfigRequestContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public CreateTodoTypeConfigRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTodoTypeConfigRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateTodoTypeConfigRequest setPcDetailUrlOpenMode(String pcDetailUrlOpenMode) {
        this.pcDetailUrlOpenMode = pcDetailUrlOpenMode;
        return this;
    }
    public String getPcDetailUrlOpenMode() {
        return this.pcDetailUrlOpenMode;
    }

    public CreateTodoTypeConfigRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateTodoTypeConfigRequestActionList extends TeaModel {
        @NameInMap("actionKey")
        public String actionKey;

        @NameInMap("actionType")
        public Integer actionType;

        @NameInMap("buttonStyleType")
        public Integer buttonStyleType;

        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        @NameInMap("url")
        public String url;

        public static CreateTodoTypeConfigRequestActionList build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTypeConfigRequestActionList self = new CreateTodoTypeConfigRequestActionList();
            return TeaModel.build(map, self);
        }

        public CreateTodoTypeConfigRequestActionList setActionKey(String actionKey) {
            this.actionKey = actionKey;
            return this;
        }
        public String getActionKey() {
            return this.actionKey;
        }

        public CreateTodoTypeConfigRequestActionList setActionType(Integer actionType) {
            this.actionType = actionType;
            return this;
        }
        public Integer getActionType() {
            return this.actionType;
        }

        public CreateTodoTypeConfigRequestActionList setButtonStyleType(Integer buttonStyleType) {
            this.buttonStyleType = buttonStyleType;
            return this;
        }
        public Integer getButtonStyleType() {
            return this.buttonStyleType;
        }

        public CreateTodoTypeConfigRequestActionList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

        public CreateTodoTypeConfigRequestActionList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class CreateTodoTypeConfigRequestContentFieldList extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        public static CreateTodoTypeConfigRequestContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTypeConfigRequestContentFieldList self = new CreateTodoTypeConfigRequestContentFieldList();
            return TeaModel.build(map, self);
        }

        public CreateTodoTypeConfigRequestContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public CreateTodoTypeConfigRequestContentFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public CreateTodoTypeConfigRequestContentFieldList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

    }

}
