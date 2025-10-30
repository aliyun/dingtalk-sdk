// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAudioFileDownloadInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetAudioFileDownloadInfoResponseBodyResult result;

    public static GetAudioFileDownloadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAudioFileDownloadInfoResponseBody self = new GetAudioFileDownloadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAudioFileDownloadInfoResponseBody setResult(GetAudioFileDownloadInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetAudioFileDownloadInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetAudioFileDownloadInfoResponseBodyResult extends TeaModel {
        @NameInMap("url")
        public String url;

        public static GetAudioFileDownloadInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAudioFileDownloadInfoResponseBodyResult self = new GetAudioFileDownloadInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAudioFileDownloadInfoResponseBodyResult setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
