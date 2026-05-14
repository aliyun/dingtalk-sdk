<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\BatchQueryUserDeviceStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ResultUserDeviceStatusMapValue;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var ResultUserDeviceStatusMapValue[][]
     */
    public $userDeviceStatusMap;
    protected $_name = [
        'userDeviceStatusMap' => 'userDeviceStatusMap',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->userDeviceStatusMap) {
            $res['userDeviceStatusMap'] = $this->userDeviceStatusMap;
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
        if (isset($map['userDeviceStatusMap'])) {
            $model->userDeviceStatusMap = $map['userDeviceStatusMap'];
        }

        return $model;
    }
}
