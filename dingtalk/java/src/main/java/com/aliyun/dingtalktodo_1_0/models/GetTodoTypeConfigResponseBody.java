// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTypeConfigResponseBody extends TeaModel {
    @NameInMap("actionList")
    public java.util.List<GetTodoTypeConfigResponseBodyActionList> actionList;

    @NameInMap("bizTag")
    public String bizTag;

    @NameInMap("cardType")
    public Integer cardType;

    @NameInMap("contentFieldList")
    public java.util.List<GetTodoTypeConfigResponseBodyContentFieldList> contentFieldList;

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

    public static GetTodoTypeConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTypeConfigResponseBody self = new GetTodoTypeConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTodoTypeConfigResponseBody setActionList(java.util.List<GetTodoTypeConfigResponseBodyActionList> actionList) {
        this.actionList = actionList;
        return this;
    }
    public java.util.List<GetTodoTypeConfigResponseBodyActionList> getActionList() {
        return this.actionList;
    }

    public GetTodoTypeConfigResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public GetTodoTypeConfigResponseBody setCardType(Integer cardType) {
        this.cardType = cardType;
        return this;
    }
    public Integer getCardType() {
        return this.cardType;
    }

    public GetTodoTypeConfigResponseBody setContentFieldList(java.util.List<GetTodoTypeConfigResponseBodyContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<GetTodoTypeConfigResponseBodyContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public GetTodoTypeConfigResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public GetTodoTypeConfigResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public GetTodoTypeConfigResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetTodoTypeConfigResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetTodoTypeConfigResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetTodoTypeConfigResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public GetTodoTypeConfigResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public GetTodoTypeConfigResponseBody setPcDetailUrlOpenMode(String pcDetailUrlOpenMode) {
        this.pcDetailUrlOpenMode = pcDetailUrlOpenMode;
        return this;
    }
    public String getPcDetailUrlOpenMode() {
        return this.pcDetailUrlOpenMode;
    }

    public GetTodoTypeConfigResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetTodoTypeConfigResponseBodyActionList extends TeaModel {
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

        public static GetTodoTypeConfigResponseBodyActionList build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTypeConfigResponseBodyActionList self = new GetTodoTypeConfigResponseBodyActionList();
            return TeaModel.build(map, self);
        }

        public GetTodoTypeConfigResponseBodyActionList setActionKey(String actionKey) {
            this.actionKey = actionKey;
            return this;
        }
        public String getActionKey() {
            return this.actionKey;
        }

        public GetTodoTypeConfigResponseBodyActionList setActionType(Integer actionType) {
            this.actionType = actionType;
            return this;
        }
        public Integer getActionType() {
            return this.actionType;
        }

        public GetTodoTypeConfigResponseBodyActionList setButtonStyleType(Integer buttonStyleType) {
            this.buttonStyleType = buttonStyleType;
            return this;
        }
        public Integer getButtonStyleType() {
            return this.buttonStyleType;
        }

        public GetTodoTypeConfigResponseBodyActionList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

        public GetTodoTypeConfigResponseBodyActionList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetTodoTypeConfigResponseBodyContentFieldList extends TeaModel {
        @NameInMap("fieldKey")
        public String fieldKey;

        @NameInMap("fieldType")
        public String fieldType;

        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        public static GetTodoTypeConfigResponseBodyContentFieldList build(java.util.Map<String, ?> map) throws Exception {
            GetTodoTypeConfigResponseBodyContentFieldList self = new GetTodoTypeConfigResponseBodyContentFieldList();
            return TeaModel.build(map, self);
        }

        public GetTodoTypeConfigResponseBodyContentFieldList setFieldKey(String fieldKey) {
            this.fieldKey = fieldKey;
            return this;
        }
        public String getFieldKey() {
            return this.fieldKey;
        }

        public GetTodoTypeConfigResponseBodyContentFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public GetTodoTypeConfigResponseBodyContentFieldList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

    }

}
