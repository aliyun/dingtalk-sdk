// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetLiveReplayUrlResponseBody extends TeaModel {
    @NameInMap("result")
    public GetLiveReplayUrlResponseBodyResult result;

    public static GetLiveReplayUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetLiveReplayUrlResponseBody self = new GetLiveReplayUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetLiveReplayUrlResponseBody setResult(GetLiveReplayUrlResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetLiveReplayUrlResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetLiveReplayUrlResponseBodyResult extends TeaModel {
        @NameInMap("replayUrl")
        public String replayUrl;

        public static GetLiveReplayUrlResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetLiveReplayUrlResponseBodyResult self = new GetLiveReplayUrlResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetLiveReplayUrlResponseBodyResult setReplayUrl(String replayUrl) {
            this.replayUrl = replayUrl;
            return this;
        }
        public String getReplayUrl() {
            return this.replayUrl;
        }

    }

}
