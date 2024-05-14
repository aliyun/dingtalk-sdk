// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTypeConfigResponseBody extends TeaModel {
    @NameInMap("actionList")
    public java.util.List<CreateTodoTypeConfigResponseBodyActionList> actionList;

    @NameInMap("bizTag")
    public String bizTag;

    @NameInMap("cardType")
    public Integer cardType;

    @NameInMap("contentFieldList")
    public java.util.List<CreateTodoTypeConfigResponseBodyContentFieldList> contentFieldList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("creatorId")
    public String creatorId;

    @NameInMap("description")
    public String description;

    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modifierId")
    public String modifierId;

    @NameInMap("pcDetailUrlOpenMode")
    public String pcDetailUrlOpenMode;

    @NameInMap("requestId")
    public String requestId;

    public static CreateTodoTypeConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTypeConfigResponseBody self = new CreateTodoTypeConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTodoTypeConfigResponseBody setActionList(java.util.List<CreateTodoTypeConfigResponseBodyActionList> actionList) {
        this.actionList = actionList;
        return this;
    }
    public java.util.List<CreateTodoTypeConfigResponseBodyActionList> getActionList() {
        return this.actionList;
    }

    public CreateTodoTypeConfigResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public CreateTodoTypeConfigResponseBody setCardType(Integer cardType) {
        this.cardType = cardType;
        return this;
    }
    public Integer getCardType() {
        return this.cardType;
    }

    public CreateTodoTypeConfigResponseBody setContentFieldList(java.util.List<CreateTodoTypeConfigResponseBodyContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<CreateTodoTypeConfigResponseBodyContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public CreateTodoTypeConfigResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public CreateTodoTypeConfigResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateTodoTypeConfigResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTodoTypeConfigResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateTodoTypeConfigResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateTodoTypeConfigResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public CreateTodoTypeConfigResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public CreateTodoTypeConfigResponseBody setPcDetailUrlOpenMode(String pcDetailUrlOpenMode) {
        this.pcDetailUrlOpenMode = pcDetailUrlOpenMode;
        return this;
    }
    public String getPcDetailUrlOpenMode() {
        return this.pcDetailUrlOpenMode;
    }

    public CreateTodoTypeConfigResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class CreateTodoTypeConfigResponseBodyActionList extends TeaModel {
        @NameInMap("actionKey")
        public String actionKey;

        @NameInMap("actionType")
        public Integer actionType;

        @NameInMap("buttonStyleType")
        public Integer buttonStyleType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        @NameInMap("url")
        public String url;

        public static CreateTodoTypeConfigResponseBodyActionList build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTypeConfigResponseBodyActionList self = new CreateTodoTypeConfigResponseBodyActionList();
            return TeaModel.build(map, self);
        }

        public CreateTodoTypeConfigResponseBodyActionList setActionKey(String actionKey) {
            this.actionKey = actionKey;
            return this;
        }
        public String getActionKey() {
            return this.actionKey;
        }

        public CreateTodoTypeConfigResponseBodyActionList setActionType(Integer actionType) {
            this.actionType = actionType;
            return this;
        }
        public Integer getActionType() {
            return this.actionType;
        }

        public CreateTodoTypeConfigResponseBodyActionList setButtonStyleType(Integer buttonStyleType) {
            this.buttonStyleType = buttonStyleType;
            return this;
        }
        public Integer getButtonStyleType() {
            return this.buttonStyleType;
        }

        public CreateTodoTypeConfigResponseBodyActionList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

        public CreateTodoTypeConfigResponseBodyActionList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class CreateTodoTypeConfigResponseBodyContentFieldList extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        public static CreateTodoTypeConfigResponseBodyContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            CreateTodoTypeConfigResponseBodyContentFieldList self = new CreateTodoTypeConfigResponseBodyContentFieldList();
            return TeaModel.build(map, self);
        }

        public CreateTodoTypeConfigResponseBodyContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public CreateTodoTypeConfigResponseBodyContentFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public CreateTodoTypeConfigResponseBodyContentFieldList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

    }

}
