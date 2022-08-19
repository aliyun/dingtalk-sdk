// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class RangeFindNextRequest extends TeaModel {
    // 查找选项
    @NameInMap("findOptions")
    public RangeFindNextRequestFindOptions findOptions;

    // 要查找的文本
    @NameInMap("text")
    public String text;

    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static RangeFindNextRequest build(java.util.Map<String, ?> map) throws Exception {
        RangeFindNextRequest self = new RangeFindNextRequest();
        return TeaModel.build(map, self);
    }

    public RangeFindNextRequest setFindOptions(RangeFindNextRequestFindOptions findOptions) {
        this.findOptions = findOptions;
        return this;
    }
    public RangeFindNextRequestFindOptions getFindOptions() {
        return this.findOptions;
    }

    public RangeFindNextRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public RangeFindNextRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class RangeFindNextRequestFindOptions extends TeaModel {
        @NameInMap("includeHidden")
        public Boolean includeHidden;

        // 匹配大小写
        @NameInMap("matchCase")
        public Boolean matchCase;

        // 匹配整个单元格
        @NameInMap("matchEntireCell")
        public Boolean matchEntireCell;

        // 在公式内搜索
        @NameInMap("matchFormulaText")
        public Boolean matchFormulaText;

        @NameInMap("scope")
        public String scope;

        // text是正则表达式
        @NameInMap("useRegExp")
        public Boolean useRegExp;

        public static RangeFindNextRequestFindOptions build(java.util.Map<String, ?> map) throws Exception {
            RangeFindNextRequestFindOptions self = new RangeFindNextRequestFindOptions();
            return TeaModel.build(map, self);
        }

        public RangeFindNextRequestFindOptions setIncludeHidden(Boolean includeHidden) {
            this.includeHidden = includeHidden;
            return this;
        }
        public Boolean getIncludeHidden() {
            return this.includeHidden;
        }

        public RangeFindNextRequestFindOptions setMatchCase(Boolean matchCase) {
            this.matchCase = matchCase;
            return this;
        }
        public Boolean getMatchCase() {
            return this.matchCase;
        }

        public RangeFindNextRequestFindOptions setMatchEntireCell(Boolean matchEntireCell) {
            this.matchEntireCell = matchEntireCell;
            return this;
        }
        public Boolean getMatchEntireCell() {
            return this.matchEntireCell;
        }

        public RangeFindNextRequestFindOptions setMatchFormulaText(Boolean matchFormulaText) {
            this.matchFormulaText = matchFormulaText;
            return this;
        }
        public Boolean getMatchFormulaText() {
            return this.matchFormulaText;
        }

        public RangeFindNextRequestFindOptions setScope(String scope) {
            this.scope = scope;
            return this;
        }
        public String getScope() {
            return this.scope;
        }

        public RangeFindNextRequestFindOptions setUseRegExp(Boolean useRegExp) {
            this.useRegExp = useRegExp;
            return this;
        }
        public Boolean getUseRegExp() {
            return this.useRegExp;
        }

    }

}
