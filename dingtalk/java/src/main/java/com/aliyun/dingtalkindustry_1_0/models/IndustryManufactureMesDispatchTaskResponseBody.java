// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesDispatchTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public IndustryManufactureMesDispatchTaskResponseBodyResult result;

    public static IndustryManufactureMesDispatchTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesDispatchTaskResponseBody self = new IndustryManufactureMesDispatchTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesDispatchTaskResponseBody setResult(IndustryManufactureMesDispatchTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesDispatchTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesDispatchTaskResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesDispatchTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesDispatchTaskResponseBodyResult self = new IndustryManufactureMesDispatchTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesDispatchTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
