// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryPersonalityTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2QueryPersonalityTagResponseBodyResult result;

    public static TalentV2QueryPersonalityTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryPersonalityTagResponseBody self = new TalentV2QueryPersonalityTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryPersonalityTagResponseBody setResult(TalentV2QueryPersonalityTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2QueryPersonalityTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2QueryPersonalityTagResponseBodyResultTags extends TeaModel {
        @NameInMap("categoryCode")
        public String categoryCode;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("categorySortOrder")
        public Integer categorySortOrder;

        @NameInMap("sortOrder")
        public Integer sortOrder;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentV2QueryPersonalityTagResponseBodyResultTags build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryPersonalityTagResponseBodyResultTags self = new TalentV2QueryPersonalityTagResponseBodyResultTags();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryPersonalityTagResponseBodyResultTags setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public TalentV2QueryPersonalityTagResponseBodyResultTags setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public TalentV2QueryPersonalityTagResponseBodyResultTags setCategorySortOrder(Integer categorySortOrder) {
            this.categorySortOrder = categorySortOrder;
            return this;
        }
        public Integer getCategorySortOrder() {
            return this.categorySortOrder;
        }

        public TalentV2QueryPersonalityTagResponseBodyResultTags setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public TalentV2QueryPersonalityTagResponseBodyResultTags setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentV2QueryPersonalityTagResponseBodyResultTags setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentV2QueryPersonalityTagResponseBodyResult extends TeaModel {
        @NameInMap("tags")
        public java.util.List<TalentV2QueryPersonalityTagResponseBodyResultTags> tags;

        public static TalentV2QueryPersonalityTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryPersonalityTagResponseBodyResult self = new TalentV2QueryPersonalityTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryPersonalityTagResponseBodyResult setTags(java.util.List<TalentV2QueryPersonalityTagResponseBodyResultTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<TalentV2QueryPersonalityTagResponseBodyResultTags> getTags() {
            return this.tags;
        }

    }

}
