<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ResultUserDeviceStatusMapValue\status;
use AlibabaCloud\Tea\Model;

class ResultUserDeviceStatusMapValue extends Model
{
    /**
     * @var string
     */
    public $sn;

    /**
     * @var status
     */
    public $status;
    protected $_name = [
        'sn' => 'sn',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->status) {
            $res['status'] = null !== $this->status ? $this->status->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ResultUserDeviceStatusMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['status'])) {
            $model->status = status::fromMap($map['status']);
        }

        return $model;
    }
}
