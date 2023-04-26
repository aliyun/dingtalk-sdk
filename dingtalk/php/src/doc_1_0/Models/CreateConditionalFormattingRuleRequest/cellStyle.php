<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateConditionalFormattingRuleRequest;

use AlibabaCloud\Tea\Model;

class cellStyle extends Model
{
    /**
     * @var string
     */
    public $backgroundColor;
    protected $_name = [
        'backgroundColor' => 'backgroundColor',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundColor) {
            $res['backgroundColor'] = $this->backgroundColor;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cellStyle
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundColor'])) {
            $model->backgroundColor = $map['backgroundColor'];
        }

        return $model;
    }
}
