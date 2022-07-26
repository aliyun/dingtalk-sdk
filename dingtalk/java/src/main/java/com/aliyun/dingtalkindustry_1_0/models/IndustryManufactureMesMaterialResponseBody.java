// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesMaterialResponseBody extends TeaModel {
    @NameInMap("result")
    public IndustryManufactureMesMaterialResponseBodyResult result;

    public static IndustryManufactureMesMaterialResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesMaterialResponseBody self = new IndustryManufactureMesMaterialResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesMaterialResponseBody setResult(IndustryManufactureMesMaterialResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesMaterialResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesMaterialResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesMaterialResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesMaterialResponseBodyResult self = new IndustryManufactureMesMaterialResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesMaterialResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
