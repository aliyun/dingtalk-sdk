// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ConversationCategoryModel extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("categoryId")
    public Long categoryId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>分组</p>
     */
    @NameInMap("categoryName")
    public String categoryName;

    @NameInMap("children")
    public java.util.List<ConversationCategoryModel> children;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("levelNum")
    public Integer levelNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("order")
    public Integer order;

    public static ConversationCategoryModel build(java.util.Map<String, ?> map) throws Exception {
        ConversationCategoryModel self = new ConversationCategoryModel();
        return TeaModel.build(map, self);
    }

    public ConversationCategoryModel setCategoryId(Long categoryId) {
        this.categoryId = categoryId;
        return this;
    }
    public Long getCategoryId() {
        return this.categoryId;
    }

    public ConversationCategoryModel setCategoryName(String categoryName) {
        this.categoryName = categoryName;
        return this;
    }
    public String getCategoryName() {
        return this.categoryName;
    }

    public ConversationCategoryModel setChildren(java.util.List<ConversationCategoryModel> children) {
        this.children = children;
        return this;
    }
    public java.util.List<ConversationCategoryModel> getChildren() {
        return this.children;
    }

    public ConversationCategoryModel setLevelNum(Integer levelNum) {
        this.levelNum = levelNum;
        return this;
    }
    public Integer getLevelNum() {
        return this.levelNum;
    }

    public ConversationCategoryModel setOrder(Integer order) {
        this.order = order;
        return this;
    }
    public Integer getOrder() {
        return this.order;
    }

}
