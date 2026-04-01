// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentAddObjectiveTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentAddObjectiveTagResponseBodyResult result;

    public static TalentAddObjectiveTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentAddObjectiveTagResponseBody self = new TalentAddObjectiveTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentAddObjectiveTagResponseBody setResult(TalentAddObjectiveTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentAddObjectiveTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentAddObjectiveTagResponseBodyResult extends TeaModel {
        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentAddObjectiveTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentAddObjectiveTagResponseBodyResult self = new TalentAddObjectiveTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentAddObjectiveTagResponseBodyResult setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentAddObjectiveTagResponseBodyResult setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

}
