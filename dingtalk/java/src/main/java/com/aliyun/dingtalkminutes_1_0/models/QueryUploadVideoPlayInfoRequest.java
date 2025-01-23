// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryUploadVideoPlayInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryUploadVideoPlayInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUploadVideoPlayInfoRequest self = new QueryUploadVideoPlayInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryUploadVideoPlayInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
