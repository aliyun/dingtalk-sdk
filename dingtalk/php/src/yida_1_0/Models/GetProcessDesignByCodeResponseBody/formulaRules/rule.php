<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\formulaRules;

use AlibabaCloud\Tea\Model;

class rule extends Model
{
    /**
     * @example EQ(#{textField_xxx},1)
     *
     * @var string
     */
    public $content;

    /**
     * @example EQ(单行文本,1)
     *
     * @var string
     */
    public $displayRule;

    /**
     * @example EQ(#{textField_xxx},1)
     *
     * @var string
     */
    public $source;
    protected $_name = [
        'content' => 'content',
        'displayRule' => 'displayRule',
        'source' => 'source',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->displayRule) {
            $res['displayRule'] = $this->displayRule;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['displayRule'])) {
            $model->displayRule = $map['displayRule'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
