// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTypeConfigResponseBody extends TeaModel {
    /**
     * <p>待办卡片操作区按钮配置</p>
     */
    @NameInMap("actionList")
    public java.util.List<GetTodoTypeConfigResponseBodyActionList> actionList;

    /**
     * <p>接入应用标识</p>
     */
    @NameInMap("bizTag")
    public String bizTag;

    /**
     * <p>卡片类型（取值为：1-标准卡片，2-自定义卡片）</p>
     */
    @NameInMap("cardType")
    public Integer cardType;

    /**
     * <p>待办卡片内容区表单自定义字段配置</p>
     */
    @NameInMap("contentFieldList")
    public java.util.List<GetTodoTypeConfigResponseBodyContentFieldList> contentFieldList;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    /**
     * <p>创建者（用户的unionId）</p>
     */
    @NameInMap("creatorId")
    public String creatorId;

    /**
     * <p>待办卡片类型描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>卡片类型icon，用于在待办列表展示</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>id</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>更新时间</p>
     */
    @NameInMap("modifiedTime")
    public Long modifiedTime;

    /**
     * <p>更新者（用户的unionId）</p>
     */
    @NameInMap("modifierId")
    public String modifierId;

    /**
     * <p>详情页链接在PC端的打开方式，取值为：「PC_SLIDE」-PC端侧边栏打开，「PC_BROWSER」-浏览器打开</p>
     */
    @NameInMap("pcDetailUrlOpenMode")
    public String pcDetailUrlOpenMode;

    /**
     * <p>requestId</p>
     */
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
        /**
         * <p>操作按钮的唯一标识</p>
         */
        @NameInMap("actionKey")
        public String actionKey;

        /**
         * <p>按钮类型（1：有操作的，2：直接跳转）</p>
         */
        @NameInMap("actionType")
        public Integer actionType;

        /**
         * <p>按钮样式类型（101：蓝色线型主按钮样式，例如「同意」，102：黑色线型副按钮样式，例如「拒绝」）</p>
         */
        @NameInMap("buttonStyleType")
        public Integer buttonStyleType;

        /**
         * <p>按钮操作的显示名称（支持国际化）</p>
         */
        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        /**
         * <p>按钮类型为直接跳转时，对应的跳转url</p>
         */
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
        /**
         * <p>字段唯一标识</p>
         */
        @NameInMap("fieldKey")
        public String fieldKey;

        /**
         * <p>字段类型（取值为：text-文本，url-链接）</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        /**
         * <p>字段的显示名称（支持国际化）</p>
         */
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
