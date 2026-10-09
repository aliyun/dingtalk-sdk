// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.domain20180129.models;

import com.aliyun.tea.*;

public class GetIntlFixPriceDomainListUrlResponseBody extends TeaModel {
    @NameInMap("Module")
    public GetIntlFixPriceDomainListUrlResponseBodyModule module;

    @NameInMap("RequestId")
    public String requestId;

    public static GetIntlFixPriceDomainListUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetIntlFixPriceDomainListUrlResponseBody self = new GetIntlFixPriceDomainListUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetIntlFixPriceDomainListUrlResponseBody setModule(GetIntlFixPriceDomainListUrlResponseBodyModule module) {
        this.module = module;
        return this;
    }
    public GetIntlFixPriceDomainListUrlResponseBodyModule getModule() {
        return this.module;
    }

    public GetIntlFixPriceDomainListUrlResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetIntlFixPriceDomainListUrlResponseBodyModule extends TeaModel {
        @NameInMap("DownloadUrl")
        public String downloadUrl;

        public static GetIntlFixPriceDomainListUrlResponseBodyModule build(java.util.Map<String, ?> map) throws Exception {
            GetIntlFixPriceDomainListUrlResponseBodyModule self = new GetIntlFixPriceDomainListUrlResponseBodyModule();
            return TeaModel.build(map, self);
        }

        public GetIntlFixPriceDomainListUrlResponseBodyModule setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

    }

}
