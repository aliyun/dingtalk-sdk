<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSignInListResponseBody;

use AlibabaCloud\Tea\Model;

class users extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @description 用户名
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 签到时间
     *
     * @var int
     */
    public $checkInTime;
    protected $_name = [
        'userId'      => 'userId',
        'displayName' => 'displayName',
        'checkInTime' => 'checkInTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['checkInTime'])) {
            $model->checkInTime = $map['checkInTime'];
        }

        return $model;
    }
}
