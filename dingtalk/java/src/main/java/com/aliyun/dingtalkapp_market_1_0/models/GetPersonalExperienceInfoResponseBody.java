// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalExperienceInfoResponseBody extends TeaModel {
    // 数据对象
    @NameInMap("result")
    public GetPersonalExperienceInfoResponseBodyResult result;

    public static GetPersonalExperienceInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalExperienceInfoResponseBody self = new GetPersonalExperienceInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPersonalExperienceInfoResponseBody setResult(GetPersonalExperienceInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetPersonalExperienceInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetPersonalExperienceInfoResponseBodyResult extends TeaModel {
        // 主组织corpId
        @NameInMap("mainCorpId")
        public String mainCorpId;

        public static GetPersonalExperienceInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetPersonalExperienceInfoResponseBodyResult self = new GetPersonalExperienceInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetPersonalExperienceInfoResponseBodyResult setMainCorpId(String mainCorpId) {
            this.mainCorpId = mainCorpId;
            return this;
        }
        public String getMainCorpId() {
            return this.mainCorpId;
        }

    }

}
