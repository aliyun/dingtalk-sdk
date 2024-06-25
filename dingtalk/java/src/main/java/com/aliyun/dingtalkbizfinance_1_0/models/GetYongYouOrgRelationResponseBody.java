// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetYongYouOrgRelationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>20230731</p>
     */
    @NameInMap("chanjetCorpId")
    public String chanjetCorpId;

    /**
     * <strong>example:</strong>
     * <p>01162352501424064728</p>
     */
    @NameInMap("chanjetUserId")
    public String chanjetUserId;

    /**
     * <strong>example:</strong>
     * <p>ding9f50b15bccd16741</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>01162352501424064728</p>
     */
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
