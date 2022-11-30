<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReleaseGrayUserIdGetResponseBody extends Model
{
    /**
     * @description 灰度用户的工号列表
     *
     * @var string[]
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
     * @return ReleaseGrayUserIdGetResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = $map['value'];
            }
        }

        return $model;
    }
}
