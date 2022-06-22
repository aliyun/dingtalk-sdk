<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CampusAddRenterMemberResponseBody extends Model
{
    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userState;
    protected $_name = [
        'unionId'   => 'unionId',
        'userId'    => 'userId',
        'userState' => 'userState',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userState) {
            $res['userState'] = $this->userState;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CampusAddRenterMemberResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userState'])) {
            $model->userState = $map['userState'];
        }

        return $model;
    }
}
