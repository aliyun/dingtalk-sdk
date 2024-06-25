// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class QueryPluginRuleRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>group_chat</p>
     */
    @NameInMap("chatType")
    public String chatType;

    /**
     * <strong>example:</strong>
     * <p>-10050</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("itemId")
    public String itemId;

    /**
     * <strong>example:</strong>
     * <p>group</p>
     */
    @NameInMap("itemType")
    public String itemType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryPluginRuleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPluginRuleRequest self = new QueryPluginRuleRequest();
        return TeaModel.build(map, self);
    }

    public QueryPluginRuleRequest setChatType(String chatType) {
        this.chatType = chatType;
        return this;
    }
    public String getChatType() {
        return this.chatType;
    }

    public QueryPluginRuleRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public QueryPluginRuleRequest setItemId(String itemId) {
        this.itemId = itemId;
        return this;
    }
    public String getItemId() {
        return this.itemId;
    }

    public QueryPluginRuleRequest setItemType(String itemType) {
        this.itemType = itemType;
        return this;
    }
    public String getItemType() {
        return this.itemType;
    }

    public QueryPluginRuleRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryPluginRuleRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
