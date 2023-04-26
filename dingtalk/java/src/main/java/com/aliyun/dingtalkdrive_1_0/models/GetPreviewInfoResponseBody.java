// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetPreviewInfoResponseBody extends TeaModel {
    @NameInMap("info")
    public GetPreviewInfoResponseBodyInfo info;

    public static GetPreviewInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPreviewInfoResponseBody self = new GetPreviewInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPreviewInfoResponseBody setInfo(GetPreviewInfoResponseBodyInfo info) {
        this.info = info;
        return this;
    }
    public GetPreviewInfoResponseBodyInfo getInfo() {
        return this.info;
    }

    public static class GetPreviewInfoResponseBodyInfo extends TeaModel {
        @NameInMap("url")
        public String url;

        public static GetPreviewInfoResponseBodyInfo build(java.util.Map<String, ?> map) throws Exception {
            GetPreviewInfoResponseBodyInfo self = new GetPreviewInfoResponseBodyInfo();
            return TeaModel.build(map, self);
        }

        public GetPreviewInfoResponseBodyInfo setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
