// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTypeConfigRequest extends TeaModel {
    /**
     * <p>待办卡片操作区按钮配置</p>
     */
    @NameInMap("actionList")
    public java.util.List<UpdateTodoTypeConfigRequestActionList> actionList;

    /**
     * <p>卡片类型（取值为：1-标准卡片，2-自定义卡片）</p>
     */
    @NameInMap("cardType")
    public Integer cardType;

    /**
     * <p>待办卡片内容区表单自定义字段配置</p>
     */
    @NameInMap("contentFieldList")
    public java.util.List<UpdateTodoTypeConfigRequestContentFieldList> contentFieldList;

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
     * <p>详情页链接在PC端的打开方式，取值为：「PC_SLIDE」-PC端侧边栏打开，「PC_BROWSER」-浏览器打开</p>
     */
    @NameInMap("pcDetailUrlOpenMode")
    public String pcDetailUrlOpenMode;

    /**
     * <p>当前操作者id，需传用户的unionId</p>
     */
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
         * <p>按钮操作的显示名称（需支持国际化）</p>
         */
        @NameInMap("nameI18n")
        public java.util.Map<String, ?> nameI18n;

        /**
         * <p>按钮类型为直接跳转时，对应的跳转url</p>
         */
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
         * <p>字段显示名称(需支持国际化)</p>
         */
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
