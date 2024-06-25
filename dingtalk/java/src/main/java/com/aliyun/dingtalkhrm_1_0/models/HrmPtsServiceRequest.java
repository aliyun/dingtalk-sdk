// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmPtsServiceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dev  or online</p>
     */
    @NameInMap("env")
    public String env;

    /**
     * <strong>example:</strong>
     * <p>GET/POST</p>
     */
    @NameInMap("method")
    public String method;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abd123213</p>
     */
    @NameInMap("outerId")
    public String outerId;

    @NameInMap("params")
    public Object params;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>/user/role/get</p>
     */
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

    public HrmPtsServiceRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
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
