// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelCategoryUpdateRequest extends TeaModel {
    @NameInMap("categoryVo")
    public HrbrainLabelCategoryUpdateRequestCategoryVo categoryVo;

    public static HrbrainLabelCategoryUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelCategoryUpdateRequest self = new HrbrainLabelCategoryUpdateRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelCategoryUpdateRequest setCategoryVo(HrbrainLabelCategoryUpdateRequestCategoryVo categoryVo) {
        this.categoryVo = categoryVo;
        return this;
    }
    public HrbrainLabelCategoryUpdateRequestCategoryVo getCategoryVo() {
        return this.categoryVo;
    }

    public static class HrbrainLabelCategoryUpdateRequestCategoryVoCategories extends TeaModel {
        @NameInMap("children")
        public java.util.List<?> children;

        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("pCode")
        public String pCode;

        @NameInMap("sortSize")
        public String sortSize;

        public static HrbrainLabelCategoryUpdateRequestCategoryVoCategories build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelCategoryUpdateRequestCategoryVoCategories self = new HrbrainLabelCategoryUpdateRequestCategoryVoCategories();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelCategoryUpdateRequestCategoryVoCategories setChildren(java.util.List<?> children) {
            this.children = children;
            return this;
        }
        public java.util.List<?> getChildren() {
            return this.children;
        }

        public HrbrainLabelCategoryUpdateRequestCategoryVoCategories setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public HrbrainLabelCategoryUpdateRequestCategoryVoCategories setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainLabelCategoryUpdateRequestCategoryVoCategories setPCode(String pCode) {
            this.pCode = pCode;
            return this;
        }
        public String getPCode() {
            return this.pCode;
        }

        public HrbrainLabelCategoryUpdateRequestCategoryVoCategories setSortSize(String sortSize) {
            this.sortSize = sortSize;
            return this;
        }
        public String getSortSize() {
            return this.sortSize;
        }

    }

    public static class HrbrainLabelCategoryUpdateRequestCategoryVo extends TeaModel {
        @NameInMap("categories")
        public java.util.List<HrbrainLabelCategoryUpdateRequestCategoryVoCategories> categories;

        public static HrbrainLabelCategoryUpdateRequestCategoryVo build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelCategoryUpdateRequestCategoryVo self = new HrbrainLabelCategoryUpdateRequestCategoryVo();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelCategoryUpdateRequestCategoryVo setCategories(java.util.List<HrbrainLabelCategoryUpdateRequestCategoryVoCategories> categories) {
            this.categories = categories;
            return this;
        }
        public java.util.List<HrbrainLabelCategoryUpdateRequestCategoryVoCategories> getCategories() {
            return this.categories;
        }

    }

}
