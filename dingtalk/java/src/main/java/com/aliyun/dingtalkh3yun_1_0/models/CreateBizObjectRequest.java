// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateBizObjectRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;F0000010&quot;: &quot;0000004&quot;, &quot;F0000011&quot;: &quot;王五1&quot;,&quot;F0000012&quot;: &quot;D1级客户&quot;,&quot;F0000013&quot;: 7000,&quot;D000183Fcd15f3a51e624bbc9945392d190b6aa8&quot;: [{&quot;F0000014&quot;: &quot;里斯&quot;,&quot;F0000015&quot;: 156666365656, &quot;F0000016&quot;: &quot;技术部&quot;,&quot;F0000017&quot;: &quot;经理1&quot;,&quot;F0000018&quot;:&quot;男&quot;,&quot;F0000019&quot;: &quot;<a href="mailto:lgbxunmi@dd.com">lgbxunmi@dd.com</a>&quot;, &quot;F0000020&quot;: true, &quot;F0000021&quot;: &quot;测试数据&quot;}]}</p>
     */
    @NameInMap("bizObjectJson")
    public String bizObjectJson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isDraft")
    public Boolean isDraft;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>aea4d7a7-d162-4c77-9c44-7bd9cb8316a5</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001839bbbbe346bbf496498bb76c44c7eb972</p>
     */
    @NameInMap("schemaCode")
    public String schemaCode;

    public static CreateBizObjectRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBizObjectRequest self = new CreateBizObjectRequest();
        return TeaModel.build(map, self);
    }

    public CreateBizObjectRequest setBizObjectJson(String bizObjectJson) {
        this.bizObjectJson = bizObjectJson;
        return this;
    }
    public String getBizObjectJson() {
        return this.bizObjectJson;
    }

    public CreateBizObjectRequest setIsDraft(Boolean isDraft) {
        this.isDraft = isDraft;
        return this;
    }
    public Boolean getIsDraft() {
        return this.isDraft;
    }

    public CreateBizObjectRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CreateBizObjectRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
