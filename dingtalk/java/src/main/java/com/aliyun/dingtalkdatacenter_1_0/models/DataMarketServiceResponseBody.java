// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class DataMarketServiceResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public String data;

    @NameInMap("msg")
    public String msg;

    @NameInMap("totalQuota")
    public Long totalQuota;

    @NameInMap("usedQuota")
    public Long usedQuota;

    public static DataMarketServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DataMarketServiceResponseBody self = new DataMarketServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public DataMarketServiceResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DataMarketServiceResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public DataMarketServiceResponseBody setMsg(String msg) {
        this.msg = msg;
        return this;
    }
    public String getMsg() {
        return this.msg;
    }

    public DataMarketServiceResponseBody setTotalQuota(Long totalQuota) {
        this.totalQuota = totalQuota;
        return this;
    }
    public Long getTotalQuota() {
        return this.totalQuota;
    }

    public DataMarketServiceResponseBody setUsedQuota(Long usedQuota) {
        this.usedQuota = usedQuota;
        return this;
    }
    public Long getUsedQuota() {
        return this.usedQuota;
    }

}
