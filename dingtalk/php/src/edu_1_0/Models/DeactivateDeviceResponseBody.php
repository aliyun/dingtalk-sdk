<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeactivateDeviceResponseBody extends Model
{
    /**
     * @description 授权码已激活的次数
     *
     * @var int
     */
    public $activateTimes;
    protected $_name = [
        'activateTimes' => 'activateTimes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activateTimes) {
            $res['activateTimes'] = $this->activateTimes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeactivateDeviceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activateTimes'])) {
            $model->activateTimes = $map['activateTimes'];
        }

        return $model;
    }
}
