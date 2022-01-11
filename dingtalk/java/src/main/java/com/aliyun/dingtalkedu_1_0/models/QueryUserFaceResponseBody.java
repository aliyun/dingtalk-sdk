// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFaceResponseBody extends TeaModel {
    // 组织id
    @NameInMap("corpId")
    public String corpId;

    // 人脸id
    @NameInMap("faceId")
    public String faceId;

    // 员工姓名
    @NameInMap("name")
    public String name;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static QueryUserFaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserFaceResponseBody self = new QueryUserFaceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserFaceResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryUserFaceResponseBody setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public QueryUserFaceResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public QueryUserFaceResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
