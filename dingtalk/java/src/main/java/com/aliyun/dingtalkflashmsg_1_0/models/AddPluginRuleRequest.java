// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class AddPluginRuleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>group_chat</p>
     */
    @NameInMap("chatType")
    public String chatType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>-10050</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>group</p>
     */
    @NameInMap("itemType")
    public String itemType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("rules")
    public java.util.List<AddPluginRuleRequestRules> rules;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0847493113802787</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddPluginRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        AddPluginRuleRequest self = new AddPluginRuleRequest();
        return TeaModel.build(map, self);
    }

    public AddPluginRuleRequest setChatType(String chatType) {
        this.chatType = chatType;
        return this;
    }
    public String getChatType() {
        return this.chatType;
    }

    public AddPluginRuleRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public AddPluginRuleRequest setItemType(String itemType) {
        this.itemType = itemType;
        return this;
    }
    public String getItemType() {
        return this.itemType;
    }

    public AddPluginRuleRequest setRules(java.util.List<AddPluginRuleRequestRules> rules) {
        this.rules = rules;
        return this;
    }
    public java.util.List<AddPluginRuleRequestRules> getRules() {
        return this.rules;
    }

    public AddPluginRuleRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class AddPluginRuleRequestRules extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("itemId")
        public String itemId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>管理员角色</p>
         */
        @NameInMap("itemName")
        public String itemName;

        public static AddPluginRuleRequestRules build(java.util.Map<String, ?> map) throws Exception {
            AddPluginRuleRequestRules self = new AddPluginRuleRequestRules();
            return TeaModel.build(map, self);
        }

        public AddPluginRuleRequestRules setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public AddPluginRuleRequestRules setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

    }

}
