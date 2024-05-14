// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CategoriesTemplatesRequest extends TeaModel {
    @NameInMap("option")
    public CategoriesTemplatesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public CategoriesTemplatesRequestParam param;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CategoriesTemplatesRequest build(java.util.Map<String, ?> map) throws Exception {
        CategoriesTemplatesRequest self = new CategoriesTemplatesRequest();
        return TeaModel.build(map, self);
    }

    public CategoriesTemplatesRequest setOption(CategoriesTemplatesRequestOption option) {
        this.option = option;
        return this;
    }
    public CategoriesTemplatesRequestOption getOption() {
        return this.option;
    }

    public CategoriesTemplatesRequest setParam(CategoriesTemplatesRequestParam param) {
        this.param = param;
        return this;
    }
    public CategoriesTemplatesRequestParam getParam() {
        return this.param;
    }

    public CategoriesTemplatesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CategoriesTemplatesRequestOption extends TeaModel {
        @NameInMap("categoryStatus")
        public Integer categoryStatus;

        @NameInMap("queryPlatform")
        public String queryPlatform;

        @NameInMap("size")
        public Integer size;

        @NameInMap("templateStatus")
        public Integer templateStatus;

        public static CategoriesTemplatesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CategoriesTemplatesRequestOption self = new CategoriesTemplatesRequestOption();
            return TeaModel.build(map, self);
        }

        public CategoriesTemplatesRequestOption setCategoryStatus(Integer categoryStatus) {
            this.categoryStatus = categoryStatus;
            return this;
        }
        public Integer getCategoryStatus() {
            return this.categoryStatus;
        }

        public CategoriesTemplatesRequestOption setQueryPlatform(String queryPlatform) {
            this.queryPlatform = queryPlatform;
            return this;
        }
        public String getQueryPlatform() {
            return this.queryPlatform;
        }

        public CategoriesTemplatesRequestOption setSize(Integer size) {
            this.size = size;
            return this;
        }
        public Integer getSize() {
            return this.size;
        }

        public CategoriesTemplatesRequestOption setTemplateStatus(Integer templateStatus) {
            this.templateStatus = templateStatus;
            return this;
        }
        public Integer getTemplateStatus() {
            return this.templateStatus;
        }

    }

    public static class CategoriesTemplatesRequestParam extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("categoryIds")
        public java.util.List<String> categoryIds;

        public static CategoriesTemplatesRequestParam build(java.util.Map<String, ?> map) throws Exception {
            CategoriesTemplatesRequestParam self = new CategoriesTemplatesRequestParam();
            return TeaModel.build(map, self);
        }

        public CategoriesTemplatesRequestParam setCategoryIds(java.util.List<String> categoryIds) {
            this.categoryIds = categoryIds;
            return this;
        }
        public java.util.List<String> getCategoryIds() {
            return this.categoryIds;
        }

    }

}
