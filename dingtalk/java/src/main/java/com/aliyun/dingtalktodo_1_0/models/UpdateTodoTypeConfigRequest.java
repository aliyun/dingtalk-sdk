// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTypeConfigRequest extends TeaModel {
    @NameInMap("actionList")
    public java.util.List<UpdateTodoTypeConfigRequestActionList> actionList;

    @NameInMap("cardType")
    public Integer cardType;

    @NameInMap("contentFieldList")
    public java.util.List<UpdateTodoTypeConfigRequestContentFieldList> contentFieldList;

    @NameInMap("description")
    public String description;

    @NameInMap("icon")
    public String icon;

    @NameInMap("pcDetailUrlOpenMode")
    public String pcDetailUrlOpenMode;

    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateTodoTypeConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTypeConfigRequest self = new UpdateTodoTypeConfigRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTypeConfigRequest setActionList(java.util.List<UpdateTodoTypeConfigRequestActionList> actionList) {
        this.actionList = actionList;
        return this;
    }
    public java.util.List<UpdateTodoTypeConfigRequestActionList> getActionList() {
        return this.actionList;
    }

    public UpdateTodoTypeConfigRequest setCardType(Integer cardType) {
        this.cardType = cardType;
        return this;
    }
    public Integer getCardType() {
        return this.cardType;
    }

    public UpdateTodoTypeConfigRequest setContentFieldList(java.util.List<UpdateTodoTypeConfigRequestContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<UpdateTodoTypeConfigRequestContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public UpdateTodoTypeConfigRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateTodoTypeConfigRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateTodoTypeConfigRequest setPcDetailUrlOpenMode(String pcDetailUrlOpenMode) {
        this.pcDetailUrlOpenMode = pcDetailUrlOpenMode;
        return this;
    }
    public String getPcDetailUrlOpenMode() {
        return this.pcDetailUrlOpenMode;
    }

    public UpdateTodoTypeConfigRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateTodoTypeConfigRequestActionList extends TeaModel {
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

        public static UpdateTodoTypeConfigRequestActionList build(java.util.Map<String, ?> map) throws Exception {
            UpdateTodoTypeConfigRequestActionList self = new UpdateTodoTypeConfigRequestActionList();
            return TeaModel.build(map, self);
        }

        public UpdateTodoTypeConfigRequestActionList setActionKey(String actionKey) {
            this.actionKey = actionKey;
            return this;
        }
        public String getActionKey() {
            return this.actionKey;
        }

        public UpdateTodoTypeConfigRequestActionList setActionType(Integer actionType) {
            this.actionType = actionType;
            return this;
        }
        public Integer getActionType() {
            return this.actionType;
        }

        public UpdateTodoTypeConfigRequestActionList setButtonStyleType(Integer buttonStyleType) {
            this.buttonStyleType = buttonStyleType;
            return this;
        }
        public Integer getButtonStyleType() {
            return this.buttonStyleType;
        }

        public UpdateTodoTypeConfigRequestActionList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

        public UpdateTodoTypeConfigRequestActionList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class UpdateTodoTypeConfigRequestContentFieldList extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        public static UpdateTodoTypeConfigRequestContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            UpdateTodoTypeConfigRequestContentFieldList self = new UpdateTodoTypeConfigRequestContentFieldList();
            return TeaModel.build(map, self);
        }

        public UpdateTodoTypeConfigRequestContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public UpdateTodoTypeConfigRequestContentFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public UpdateTodoTypeConfigRequestContentFieldList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

    }

}
