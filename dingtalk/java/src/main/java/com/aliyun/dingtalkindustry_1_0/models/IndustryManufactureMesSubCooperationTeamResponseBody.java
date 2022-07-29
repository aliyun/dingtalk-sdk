// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesSubCooperationTeamResponseBody extends TeaModel {
    @NameInMap("result")
    public IndustryManufactureMesSubCooperationTeamResponseBodyResult result;

    public static IndustryManufactureMesSubCooperationTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesSubCooperationTeamResponseBody self = new IndustryManufactureMesSubCooperationTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesSubCooperationTeamResponseBody setResult(IndustryManufactureMesSubCooperationTeamResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IndustryManufactureMesSubCooperationTeamResponseBodyResult getResult() {
        return this.result;
    }

    public static class IndustryManufactureMesSubCooperationTeamResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static IndustryManufactureMesSubCooperationTeamResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesSubCooperationTeamResponseBodyResult self = new IndustryManufactureMesSubCooperationTeamResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesSubCooperationTeamResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
