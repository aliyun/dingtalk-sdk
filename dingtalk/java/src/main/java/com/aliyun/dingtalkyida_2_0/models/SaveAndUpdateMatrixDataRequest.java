// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class SaveAndUpdateMatrixDataRequest extends TeaModel {
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
     * <p>[{ 	&quot;column_xx&quot;: &quot;deptId&quot;, 	&quot;column_yy&quot;: [&quot;userId&quot;], 	&quot;column_zz&quot;: &quot;项目一&quot;, 	&quot;rowId&quot;: &quot;row_1748398062718&quot; }, { 	&quot;column_xx&quot;: &quot;deptId&quot;, 	&quot;column_yy&quot;: [&quot;userId&quot;, &quot;userId&quot;], 	&quot;column_zz&quot;: &quot;项目二&quot; }]</p>
     */
    @NameInMap("dataJson")
    public String dataJson;

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

    public static SaveAndUpdateMatrixDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveAndUpdateMatrixDataRequest self = new SaveAndUpdateMatrixDataRequest();
        return TeaModel.build(map, self);
    }

    public SaveAndUpdateMatrixDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveAndUpdateMatrixDataRequest setDataJson(String dataJson) {
        this.dataJson = dataJson;
        return this;
    }
    public String getDataJson() {
        return this.dataJson;
    }

    public SaveAndUpdateMatrixDataRequest setMatrixId(String matrixId) {
        this.matrixId = matrixId;
        return this;
    }
    public String getMatrixId() {
        return this.matrixId;
    }

    public SaveAndUpdateMatrixDataRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public SaveAndUpdateMatrixDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
