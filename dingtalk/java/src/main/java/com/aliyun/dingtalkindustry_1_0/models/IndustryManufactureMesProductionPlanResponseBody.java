// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProductionPlanResponseBody extends TeaModel {
    @NameInMap("result")
    public IndustryManufactureMesProductionPlanResponseBodyResult result;

    public static IndustryManufactureMesProductionPlanResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesProductionPlanResponseBody self = new IndustryManufactureMesProductionPlanResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesProductionPlanResponseBody setResult(IndustryManufactureMesProductionPlanResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesProductionPlanResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesProductionPlanResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesProductionPlanResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesProductionPlanResponseBodyResult self = new IndustryManufactureMesProductionPlanResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesProductionPlanResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
