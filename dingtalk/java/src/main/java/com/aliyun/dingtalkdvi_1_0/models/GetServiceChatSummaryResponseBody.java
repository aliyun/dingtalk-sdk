// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceChatSummaryResponseBody extends TeaModel {
    @NameInMap("result")
    public GetServiceChatSummaryResponseBodyResult result;

    public static GetServiceChatSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetServiceChatSummaryResponseBody self = new GetServiceChatSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetServiceChatSummaryResponseBody setResult(GetServiceChatSummaryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetServiceChatSummaryResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetServiceChatSummaryResponseBodyResultBasic extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("name")
        public String name;

        public static GetServiceChatSummaryResponseBodyResultBasic build(java.util.Map<String, ?> map) throws Exception {
            GetServiceChatSummaryResponseBodyResultBasic self = new GetServiceChatSummaryResponseBodyResultBasic();
            return TeaModel.build(map, self);
        }

        public GetServiceChatSummaryResponseBodyResultBasic setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetServiceChatSummaryResponseBodyResultBasic setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetServiceChatSummaryResponseBodyResultProductItemList extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("name")
        public String name;

        public static GetServiceChatSummaryResponseBodyResultProductItemList build(java.util.Map<String, ?> map) throws Exception {
            GetServiceChatSummaryResponseBodyResultProductItemList self = new GetServiceChatSummaryResponseBodyResultProductItemList();
            return TeaModel.build(map, self);
        }

        public GetServiceChatSummaryResponseBodyResultProductItemList setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetServiceChatSummaryResponseBodyResultProductItemList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class GetServiceChatSummaryResponseBodyResultProduct extends TeaModel {
        @NameInMap("itemList")
        public java.util.List<GetServiceChatSummaryResponseBodyResultProductItemList> itemList;

        @NameInMap("product")
        public String product;

        public static GetServiceChatSummaryResponseBodyResultProduct build(java.util.Map<String, ?> map) throws Exception {
            GetServiceChatSummaryResponseBodyResultProduct self = new GetServiceChatSummaryResponseBodyResultProduct();
            return TeaModel.build(map, self);
        }

        public GetServiceChatSummaryResponseBodyResultProduct setItemList(java.util.List<GetServiceChatSummaryResponseBodyResultProductItemList> itemList) {
            this.itemList = itemList;
            return this;
        }
        public java.util.List<GetServiceChatSummaryResponseBodyResultProductItemList> getItemList() {
            return this.itemList;
        }

        public GetServiceChatSummaryResponseBodyResultProduct setProduct(String product) {
            this.product = product;
            return this;
        }
        public String getProduct() {
            return this.product;
        }

    }

    public static class GetServiceChatSummaryResponseBodyResult extends TeaModel {
        @NameInMap("basic")
        public java.util.List<GetServiceChatSummaryResponseBodyResultBasic> basic;

        @NameInMap("product")
        public java.util.List<GetServiceChatSummaryResponseBodyResultProduct> product;

        public static GetServiceChatSummaryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetServiceChatSummaryResponseBodyResult self = new GetServiceChatSummaryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetServiceChatSummaryResponseBodyResult setBasic(java.util.List<GetServiceChatSummaryResponseBodyResultBasic> basic) {
            this.basic = basic;
            return this;
        }
        public java.util.List<GetServiceChatSummaryResponseBodyResultBasic> getBasic() {
            return this.basic;
        }

        public GetServiceChatSummaryResponseBodyResult setProduct(java.util.List<GetServiceChatSummaryResponseBodyResultProduct> product) {
            this.product = product;
            return this;
        }
        public java.util.List<GetServiceChatSummaryResponseBodyResultProduct> getProduct() {
            return this.product;
        }

    }

}
