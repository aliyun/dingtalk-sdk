// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryObjectiveTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentQueryObjectiveTagResponseBodyResult result;

    public static TalentQueryObjectiveTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryObjectiveTagResponseBody self = new TalentQueryObjectiveTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentQueryObjectiveTagResponseBody setResult(TalentQueryObjectiveTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentQueryObjectiveTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentQueryObjectiveTagResponseBodyResultTags extends TeaModel {
        @NameInMap("sortOrder")
        public Integer sortOrder;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentQueryObjectiveTagResponseBodyResultTags build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryObjectiveTagResponseBodyResultTags self = new TalentQueryObjectiveTagResponseBodyResultTags();
            return TeaModel.build(map, self);
        }

        public TalentQueryObjectiveTagResponseBodyResultTags setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public TalentQueryObjectiveTagResponseBodyResultTags setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentQueryObjectiveTagResponseBodyResultTags setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentQueryObjectiveTagResponseBodyResult extends TeaModel {
        @NameInMap("tags")
        public java.util.List<TalentQueryObjectiveTagResponseBodyResultTags> tags;

        public static TalentQueryObjectiveTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryObjectiveTagResponseBodyResult self = new TalentQueryObjectiveTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentQueryObjectiveTagResponseBodyResult setTags(java.util.List<TalentQueryObjectiveTagResponseBodyResultTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<TalentQueryObjectiveTagResponseBodyResultTags> getTags() {
            return this.tags;
        }

    }

}
