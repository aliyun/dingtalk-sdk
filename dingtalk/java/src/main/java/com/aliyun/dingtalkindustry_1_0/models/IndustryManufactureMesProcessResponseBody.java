// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProcessResponseBody extends TeaModel {
    @NameInMap("result")
    public IndustryManufactureMesProcessResponseBodyResult result;

    public static IndustryManufactureMesProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesProcessResponseBody self = new IndustryManufactureMesProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesProcessResponseBody setResult(IndustryManufactureMesProcessResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesProcessResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesProcessResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesProcessResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesProcessResponseBodyResult self = new IndustryManufactureMesProcessResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesProcessResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
