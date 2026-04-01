// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentAddPersonalityTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentAddPersonalityTagResponseBodyResult result;

    public static TalentAddPersonalityTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentAddPersonalityTagResponseBody self = new TalentAddPersonalityTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentAddPersonalityTagResponseBody setResult(TalentAddPersonalityTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentAddPersonalityTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentAddPersonalityTagResponseBodyResult extends TeaModel {
        @NameInMap("categoryCode")
        public String categoryCode;

        @NameInMap("categoryName")
        public String categoryName;

        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentAddPersonalityTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentAddPersonalityTagResponseBodyResult self = new TalentAddPersonalityTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentAddPersonalityTagResponseBodyResult setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public TalentAddPersonalityTagResponseBodyResult setCategoryName(String categoryName) {
            this.categoryName = categoryName;
            return this;
        }
        public String getCategoryName() {
            return this.categoryName;
        }

        public TalentAddPersonalityTagResponseBodyResult setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentAddPersonalityTagResponseBodyResult setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

}
