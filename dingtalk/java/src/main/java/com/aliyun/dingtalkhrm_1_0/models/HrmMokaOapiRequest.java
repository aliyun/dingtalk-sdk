// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMokaOapiRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>/user/role/get</p>
     */
    @NameInMap("apiCode")
    public String apiCode;

    @NameInMap("params")
    public Object params;

    public static HrmMokaOapiRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmMokaOapiRequest self = new HrmMokaOapiRequest();
        return TeaModel.build(map, self);
    }

    public HrmMokaOapiRequest setApiCode(String apiCode) {
        this.apiCode = apiCode;
        return this;
    }
    public String getApiCode() {
        return this.apiCode;
    }

    public HrmMokaOapiRequest setParams(Object params) {
        this.params = params;
        return this;
    }
    public Object getParams() {
        return this.params;
    }

}
