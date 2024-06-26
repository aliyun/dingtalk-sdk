// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetSchemaResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("revision")
    public Integer revision;

    /**
     * <strong>example:</strong>
     * <p>&quot;{&quot;pageVersion&quot;:&quot;1.0.0&quot;,&quot;pageSchema&quot;:{&quot;version&quot;:&quot;1.0.0&quot;,&quot;componentsMap&quot;:[],&quot;componentsTree&quot;:[]}}&quot;</p>
     */
    @NameInMap("value")
    public String value;

    public static GetSchemaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSchemaResponseBody self = new GetSchemaResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSchemaResponseBody setRevision(Integer revision) {
        this.revision = revision;
        return this;
    }
    public Integer getRevision() {
        return this.revision;
    }

    public GetSchemaResponseBody setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

}
