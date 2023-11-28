// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetFormTemplateInfoResponseBody extends TeaModel {
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

    public static class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("status")
        public String status;

        @NameInMap("suiteId")
        public String suiteId;

        public static GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList build(java.util.Map<String, ?> map) throws Exception {
            GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList self = new GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList();
            return TeaModel.build(map, self);
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
