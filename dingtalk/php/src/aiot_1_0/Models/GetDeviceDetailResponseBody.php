<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDeviceDetailResponseBody extends Model
{
    /**
     * @var string
     */
    public $activatedAt;

    /**
     * @var string
     */
    public $connectivity;

    /**
     * @var string
     */
    public $lastOfflineTime;

    /**
     * @var string
     */
    public $lastOnlineTime;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'activatedAt' => 'activatedAt',
        'connectivity' => 'connectivity',
        'lastOfflineTime' => 'lastOfflineTime',
        'lastOnlineTime' => 'lastOnlineTime',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activatedAt) {
            $res['activatedAt'] = $this->activatedAt;
        }
        if (null !== $this->connectivity) {
            $res['connectivity'] = $this->connectivity;
        }
        if (null !== $this->lastOfflineTime) {
            $res['lastOfflineTime'] = $this->lastOfflineTime;
        }
        if (null !== $this->lastOnlineTime) {
            $res['lastOnlineTime'] = $this->lastOnlineTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDeviceDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activatedAt'])) {
            $model->activatedAt = $map['activatedAt'];
        }
        if (isset($map['connectivity'])) {
            $model->connectivity = $map['connectivity'];
        }
        if (isset($map['lastOfflineTime'])) {
            $model->lastOfflineTime = $map['lastOfflineTime'];
        }
        if (isset($map['lastOnlineTime'])) {
            $model->lastOnlineTime = $map['lastOnlineTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
