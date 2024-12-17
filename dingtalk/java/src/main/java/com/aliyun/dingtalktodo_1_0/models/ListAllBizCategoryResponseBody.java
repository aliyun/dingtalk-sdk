// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class ListAllBizCategoryResponseBody extends TeaModel {
    @NameInMap("bizCategories")
    public java.util.List<ListAllBizCategoryResponseBodyBizCategories> bizCategories;

    public static ListAllBizCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAllBizCategoryResponseBody self = new ListAllBizCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAllBizCategoryResponseBody setBizCategories(java.util.List<ListAllBizCategoryResponseBodyBizCategories> bizCategories) {
        this.bizCategories = bizCategories;
        return this;
    }
    public java.util.List<ListAllBizCategoryResponseBodyBizCategories> getBizCategories() {
        return this.bizCategories;
    }

    public static class ListAllBizCategoryResponseBodyBizCategories extends TeaModel {
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        @NameInMap("createdTime")
        public Long createdTime;

        @NameInMap("description")
        public String description;

        @NameInMap("modifiedTime")
        public Long modifiedTime;

        @NameInMap("name")
        public String name;

        public static ListAllBizCategoryResponseBodyBizCategories build(java.util.Map<String, ?> map) throws Exception {
            ListAllBizCategoryResponseBodyBizCategories self = new ListAllBizCategoryResponseBodyBizCategories();
            return TeaModel.build(map, self);
        }

        public ListAllBizCategoryResponseBodyBizCategories setBizCategoryId(String bizCategoryId) {
            this.bizCategoryId = bizCategoryId;
            return this;
        }
        public String getBizCategoryId() {
            return this.bizCategoryId;
        }

        public ListAllBizCategoryResponseBodyBizCategories setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public ListAllBizCategoryResponseBodyBizCategories setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListAllBizCategoryResponseBodyBizCategories setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

        public ListAllBizCategoryResponseBodyBizCategories setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
