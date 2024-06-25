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
        /**
         * <strong>example:</strong>
         * <p><a href="http://xxx.dingtalk.com/live_hp/7c7ba32a-c92d-4524-b71e-33a72575c5a9_normal.m3u8?auth_key=xxx">http://xxx.dingtalk.com/live_hp/7c7ba32a-c92d-4524-b71e-33a72575c5a9_normal.m3u8?auth_key=xxx</a></p>
         */
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
