// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmPtsServiceRequest extends TeaModel {
    @NameInMap("env")
    public String env;

    @NameInMap("method")
    public String method;

    @NameInMap("params")
    public Object params;

    @NameInMap("path")
    public String path;

    public static HrmPtsServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmPtsServiceRequest self = new HrmPtsServiceRequest();
        return TeaModel.build(map, self);
    }

    public HrmPtsServiceRequest setEnv(String env) {
        this.env = env;
        return this;
    }
    public String getEnv() {
        return this.env;
    }

    public HrmPtsServiceRequest setMethod(String method) {
        this.method = method;
        return this;
    }
    public String getMethod() {
        return this.method;
    }

    public HrmPtsServiceRequest setParams(Object params) {
        this.params = params;
        return this;
    }
    public Object getParams() {
        return this.params;
    }

    public HrmPtsServiceRequest setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

}
