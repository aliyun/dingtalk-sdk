<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetMachineUserResponseBody\result;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @var bool
     */
    public $hasFace;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'hasFace' => 'hasFace',
        'name'    => 'name',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasFace) {
            $res['hasFace'] = $this->hasFace;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['hasFace'])) {
            $model->hasFace = $map['hasFace'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
