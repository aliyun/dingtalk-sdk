// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class BizContextValue extends TeaModel {
    @NameInMap("param")
    public String param;

    public static BizContextValue build(java.util.Map<String, ?> map) throws Exception {
        BizContextValue self = new BizContextValue();
        return TeaModel.build(map, self);
    }

    public BizContextValue setParam(String param) {
        this.param = param;
        return this;
    }
    public String getParam() {
        return this.param;
    }

}
