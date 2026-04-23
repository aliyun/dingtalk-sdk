// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryCustomTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2QueryCustomTagResponseBodyResult result;

    public static TalentV2QueryCustomTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryCustomTagResponseBody self = new TalentV2QueryCustomTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryCustomTagResponseBody setResult(TalentV2QueryCustomTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2QueryCustomTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2QueryCustomTagResponseBodyResultTags extends TeaModel {
        @NameInMap("sortOrder")
        public Integer sortOrder;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentV2QueryCustomTagResponseBodyResultTags build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryCustomTagResponseBodyResultTags self = new TalentV2QueryCustomTagResponseBodyResultTags();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryCustomTagResponseBodyResultTags setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public TalentV2QueryCustomTagResponseBodyResultTags setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentV2QueryCustomTagResponseBodyResultTags setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentV2QueryCustomTagResponseBodyResult extends TeaModel {
        @NameInMap("tags")
        public java.util.List<TalentV2QueryCustomTagResponseBodyResultTags> tags;

        public static TalentV2QueryCustomTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryCustomTagResponseBodyResult self = new TalentV2QueryCustomTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryCustomTagResponseBodyResult setTags(java.util.List<TalentV2QueryCustomTagResponseBodyResultTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<TalentV2QueryCustomTagResponseBodyResultTags> getTags() {
            return this.tags;
        }

    }

}
