// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocContentRequest extends TeaModel {
    @NameInMap("option")
    public DocContentRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DocContentRequest build(java.util.Map<String, ?> map) throws Exception {
        DocContentRequest self = new DocContentRequest();
        return TeaModel.build(map, self);
    }

    public DocContentRequest setOption(DocContentRequestOption option) {
        this.option = option;
        return this;
    }
    public DocContentRequestOption getOption() {
        return this.option;
    }

    public DocContentRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class DocContentRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>markdown</p>
         */
        @NameInMap("targetFormat")
        public String targetFormat;

        public static DocContentRequestOption build(java.util.Map<String, ?> map) throws Exception {
            DocContentRequestOption self = new DocContentRequestOption();
            return TeaModel.build(map, self);
        }

        public DocContentRequestOption setTargetFormat(String targetFormat) {
            this.targetFormat = targetFormat;
            return this;
        }
        public String getTargetFormat() {
            return this.targetFormat;
        }

    }

}
