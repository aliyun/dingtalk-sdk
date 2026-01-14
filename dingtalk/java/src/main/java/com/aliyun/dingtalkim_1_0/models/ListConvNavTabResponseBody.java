// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListConvNavTabResponseBody extends TeaModel {
    @NameInMap("result")
    public ListConvNavTabResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static ListConvNavTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListConvNavTabResponseBody self = new ListConvNavTabResponseBody();
        return TeaModel.build(map, self);
    }

    public ListConvNavTabResponseBody setResult(ListConvNavTabResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListConvNavTabResponseBodyResult getResult() {
        return this.result;
    }

    public ListConvNavTabResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class ListConvNavTabResponseBodyResultConvNavTabInfos extends TeaModel {
        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("tabId")
        public String tabId;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public String type;

        @NameInMap("userEditable")
        public Boolean userEditable;

        public static ListConvNavTabResponseBodyResultConvNavTabInfos build(java.util.Map<String, ?> map) throws Exception {
            ListConvNavTabResponseBodyResultConvNavTabInfos self = new ListConvNavTabResponseBodyResultConvNavTabInfos();
            return TeaModel.build(map, self);
        }

        public ListConvNavTabResponseBodyResultConvNavTabInfos setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public ListConvNavTabResponseBodyResultConvNavTabInfos setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public ListConvNavTabResponseBodyResultConvNavTabInfos setTabId(String tabId) {
            this.tabId = tabId;
            return this;
        }
        public String getTabId() {
            return this.tabId;
        }

        public ListConvNavTabResponseBodyResultConvNavTabInfos setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ListConvNavTabResponseBodyResultConvNavTabInfos setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListConvNavTabResponseBodyResultConvNavTabInfos setUserEditable(Boolean userEditable) {
            this.userEditable = userEditable;
            return this;
        }
        public Boolean getUserEditable() {
            return this.userEditable;
        }

    }

    public static class ListConvNavTabResponseBodyResult extends TeaModel {
        @NameInMap("convNavTabInfos")
        public java.util.List<ListConvNavTabResponseBodyResultConvNavTabInfos> convNavTabInfos;

        public static ListConvNavTabResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListConvNavTabResponseBodyResult self = new ListConvNavTabResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListConvNavTabResponseBodyResult setConvNavTabInfos(java.util.List<ListConvNavTabResponseBodyResultConvNavTabInfos> convNavTabInfos) {
            this.convNavTabInfos = convNavTabInfos;
            return this;
        }
        public java.util.List<ListConvNavTabResponseBodyResultConvNavTabInfos> getConvNavTabInfos() {
            return this.convNavTabInfos;
        }

    }

}
