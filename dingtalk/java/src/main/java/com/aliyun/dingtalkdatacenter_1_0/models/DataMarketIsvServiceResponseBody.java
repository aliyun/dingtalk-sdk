// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class DataMarketIsvServiceResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public String data;

    @NameInMap("msg")
    public String msg;

    public static DataMarketIsvServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DataMarketIsvServiceResponseBody self = new DataMarketIsvServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public DataMarketIsvServiceResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DataMarketIsvServiceResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public DataMarketIsvServiceResponseBody setMsg(String msg) {
        this.msg = msg;
        return this;
    }
    public String getMsg() {
        return this.msg;
    }

}
