// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUserPayInfoRequest extends TeaModel {
    /**
     * <p>人脸id</p>
     */
    @NameInMap("faceId")
    public String faceId;

    /**
     * <p>设备id</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>员工id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryUserPayInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserPayInfoRequest self = new QueryUserPayInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserPayInfoRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public QueryUserPayInfoRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QueryUserPayInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
