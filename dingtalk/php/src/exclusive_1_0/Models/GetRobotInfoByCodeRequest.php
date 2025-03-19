<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRobotInfoByCodeRequest extends Model
{
    /**
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'robotCode' => 'robotCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRobotInfoByCodeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
