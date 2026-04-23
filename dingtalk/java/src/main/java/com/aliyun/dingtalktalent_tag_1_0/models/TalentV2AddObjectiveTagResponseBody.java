// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddObjectiveTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentV2AddObjectiveTagResponseBodyResult result;

    public static TalentV2AddObjectiveTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddObjectiveTagResponseBody self = new TalentV2AddObjectiveTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentV2AddObjectiveTagResponseBody setResult(TalentV2AddObjectiveTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentV2AddObjectiveTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentV2AddObjectiveTagResponseBodyResult extends TeaModel {
        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentV2AddObjectiveTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentV2AddObjectiveTagResponseBodyResult self = new TalentV2AddObjectiveTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentV2AddObjectiveTagResponseBodyResult setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentV2AddObjectiveTagResponseBodyResult setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

}
