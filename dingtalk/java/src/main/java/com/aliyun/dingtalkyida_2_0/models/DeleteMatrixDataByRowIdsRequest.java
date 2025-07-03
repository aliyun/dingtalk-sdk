// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class DeleteMatrixDataByRowIdsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>MATRIX-C8I4J40EM81XLWZH61ZK</p>
     */
    @NameInMap("matrixId")
    public String matrixId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("rowIds")
    public String rowIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("token")
    public String token;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>501453</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteMatrixDataByRowIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMatrixDataByRowIdsRequest self = new DeleteMatrixDataByRowIdsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMatrixDataByRowIdsRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public DeleteMatrixDataByRowIdsRequest setMatrixId(String matrixId) {
        this.matrixId = matrixId;
        return this;
    }
    public String getMatrixId() {
        return this.matrixId;
    }

    public DeleteMatrixDataByRowIdsRequest setRowIds(String rowIds) {
        this.rowIds = rowIds;
        return this;
    }
    public String getRowIds() {
        return this.rowIds;
    }

    public DeleteMatrixDataByRowIdsRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public DeleteMatrixDataByRowIdsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
