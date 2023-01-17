<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailResponseBody\integrationConfig;

use AlibabaCloud\Tea\Model;

class categoryNames extends Model
{
    /**
     * @description 类目名称
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'value' => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categoryNames
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
