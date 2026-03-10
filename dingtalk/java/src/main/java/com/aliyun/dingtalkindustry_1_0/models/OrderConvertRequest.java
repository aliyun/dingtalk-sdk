// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class OrderConvertRequest extends TeaModel {
    @NameInMap("attachments")
    public java.util.List<OrderConvertRequestAttachments> attachments;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ruleBizId")
    public String ruleBizId;

    public static OrderConvertRequest build(java.util.Map<String, ?> map) throws Exception {
        OrderConvertRequest self = new OrderConvertRequest();
        return TeaModel.build(map, self);
    }

    public OrderConvertRequest setAttachments(java.util.List<OrderConvertRequestAttachments> attachments) {
        this.attachments = attachments;
        return this;
    }
    public java.util.List<OrderConvertRequestAttachments> getAttachments() {
        return this.attachments;
    }

    public OrderConvertRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public OrderConvertRequest setRuleBizId(String ruleBizId) {
        this.ruleBizId = ruleBizId;
        return this;
    }
    public String getRuleBizId() {
        return this.ruleBizId;
    }

    public static class OrderConvertRequestAttachments extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fileUrl")
        public String fileUrl;

        public static OrderConvertRequestAttachments build(java.util.Map<String, ?> map) throws Exception {
            OrderConvertRequestAttachments self = new OrderConvertRequestAttachments();
            return TeaModel.build(map, self);
        }

        public OrderConvertRequestAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public OrderConvertRequestAttachments setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

    }

}
