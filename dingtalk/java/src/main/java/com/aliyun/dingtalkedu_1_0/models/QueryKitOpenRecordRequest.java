// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryKitOpenRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>ISV_XXX</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <strong>example:</strong>
     * <p>course</p>
     */
    @NameInMap("isvProductScene")
    public String isvProductScene;

    public static QueryKitOpenRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryKitOpenRecordRequest self = new QueryKitOpenRecordRequest();
        return TeaModel.build(map, self);
    }

    public QueryKitOpenRecordRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryKitOpenRecordRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public QueryKitOpenRecordRequest setIsvProductScene(String isvProductScene) {
        this.isvProductScene = isvProductScene;
        return this;
    }
    public String getIsvProductScene() {
        return this.isvProductScene;
    }

}
