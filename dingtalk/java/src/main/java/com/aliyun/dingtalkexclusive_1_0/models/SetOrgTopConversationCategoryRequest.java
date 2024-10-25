// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetOrgTopConversationCategoryRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<SetOrgTopConversationCategoryRequestBody> body;

    public static SetOrgTopConversationCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        SetOrgTopConversationCategoryRequest self = new SetOrgTopConversationCategoryRequest();
        return TeaModel.build(map, self);
    }

    public SetOrgTopConversationCategoryRequest setBody(java.util.List<SetOrgTopConversationCategoryRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<SetOrgTopConversationCategoryRequestBody> getBody() {
        return this.body;
    }

    public static class SetOrgTopConversationCategoryRequestBody extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123111</p>
         */
        @NameInMap("categoryId")
        public Long categoryId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>重要保障</p>
         */
        @NameInMap("categoryName")
        public String categoryName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("order")
        public Integer order;

        public static SetOrgTopConversationCategoryRequestBody build(java.util.Map<String, ?> map) throws Exception {
            SetOrgTopConversationCategoryRequestBody self = new SetOrgTopConversationCategoryRequestBody();
            return TeaModel.build(map, self);
        }

        public SetOrgTopConversationCategoryRequestBody setCategoryId(Long categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public Long getCategoryId() {
            return this.categoryId;
        }

        public SetOrgTopConversationCategoryRequestBody setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public SetOrgTopConversationCategoryRequestBody setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

}
