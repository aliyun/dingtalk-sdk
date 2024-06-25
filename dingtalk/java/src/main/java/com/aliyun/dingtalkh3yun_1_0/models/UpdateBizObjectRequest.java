// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class UpdateBizObjectRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ceeb5ad3-b6da-4d4d-b6a5-8d342567d189</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{     &quot;F0000010&quot;: &quot;0001111&quot;,     &quot;F0000011&quot;: &quot;王五&quot;,     &quot;F0000012&quot;: &quot;D1级客户&quot;,     &quot;F0000013&quot;: 7000,     &quot;D000183Fcd15f3a51e624bbc9945392d190b6aa8&quot;: [         {             &quot;F0000014&quot;: &quot;里斯&quot;,             &quot;F0000015&quot;: &quot;156********&quot;,             &quot;F0000016&quot;: &quot;技术部&quot;,             &quot;F0000017&quot;: &quot;经理&quot;,             &quot;F0000018&quot;: &quot;男&quot;,             &quot;F0000019&quot;: &quot;<a href="mailto:lgbxunmi@dd.com">lgbxunmi@dd.com</a>&quot;,             &quot;F0000020&quot;: true,             &quot;F0000021&quot;: &quot;无&quot;         }     ] }</p>
     */
    @NameInMap("bizObjectJson")
    public String bizObjectJson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001839bbbbe346bbf496498bb76c44c7eb972</p>
     */
    @NameInMap("schemaCode")
    public String schemaCode;

    public static UpdateBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateBizObjectRequest self = new UpdateBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public UpdateBizObjectRequest setBizObjectId(String bizObjectId) {
        this.bizObjectId = bizObjectId;
        return this;
    }
    public String getBizObjectId() {
        return this.bizObjectId;
    }

    public UpdateBizObjectRequest setBizObjectJson(String bizObjectJson) {
        this.bizObjectJson = bizObjectJson;
        return this;
    }
    public String getBizObjectJson() {
        return this.bizObjectJson;
    }

    public UpdateBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
