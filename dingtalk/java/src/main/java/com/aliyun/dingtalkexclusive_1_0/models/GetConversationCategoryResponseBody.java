// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConversationCategoryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetConversationCategoryResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetConversationCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConversationCategoryResponseBody self = new GetConversationCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConversationCategoryResponseBody setResult(java.util.List<GetConversationCategoryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetConversationCategoryResponseBodyResult> getResult() {
        return this.result;
    }

    public GetConversationCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetConversationCategoryResponseBodyResultChildren extends TeaModel {
        @NameInMap("categoryId")
        public Long categoryId;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("levelNum")
        public Integer levelNum;

        @NameInMap("order")
        public Integer order;

        public static GetConversationCategoryResponseBodyResultChildren build(java.util.Map<String, ?> map) throws Exception {
            GetConversationCategoryResponseBodyResultChildren self = new GetConversationCategoryResponseBodyResultChildren();
            return TeaModel.build(map, self);
        }

        public GetConversationCategoryResponseBodyResultChildren setCategoryId(Long categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public Long getCategoryId() {
            return this.categoryId;
        }

        public GetConversationCategoryResponseBodyResultChildren setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public GetConversationCategoryResponseBodyResultChildren setLevelNum(Integer levelNum) {
            this.levelNum = levelNum;
            return this;
        }
        public Integer getLevelNum() {
            return this.levelNum;
        }

        public GetConversationCategoryResponseBodyResultChildren setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

    public static class GetConversationCategoryResponseBodyResult extends TeaModel {
        @NameInMap("categoryId")
        public Long categoryId;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("children")
        public java.util.List<GetConversationCategoryResponseBodyResultChildren> children;

        @NameInMap("levelNum")
        public Integer levelNum;

        @NameInMap("order")
        public Integer order;

        public static GetConversationCategoryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetConversationCategoryResponseBodyResult self = new GetConversationCategoryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetConversationCategoryResponseBodyResult setCategoryId(Long categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public Long getCategoryId() {
            return this.categoryId;
        }

        public GetConversationCategoryResponseBodyResult setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public GetConversationCategoryResponseBodyResult setChildren(java.util.List<GetConversationCategoryResponseBodyResultChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<GetConversationCategoryResponseBodyResultChildren> getChildren() {
            return this.children;
        }

        public GetConversationCategoryResponseBodyResult setLevelNum(Integer levelNum) {
            this.levelNum = levelNum;
            return this;
        }
        public Integer getLevelNum() {
            return this.levelNum;
        }

        public GetConversationCategoryResponseBodyResult setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

    }

}
