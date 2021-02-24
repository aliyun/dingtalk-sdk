// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class BizGenericParametersValue extends TeaModel {
    @NameInMap("param")
    public String param;

    public static BizGenericParametersValue build(java.util.Map<String, ?> map) throws Exception {
        BizGenericParametersValue self = new BizGenericParametersValue();
        return TeaModel.build(map, self);
    }

    public BizGenericParametersValue setParam(String param) {
        this.param = param;
        return this;
    }
    public String getParam() {
        return this.param;
    }

}
