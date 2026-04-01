// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryPersonalityTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentQueryPersonalityTagResponseBodyResult result;

    public static TalentQueryPersonalityTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryPersonalityTagResponseBody self = new TalentQueryPersonalityTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentQueryPersonalityTagResponseBody setResult(TalentQueryPersonalityTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentQueryPersonalityTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentQueryPersonalityTagResponseBodyResultTags extends TeaModel {
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

        public static TalentQueryPersonalityTagResponseBodyResultTags build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryPersonalityTagResponseBodyResultTags self = new TalentQueryPersonalityTagResponseBodyResultTags();
            return TeaModel.build(map, self);
        }

        public TalentQueryPersonalityTagResponseBodyResultTags setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public TalentQueryPersonalityTagResponseBodyResultTags setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public TalentQueryPersonalityTagResponseBodyResultTags setCategorySortOrder(Integer categorySortOrder) {
            this.categorySortOrder = categorySortOrder;
            return this;
        }
        public Integer getCategorySortOrder() {
            return this.categorySortOrder;
        }

        public TalentQueryPersonalityTagResponseBodyResultTags setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public TalentQueryPersonalityTagResponseBodyResultTags setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentQueryPersonalityTagResponseBodyResultTags setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentQueryPersonalityTagResponseBodyResult extends TeaModel {
        @NameInMap("tags")
        public java.util.List<TalentQueryPersonalityTagResponseBodyResultTags> tags;

        public static TalentQueryPersonalityTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryPersonalityTagResponseBodyResult self = new TalentQueryPersonalityTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentQueryPersonalityTagResponseBodyResult setTags(java.util.List<TalentQueryPersonalityTagResponseBodyResultTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<TalentQueryPersonalityTagResponseBodyResultTags> getTags() {
            return this.tags;
        }

    }

}
