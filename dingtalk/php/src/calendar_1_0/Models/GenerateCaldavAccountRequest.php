<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class GenerateCaldavAccountRequest extends Model
{
    /**
     * @description 设备名称
     *
     * @var string
     */
    public $device;
    protected $_name = [
        'device' => 'device',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->device) {
            $res['device'] = $this->device;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GenerateCaldavAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['device'])) {
            $model->device = $map['device'];
        }

        return $model;
    }
}
