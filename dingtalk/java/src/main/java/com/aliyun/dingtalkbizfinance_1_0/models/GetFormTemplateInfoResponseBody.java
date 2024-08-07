// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetFormTemplateInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receiptFormTemplateInfoList")
    public java.util.List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList> receiptFormTemplateInfoList;

    public static GetFormTemplateInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFormTemplateInfoResponseBody self = new GetFormTemplateInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFormTemplateInfoResponseBody setReceiptFormTemplateInfoList(java.util.List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList> receiptFormTemplateInfoList) {
        this.receiptFormTemplateInfoList = receiptFormTemplateInfoList;
        return this;
    }
    public java.util.List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList> getReceiptFormTemplateInfoList() {
        return this.receiptFormTemplateInfoList;
    }

    public static class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>&quot;100&quot;</p>
         */
        @NameInMap("bindingVal")
        public String bindingVal;

        /**
         * <strong>example:</strong>
         * <p>&quot;xxx&quot;</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>&quot;报销金额&quot;</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>&quot;amount&quot;</p>
         */
        @NameInMap("type")
        public String type;

        public static GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList build(java.util.Map<String, ?> map) throws Exception {
            GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList self = new GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList();
            return TeaModel.build(map, self);
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList setBindingVal(String bindingVal) {
            this.bindingVal = bindingVal;
            return this;
        }
        public String getBindingVal() {
            return this.bindingVal;
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList extends TeaModel {
        @NameInMap("componentList")
        public java.util.List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList> componentList;

        /**
         * <strong>example:</strong>
         * <p>&quot;报销套件&quot;</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>&quot;PROC-EB81447A-B0E3-4A2F-A719-0A85EFD09184&quot;</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <strong>example:</strong>
         * <p>&quot;invalid&quot;</p>
         */
        @NameInMap("status")
        public String status;

        @NameInMap("suiteId")
        public String suiteId;

        public static GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList build(java.util.Map<String, ?> map) throws Exception {
            GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList self = new GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList();
            return TeaModel.build(map, self);
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList setComponentList(java.util.List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList> componentList) {
            this.componentList = componentList;
            return this;
        }
        public java.util.List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList> getComponentList() {
            return this.componentList;
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList setSuiteId(String suiteId) {
            this.suiteId = suiteId;
            return this;
        }
        public String getSuiteId() {
            return this.suiteId;
        }

    }

}
