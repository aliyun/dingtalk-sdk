<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result;

use AlibabaCloud\Tea\Model;

class titleGenRule extends Model
{
    /**
     * @description 规则表达式
     *
     * @var string
     */
    public $express;

    /**
     * @description 规则类型
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'express' => 'express',
        'type'    => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->express) {
            $res['express'] = $this->express;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return titleGenRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['express'])) {
            $model->express = $map['express'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
