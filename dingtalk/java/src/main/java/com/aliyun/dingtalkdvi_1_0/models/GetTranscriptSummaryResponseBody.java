// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetTranscriptSummaryResponseBody extends TeaModel {
    @NameInMap("result")
    public GetTranscriptSummaryResponseBodyResult result;

    public static GetTranscriptSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTranscriptSummaryResponseBody self = new GetTranscriptSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTranscriptSummaryResponseBody setResult(GetTranscriptSummaryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTranscriptSummaryResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetTranscriptSummaryResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        public static GetTranscriptSummaryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTranscriptSummaryResponseBodyResult self = new GetTranscriptSummaryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTranscriptSummaryResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

    }

}
