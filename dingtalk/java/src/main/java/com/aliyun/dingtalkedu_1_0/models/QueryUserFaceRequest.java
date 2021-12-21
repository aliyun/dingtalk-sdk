// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFaceRequest extends TeaModel {
    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // 人脸id
    @NameInMap("faceId")
    public String faceId;

    public static QueryUserFaceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserFaceRequest self = new QueryUserFaceRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserFaceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QueryUserFaceRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

}
