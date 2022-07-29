// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutputResponseBody extends TeaModel {
    @NameInMap("result")
    public IndustryManufactureMesOutputResponseBodyResult result;

    public static IndustryManufactureMesOutputResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesOutputResponseBody self = new IndustryManufactureMesOutputResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesOutputResponseBody setResult(IndustryManufactureMesOutputResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesOutputResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesOutputResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesOutputResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesOutputResponseBodyResult self = new IndustryManufactureMesOutputResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesOutputResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
