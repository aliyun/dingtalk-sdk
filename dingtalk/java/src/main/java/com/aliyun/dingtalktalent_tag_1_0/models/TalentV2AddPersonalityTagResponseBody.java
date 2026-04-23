// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddPersonalityTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2AddPersonalityTagResponseBodyResult result;

    public static TalentV2AddPersonalityTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddPersonalityTagResponseBody self = new TalentV2AddPersonalityTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2AddPersonalityTagResponseBody setResult(TalentV2AddPersonalityTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2AddPersonalityTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2AddPersonalityTagResponseBodyResult extends TeaModel {
        @NameInMap("categoryCode")
        public String categoryCode;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentV2AddPersonalityTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2AddPersonalityTagResponseBodyResult self = new TalentV2AddPersonalityTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2AddPersonalityTagResponseBodyResult setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public TalentV2AddPersonalityTagResponseBodyResult setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public TalentV2AddPersonalityTagResponseBodyResult setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentV2AddPersonalityTagResponseBodyResult setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

}
