// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateLiveResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateLiveResponseBodyResult result;

    public static CreateLiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateLiveResponseBody self = new CreateLiveResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateLiveResponseBody setResult(CreateLiveResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateLiveResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateLiveResponseBodyResult extends TeaModel {
        @NameInMap("liveId")
        public String liveId;

        public static CreateLiveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateLiveResponseBodyResult self = new CreateLiveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateLiveResponseBodyResult setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

    }

}
