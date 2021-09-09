<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListReceiversResponseBody;

use AlibabaCloud\Tea\Model;

class users extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $id;

    /**
     * @description 用户名
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 签到状态
     *
     * @var int
     */
    public $checkInStatus;

    /**
     * @description 签到时间
     *
     * @var int
     */
    public $checkInTime;
    protected $_name = [
        'id'            => 'id',
        'displayName'   => 'displayName',
        'checkInStatus' => 'checkInStatus',
        'checkInTime'   => 'checkInTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->checkInStatus) {
            $res['checkInStatus'] = $this->checkInStatus;
        }
        if (null !== $this->checkInTime) {
            $res['checkInTime'] = $this->checkInTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return users
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['checkInStatus'])) {
            $model->checkInStatus = $map['checkInStatus'];
        }
        if (isset($map['checkInTime'])) {
            $model->checkInTime = $map['checkInTime'];
        }

        return $model;
    }
}
