// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationTopCategoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("setCategoryList")
    public java.util.List<SetConversationTopCategoryRequestSetCategoryList> setCategoryList;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("sign")
    public Integer sign;

    public static SetConversationTopCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        SetConversationTopCategoryRequest self = new SetConversationTopCategoryRequest();
        return TeaModel.build(map, self);
    }

    public SetConversationTopCategoryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SetConversationTopCategoryRequest setSetCategoryList(java.util.List<SetConversationTopCategoryRequestSetCategoryList> setCategoryList) {
        this.setCategoryList = setCategoryList;
        return this;
    }
    public java.util.List<SetConversationTopCategoryRequestSetCategoryList> getSetCategoryList() {
        return this.setCategoryList;
    }

    public SetConversationTopCategoryRequest setSign(Integer sign) {
        this.sign = sign;
        return this;
    }
    public Integer getSign() {
        return this.sign;
    }

    public static class SetConversationTopCategoryRequestSetCategoryList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("categoryId")
        public Long categoryId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("order")
        public Integer order;

        public static SetConversationTopCategoryRequestSetCategoryList build(java.util.Map<String, ?> map) throws Exception {
            SetConversationTopCategoryRequestSetCategoryList self = new SetConversationTopCategoryRequestSetCategoryList();
            return TeaModel.build(map, self);
        }

        public SetConversationTopCategoryRequestSetCategoryList setCategoryId(Long categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public Long getCategoryId() {
            return this.categoryId;
        }

        public SetConversationTopCategoryRequestSetCategoryList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

}
