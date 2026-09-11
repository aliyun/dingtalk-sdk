<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetA1DeviceDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetA1DeviceDetailResponseBody\result\device;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var device
     */
    public $device;
    protected $_name = [
        'device' => 'device',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->device) {
            $res['device'] = null !== $this->device ? $this->device->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['device'])) {
            $model->device = device::fromMap($map['device']);
        }

        return $model;
    }
}
