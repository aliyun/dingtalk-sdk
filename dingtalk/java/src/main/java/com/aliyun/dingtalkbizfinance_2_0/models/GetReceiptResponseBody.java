// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetReceiptResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("appId")
    public String appId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;operatorUserId&quot;:&quot;015865244722391178&quot;,&quot;data&quot;:{&quot;amount&quot;:{&quot;amountStr&quot;:&quot;566&quot;},&quot;code&quot;:&quot;d0d54815-32c5-4b18-8391-e79713bba95e&quot;,&quot;payeeAt&quot;:1637251200000,&quot;departmentCode&quot;:&quot;-1&quot;,&quot;project&quot;:{&quot;projectCode&quot;:&quot;PROJ_101761F3FF6B21362ECA000N&quot;,&quot;projectName&quot;:&quot;客户合作项目&quot;},&quot;principalId&quot;:&quot;015865244722391178&quot;,&quot;enterpriseAccount&quot;:{},&quot;approvedAt&quot;:1637305373000,&quot;title&quot;:&quot;地狱猫提交的智能财务-收款&quot;,&quot;createAt&quot;:1637305353000,&quot;paymentAt&quot;:1637251200000,&quot;supplier&quot;:{},&quot;operateUserId&quot;:&quot;015865244722391178&quot;,&quot;applicantEmployeeId&quot;:&quot;015865244722391178&quot;,&quot;comment&quot;:&quot;ffff&quot;,&quot;category&quot;:{&quot;categoryCode&quot;:&quot;INC_1016D6CB3C181E28F0120009&quot;,&quot;categoryName&quot;:&quot;销售收入&quot;},&quot;customer&quot;:{&quot;customerCode&quot;:&quot;CUS_10178592ECEC2133C893000F&quot;,&quot;customerName&quot;:&quot;钉钉&quot;},&quot;status&quot;:&quot;agree&quot;}}</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>EM-1017F28E03350B1738B3000X</p>
     */
    @NameInMap("modelId")
    public String modelId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>approval</p>
     */
    @NameInMap("source")
    public String source;

    public static GetReceiptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetReceiptResponseBody self = new GetReceiptResponseBody();
        return TeaModel.build(map, self);
    }

    public GetReceiptResponseBody setAppId(String appId) {
        this.appId = appId;
        return this;
    }
    public String getAppId() {
        return this.appId;
    }

    public GetReceiptResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetReceiptResponseBody setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

    public GetReceiptResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

}
