// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetNavigationCatalogRequest extends TeaModel {
    @NameInMap("bizTraceId")
    public String bizTraceId;

    @NameInMap("module")
    public String module;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static GetNavigationCatalogRequest build(java.util.Map<String, ?> map) throws Exception {
        GetNavigationCatalogRequest self = new GetNavigationCatalogRequest();
        return TeaModel.build(map, self);
    }

    public GetNavigationCatalogRequest setBizTraceId(String bizTraceId) {
        this.bizTraceId = bizTraceId;
        return this;
    }
    public String getBizTraceId() {
        return this.bizTraceId;
    }

    public GetNavigationCatalogRequest setModule(String module) {
        this.module = module;
        return this;
    }
    public String getModule() {
        return this.module;
    }

    public GetNavigationCatalogRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
