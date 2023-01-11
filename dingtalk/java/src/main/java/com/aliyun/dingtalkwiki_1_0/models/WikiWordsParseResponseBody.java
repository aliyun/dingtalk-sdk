// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0.models;

import com.aliyun.tea.*;

public class WikiWordsParseResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<WikiWordsParseResponseBodyData> data;

    @NameInMap("errMsg")
    public String errMsg;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static WikiWordsParseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WikiWordsParseResponseBody self = new WikiWordsParseResponseBody();
        return TeaModel.build(map, self);
    }

    public WikiWordsParseResponseBody setData(java.util.List<WikiWordsParseResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<WikiWordsParseResponseBodyData> getData() {
        return this.data;
    }

    public WikiWordsParseResponseBody setErrMsg(String errMsg) {
        this.errMsg = errMsg;
        return this;
    }
    public String getErrMsg() {
        return this.errMsg;
    }

    public WikiWordsParseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class WikiWordsParseResponseBodyData extends TeaModel {
        @NameInMap("endIndex")
        public Long endIndex;

        @NameInMap("startIndex")
        public Long startIndex;

        @NameInMap("wordName")
        public String wordName;

        public static WikiWordsParseResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            WikiWordsParseResponseBodyData self = new WikiWordsParseResponseBodyData();
            return TeaModel.build(map, self);
        }

        public WikiWordsParseResponseBodyData setEndIndex(Long endIndex) {
            this.endIndex = endIndex;
            return this;
        }
        public Long getEndIndex() {
            return this.endIndex;
        }

        public WikiWordsParseResponseBodyData setStartIndex(Long startIndex) {
            this.startIndex = startIndex;
            return this;
        }
        public Long getStartIndex() {
            return this.startIndex;
        }

        public WikiWordsParseResponseBodyData setWordName(String wordName) {
            this.wordName = wordName;
            return this;
        }
        public String getWordName() {
            return this.wordName;
        }

    }

}
