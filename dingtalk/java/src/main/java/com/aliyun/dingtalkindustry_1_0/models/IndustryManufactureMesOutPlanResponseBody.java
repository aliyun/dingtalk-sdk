// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutPlanResponseBody extends TeaModel {
    @NameInMap("result")
    public IndustryManufactureMesOutPlanResponseBodyResult result;

    public static IndustryManufactureMesOutPlanResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesOutPlanResponseBody self = new IndustryManufactureMesOutPlanResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesOutPlanResponseBody setResult(IndustryManufactureMesOutPlanResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesOutPlanResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesOutPlanResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesOutPlanResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesOutPlanResponseBodyResult self = new IndustryManufactureMesOutPlanResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesOutPlanResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
