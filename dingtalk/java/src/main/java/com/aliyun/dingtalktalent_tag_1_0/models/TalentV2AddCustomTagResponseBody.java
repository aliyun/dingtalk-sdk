// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddCustomTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2AddCustomTagResponseBodyResult result;

    public static TalentV2AddCustomTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddCustomTagResponseBody self = new TalentV2AddCustomTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2AddCustomTagResponseBody setResult(TalentV2AddCustomTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2AddCustomTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2AddCustomTagResponseBodyResult extends TeaModel {
        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentV2AddCustomTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2AddCustomTagResponseBodyResult self = new TalentV2AddCustomTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2AddCustomTagResponseBodyResult setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentV2AddCustomTagResponseBodyResult setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

}
