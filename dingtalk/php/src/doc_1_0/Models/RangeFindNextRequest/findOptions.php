<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\RangeFindNextRequest;

use AlibabaCloud\Tea\Model;

class findOptions extends Model
{
    /**
     * @description 匹配大小写
     *
     * @var bool
     */
    public $matchCase;

    /**
     * @description 匹配整个单元格
     *
     * @var bool
     */
    public $matchEntireCell;

    /**
     * @description 在公式内搜索
     *
     * @var bool
     */
    public $matchFormulaText;

    /**
     * @description text是正则表达式
     *
     * @var bool
     */
    public $useRegExp;
    protected $_name = [
        'matchCase'        => 'matchCase',
        'matchEntireCell'  => 'matchEntireCell',
        'matchFormulaText' => 'matchFormulaText',
        'useRegExp'        => 'useRegExp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->matchCase) {
            $res['matchCase'] = $this->matchCase;
        }
        if (null !== $this->matchEntireCell) {
            $res['matchEntireCell'] = $this->matchEntireCell;
        }
        if (null !== $this->matchFormulaText) {
            $res['matchFormulaText'] = $this->matchFormulaText;
        }
        if (null !== $this->useRegExp) {
            $res['useRegExp'] = $this->useRegExp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return findOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['matchCase'])) {
            $model->matchCase = $map['matchCase'];
        }
        if (isset($map['matchEntireCell'])) {
            $model->matchEntireCell = $map['matchEntireCell'];
        }
        if (isset($map['matchFormulaText'])) {
            $model->matchFormulaText = $map['matchFormulaText'];
        }
        if (isset($map['useRegExp'])) {
            $model->useRegExp = $map['useRegExp'];
        }

        return $model;
    }
}
