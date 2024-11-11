// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTransferCourseRequest extends TeaModel {
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
     * <p>recordId</p>
     */
    @NameInMap("isvRecordId")
    public String isvRecordId;

    public static QueryTransferCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTransferCourseRequest self = new QueryTransferCourseRequest();
        return TeaModel.build(map, self);
    }

    public QueryTransferCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryTransferCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public QueryTransferCourseRequest setIsvRecordId(String isvRecordId) {
        this.isvRecordId = isvRecordId;
        return this;
    }
    public String getIsvRecordId() {
        return this.isvRecordId;
    }

}
