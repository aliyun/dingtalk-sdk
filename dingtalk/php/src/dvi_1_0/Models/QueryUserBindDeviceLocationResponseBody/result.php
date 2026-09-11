<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserBindDeviceLocationResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryUserBindDeviceLocationResponseBody\result\latestLocation;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var latestLocation
     */
    public $latestLocation;

    /**
     * @var string
     */
    public $sn;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'latestLocation' => 'latestLocation',
        'sn' => 'sn',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->latestLocation) {
            $res['latestLocation'] = null !== $this->latestLocation ? $this->latestLocation->toMap() : null;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['latestLocation'])) {
            $model->latestLocation = latestLocation::fromMap($map['latestLocation']);
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
