<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineUserResponseBody\result;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $hasFace;
    protected $_name = [
        'userId'  => 'userId',
        'name'    => 'name',
        'hasFace' => 'hasFace',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->hasFace) {
            $res['hasFace'] = $this->hasFace;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['hasFace'])) {
            $model->hasFace = $map['hasFace'];
        }

        return $model;
    }
}
