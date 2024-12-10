// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocSlotsModifyRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>contentBody</p>
     */
    @NameInMap("request")
    public java.util.List<DocSlotsModifyRequestRequest> request;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DocSlotsModifyRequest build(java.util.Map<String, ?> map) throws Exception {
        DocSlotsModifyRequest self = new DocSlotsModifyRequest();
        return TeaModel.build(map, self);
    }

    public DocSlotsModifyRequest setRequest(java.util.List<DocSlotsModifyRequestRequest> request) {
        this.request = request;
        return this;
    }
    public java.util.List<DocSlotsModifyRequestRequest> getRequest() {
        return this.request;
    }

    public DocSlotsModifyRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class DocSlotsModifyRequestRequest extends TeaModel {
        @NameInMap("body")
        public java.util.Map<String, ?> body;

        @NameInMap("slotId")
        public String slotId;

        public static DocSlotsModifyRequestRequest build(java.util.Map<String, ?> map) throws Exception {
            DocSlotsModifyRequestRequest self = new DocSlotsModifyRequestRequest();
            return TeaModel.build(map, self);
        }

        public DocSlotsModifyRequestRequest setBody(java.util.Map<String, ?> body) {
            this.body = body;
            return this;
        }
        public java.util.Map<String, ?> getBody() {
            return this.body;
        }

        public DocSlotsModifyRequestRequest setSlotId(String slotId) {
            this.slotId = slotId;
            return this;
        }
        public String getSlotId() {
            return this.slotId;
        }

    }

}
