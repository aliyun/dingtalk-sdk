// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryCustomTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentQueryCustomTagResponseBodyResult result;

    public static TalentQueryCustomTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryCustomTagResponseBody self = new TalentQueryCustomTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentQueryCustomTagResponseBody setResult(TalentQueryCustomTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentQueryCustomTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentQueryCustomTagResponseBodyResultTags extends TeaModel {
        @NameInMap("sortOrder")
        public Integer sortOrder;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentQueryCustomTagResponseBodyResultTags build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryCustomTagResponseBodyResultTags self = new TalentQueryCustomTagResponseBodyResultTags();
            return TeaModel.build(map, self);
        }

        public TalentQueryCustomTagResponseBodyResultTags setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public TalentQueryCustomTagResponseBodyResultTags setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentQueryCustomTagResponseBodyResultTags setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class TalentQueryCustomTagResponseBodyResult extends TeaModel {
        @NameInMap("tags")
        public java.util.List<TalentQueryCustomTagResponseBodyResultTags> tags;

        public static TalentQueryCustomTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentQueryCustomTagResponseBodyResult self = new TalentQueryCustomTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentQueryCustomTagResponseBodyResult setTags(java.util.List<TalentQueryCustomTagResponseBodyResultTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<TalentQueryCustomTagResponseBodyResultTags> getTags() {
            return this.tags;
        }

    }

}
