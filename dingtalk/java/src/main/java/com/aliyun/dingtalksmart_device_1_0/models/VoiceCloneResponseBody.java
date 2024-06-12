// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class VoiceCloneResponseBody extends TeaModel {
    @NameInMap("result")
    public VoiceCloneResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static VoiceCloneResponseBody build(java.util.Map<String, ?> map) throws Exception {
        VoiceCloneResponseBody self = new VoiceCloneResponseBody();
        return TeaModel.build(map, self);
    }

    public VoiceCloneResponseBody setResult(VoiceCloneResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public VoiceCloneResponseBodyResult getResult() {
        return this.result;
    }

    public VoiceCloneResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class VoiceCloneResponseBodyResult extends TeaModel {
        @NameInMap("mediaUrl")
        public String mediaUrl;

        @NameInMap("requestId")
        public String requestId;

        public static VoiceCloneResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            VoiceCloneResponseBodyResult self = new VoiceCloneResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public VoiceCloneResponseBodyResult setMediaUrl(String mediaUrl) {
            this.mediaUrl = mediaUrl;
            return this;
        }
        public String getMediaUrl() {
            return this.mediaUrl;
        }

        public VoiceCloneResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
