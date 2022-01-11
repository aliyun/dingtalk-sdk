// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetExecuteUrlResponseBody extends TeaModel {
    @NameInMap("longUrl")
    public String longUrl;

    @NameInMap("mobileUrl")
    public String mobileUrl;

    @NameInMap("pcUrl")
    public String pcUrl;

    @NameInMap("shortUrl")
    public String shortUrl;

    public static GetExecuteUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetExecuteUrlResponseBody self = new GetExecuteUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetExecuteUrlResponseBody setLongUrl(String longUrl) {
        this.longUrl = longUrl;
        return this;
    }
    public String getLongUrl() {
        return this.longUrl;
    }

    public GetExecuteUrlResponseBody setMobileUrl(String mobileUrl) {
        this.mobileUrl = mobileUrl;
        return this;
    }
    public String getMobileUrl() {
        return this.mobileUrl;
    }

    public GetExecuteUrlResponseBody setPcUrl(String pcUrl) {
        this.pcUrl = pcUrl;
        return this;
    }
    public String getPcUrl() {
        return this.pcUrl;
    }

    public GetExecuteUrlResponseBody setShortUrl(String shortUrl) {
        this.shortUrl = shortUrl;
        return this;
    }
    public String getShortUrl() {
        return this.shortUrl;
    }

}
