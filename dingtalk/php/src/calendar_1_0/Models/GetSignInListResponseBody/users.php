<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListResponseBody;

use AlibabaCloud\Tea\Model;

class users extends Model
{
    /**
     * @description 签到时间
     *
     * @var int
     */
    public $checkInTime;

    /**
     * @description 用户名
     *
     * @var string
     */
    public $displayName;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'checkInTime' => 'checkInTime',
        'displayName' => 'displayName',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkInTime) {
            $res['checkInTime'] = $this->checkInTime;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['checkInTime'])) {
            $model->checkInTime = $map['checkInTime'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
