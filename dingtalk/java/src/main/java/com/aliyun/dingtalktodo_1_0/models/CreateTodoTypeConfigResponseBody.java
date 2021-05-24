// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTypeConfigResponseBody extends TeaModel {
    // id
    @NameInMap("id")
    public String id;

    // 创建时间
    @NameInMap("createdTime")
    public Long createdTime;

    // 更新时间
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    // 创建者（用户的unionId）
    @NameInMap("creatorId")
    public String creatorId;

    // 更新者（用户的unionId）
    @NameInMap("modifierId")
    public String modifierId;

    // 接入应用标识
    @NameInMap("bizTag")
    public String bizTag;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    // 卡片类型（取值为：1-标准卡片，2-自定义卡片）
    @NameInMap("cardType")
    public Integer cardType;

    // 卡片类型icon，用于在待办列表展示
    @NameInMap("icon")
    public String icon;

    // 待办卡片类型描述
    @NameInMap("description")
    public String description;

    // 详情页链接在PC端的打开方式，取值为：「PC_SLIDE」-PC端侧边栏打开，「PC_BROWSER」-浏览器打开
    @NameInMap("pcDetailUrlOpenMode")
    public String pcDetailUrlOpenMode;

    // 待办卡片内容区表单自定义字段配置
    @NameInMap("contentFieldList")
    public java.util.List<CreateTodoTypeConfigResponseBodyContentFieldList> contentFieldList;

    // 待办卡片操作区按钮配置
    @NameInMap("actionList")
    public java.util.List<CreateTodoTypeConfigResponseBodyActionList> actionList;

    public static CreateTodoTypeConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTypeConfigResponseBody self = new CreateTodoTypeConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTodoTypeConfigResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateTodoTypeConfigResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public CreateTodoTypeConfigResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public CreateTodoTypeConfigResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateTodoTypeConfigResponseBody setModifierId(String modifierId) {
        this.modifierId = modifierId;
        return this;
    }
    public String getModifierId() {
        return this.modifierId;
    }

    public CreateTodoTypeConfigResponseBody setBizTag(String bizTag) {
        this.bizTag = bizTag;
        return this;
    }
    public String getBizTag() {
        return this.bizTag;
    }

    public CreateTodoTypeConfigResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateTodoTypeConfigResponseBody setCardType(Integer cardType) {
        this.cardType = cardType;
        return this;
    }
    public Integer getCardType() {
        return this.cardType;
    }

    public CreateTodoTypeConfigResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateTodoTypeConfigResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTodoTypeConfigResponseBody setPcDetailUrlOpenMode(String pcDetailUrlOpenMode) {
        this.pcDetailUrlOpenMode = pcDetailUrlOpenMode;
        return this;
    }
    public String getPcDetailUrlOpenMode() {
        return this.pcDetailUrlOpenMode;
    }

    public CreateTodoTypeConfigResponseBody setContentFieldList(java.util.List<CreateTodoTypeConfigResponseBodyContentFieldList> contentFieldList) {
        this.contentFieldList = contentFieldList;
        return this;
    }
    public java.util.List<CreateTodoTypeConfigResponseBodyContentFieldList> getContentFieldList() {
        return this.contentFieldList;
    }

    public CreateTodoTypeConfigResponseBody setActionList(java.util.List<CreateTodoTypeConfigResponseBodyActionList> actionList) {
        this.actionList = actionList;
        return this;
    }
    public java.util.List<CreateTodoTypeConfigResponseBodyActionList> getActionList() {
        return this.actionList;
    }

    public static class CreateTodoTypeConfigResponseBodyContentFieldList extends TeaModel {
        // 字段唯一标识
        @NameInMap("fieldKey")
        public String fieldKey;

        // 字段类型（取值为：text-文本，url-链接）
        @NameInMap("fieldType")
        public String fieldType;

        // 字段的显示名称（支持国际化）
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

    public static class CreateTodoTypeConfigResponseBodyActionList extends TeaModel {
        // 操作按钮的唯一标识
        @NameInMap("actionKey")
        public String actionKey;

        // 按钮样式类型（101：蓝色线型主按钮样式，例如「同意」，102：黑色线型副按钮样式，例如「拒绝」）
        @NameInMap("buttonStyleType")
        public Integer buttonStyleType;

        // 按钮类型（1：有操作的，2：直接跳转）
        @NameInMap("actionType")
        public Integer actionType;

        // 按钮类型为直接跳转时，对应的跳转url
        @NameInMap("url")
        public String url;

        // 按钮操作的显示名称（支持国际化）
        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

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

        public CreateTodoTypeConfigResponseBodyActionList setButtonStyleType(Integer buttonStyleType) {
            this.buttonStyleType = buttonStyleType;
            return this;
        }
        public Integer getButtonStyleType() {
            return this.buttonStyleType;
        }

        public CreateTodoTypeConfigResponseBodyActionList setActionType(Integer actionType) {
            this.actionType = actionType;
            return this;
        }
        public Integer getActionType() {
            return this.actionType;
        }

        public CreateTodoTypeConfigResponseBodyActionList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public CreateTodoTypeConfigResponseBodyActionList setNameI18n(java.util.Map<String, ?> nameI18n) {
            this.nameI18n = nameI18n;
            return this;
        }
        public java.util.Map<String, ?> getNameI18n() {
            return this.nameI18n;
        }

    }

}
