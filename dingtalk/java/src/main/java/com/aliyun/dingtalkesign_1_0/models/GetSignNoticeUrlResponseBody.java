// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetSignNoticeUrlResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public GetSignNoticeUrlResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetSignNoticeUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignNoticeUrlResponseBody self = new GetSignNoticeUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignNoticeUrlResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetSignNoticeUrlResponseBody setData(GetSignNoticeUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetSignNoticeUrlResponseBodyData getData() {
        return this.data;
    }

    public GetSignNoticeUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetSignNoticeUrlResponseBodyData extends TeaModel {
        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        public static GetSignNoticeUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetSignNoticeUrlResponseBodyData self = new GetSignNoticeUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetSignNoticeUrlResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetSignNoticeUrlResponseBodyData setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

}
