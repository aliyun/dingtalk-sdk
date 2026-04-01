// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentAddCustomTagResponseBody extends TeaModel {
    @NameInMap("result")
    public TalentAddCustomTagResponseBodyResult result;

    public static TalentAddCustomTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TalentAddCustomTagResponseBody self = new TalentAddCustomTagResponseBody();
        return TeaModel.build(map, self);
    }

    public TalentAddCustomTagResponseBody setResult(TalentAddCustomTagResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TalentAddCustomTagResponseBodyResult getResult() {
        return this.result;
    }

    public static class TalentAddCustomTagResponseBodyResult extends TeaModel {
        @NameInMap("tagCode")
        public String tagCode;

        @NameInMap("tagName")
        public String tagName;

        public static TalentAddCustomTagResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TalentAddCustomTagResponseBodyResult self = new TalentAddCustomTagResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TalentAddCustomTagResponseBodyResult setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

        public TalentAddCustomTagResponseBodyResult setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

}
