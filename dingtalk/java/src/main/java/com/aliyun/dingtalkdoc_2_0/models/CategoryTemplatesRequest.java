// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CategoryTemplatesRequest extends TeaModel {
    @NameInMap("option")
    public CategoryTemplatesRequestOption option;

    @NameInMap("param")
    public CategoryTemplatesRequestParam param;

    @NameInMap("operatorId")
    public String operatorId;

    public static CategoryTemplatesRequest build(java.util.Map<String, ?> map) throws Exception {
        CategoryTemplatesRequest self = new CategoryTemplatesRequest();
        return TeaModel.build(map, self);
    }

    public CategoryTemplatesRequest setOption(CategoryTemplatesRequestOption option) {
        this.option = option;
        return this;
    }
    public CategoryTemplatesRequestOption getOption() {
        return this.option;
    }

    public CategoryTemplatesRequest setParam(CategoryTemplatesRequestParam param) {
        this.param = param;
        return this;
    }
    public CategoryTemplatesRequestParam getParam() {
        return this.param;
    }

    public CategoryTemplatesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CategoryTemplatesRequestOption extends TeaModel {
        @NameInMap("categoryStatus")
        public Integer categoryStatus;

        @NameInMap("templateStatus")
        public Integer templateStatus;

        public static CategoryTemplatesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CategoryTemplatesRequestOption self = new CategoryTemplatesRequestOption();
            return TeaModel.build(map, self);
        }

        public CategoryTemplatesRequestOption setCategoryStatus(Integer categoryStatus) {
            this.categoryStatus = categoryStatus;
            return this;
        }
        public Integer getCategoryStatus() {
            return this.categoryStatus;
        }

        public CategoryTemplatesRequestOption setTemplateStatus(Integer templateStatus) {
            this.templateStatus = templateStatus;
            return this;
        }
        public Integer getTemplateStatus() {
            return this.templateStatus;
        }

    }

    public static class CategoryTemplatesRequestParam extends TeaModel {
        @NameInMap("categoryId")
        public String categoryId;

        public static CategoryTemplatesRequestParam build(java.util.Map<String, ?> map) throws Exception {
            CategoryTemplatesRequestParam self = new CategoryTemplatesRequestParam();
            return TeaModel.build(map, self);
        }

        public CategoryTemplatesRequestParam setCategoryId(String categoryId) {
            this.categoryId = categoryId;
            return this;
        }
        public String getCategoryId() {
            return this.categoryId;
        }

    }

}
