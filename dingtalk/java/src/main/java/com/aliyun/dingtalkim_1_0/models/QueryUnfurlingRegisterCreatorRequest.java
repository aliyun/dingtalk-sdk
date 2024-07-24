// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnfurlingRegisterCreatorRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
     */
    @NameInMap("domain")
    public String domain;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>/a</p>
     */
    @NameInMap("path")
    public String path;

    public static QueryUnfurlingRegisterCreatorRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUnfurlingRegisterCreatorRequest self = new QueryUnfurlingRegisterCreatorRequest();
        return TeaModel.build(map, self);
    }

    public QueryUnfurlingRegisterCreatorRequest setDomain(String domain) {
        this.domain = domain;
        return this;
    }
    public String getDomain() {
        return this.domain;
    }

    public QueryUnfurlingRegisterCreatorRequest setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

}
