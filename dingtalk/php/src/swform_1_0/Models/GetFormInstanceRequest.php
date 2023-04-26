<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFormInstanceRequest extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $bizType;
    protected $_name = [
        'bizType' => 'bizType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFormInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }

        return $model;
    }
}
