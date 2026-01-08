<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySelfBuildGroupUserInfoResponseBody\result;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @var string
     */
    public $role;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userName;
    protected $_name = [
        'role' => 'role',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
