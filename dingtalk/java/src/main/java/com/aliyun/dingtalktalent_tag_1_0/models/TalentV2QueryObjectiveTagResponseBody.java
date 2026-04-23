// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryObjectiveTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2QueryObjectiveTagResponseBodyResult result;

    public static TalentV2QueryObjectiveTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryObjectiveTagResponseBody self = new TalentV2QueryObjectiveTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryObjectiveTagResponseBody setResult(TalentV2QueryObjectiveTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2QueryObjectiveTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2QueryObjectiveTagResponseBodyResultTags extends TeaModel {
        @NameInMap("sortOrder")
        public Integer sortOrder;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentV2QueryObjectiveTagResponseBodyResultTags build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryObjectiveTagResponseBodyResultTags self = new TalentV2QueryObjectiveTagResponseBodyResultTags();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryObjectiveTagResponseBodyResultTags setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public TalentV2QueryObjectiveTagResponseBodyResultTags setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentV2QueryObjectiveTagResponseBodyResultTags setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentV2QueryObjectiveTagResponseBodyResult extends TeaModel {
        @NameInMap("tags")
        public java.util.List<TalentV2QueryObjectiveTagResponseBodyResultTags> tags;

        public static TalentV2QueryObjectiveTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2QueryObjectiveTagResponseBodyResult self = new TalentV2QueryObjectiveTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2QueryObjectiveTagResponseBodyResult setTags(java.util.List<TalentV2QueryObjectiveTagResponseBodyResultTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<TalentV2QueryObjectiveTagResponseBodyResultTags> getTags() {
            return this.tags;
        }

    }

}
