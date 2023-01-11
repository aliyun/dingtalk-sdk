// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetSchemaResponseBody extends TeaModel {
    /**
     * <p>当前版本。</p>
     */
    @NameInMap("revision")
    public Integer revision;

    /**
     * <p>schema内容。</p>
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
