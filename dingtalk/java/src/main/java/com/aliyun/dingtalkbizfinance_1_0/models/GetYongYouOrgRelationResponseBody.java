// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetYongYouOrgRelationResponseBody extends TeaModel {
    @NameInMap("chanjetCorpId")
    public String chanjetCorpId;

    @NameInMap("chanjetUserId")
    public String chanjetUserId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("userId")
    public String userId;

    public static GetYongYouOrgRelationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetYongYouOrgRelationResponseBody self = new GetYongYouOrgRelationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetYongYouOrgRelationResponseBody setChanjetCorpId(String chanjetCorpId) {
        this.chanjetCorpId = chanjetCorpId;
        return this;
    }
    public String getChanjetCorpId() {
        return this.chanjetCorpId;
    }

    public GetYongYouOrgRelationResponseBody setChanjetUserId(String chanjetUserId) {
        this.chanjetUserId = chanjetUserId;
        return this;
    }
    public String getChanjetUserId() {
        return this.chanjetUserId;
    }

    public GetYongYouOrgRelationResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetYongYouOrgRelationResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
