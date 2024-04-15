<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpEmployeeDataPushRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @var string
     */
    public $avatar;

    /**
     * @var string
     */
    public $isDelete;

    /**
     * @var string
     */
    public $name;

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
    public $workNo;
    protected $_name = [
        'avatar'   => 'avatar',
        'isDelete' => 'isDelete',
        'name'     => 'name',
        'unionId'  => 'unionId',
        'userId'   => 'userId',
        'workNo'   => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->isDelete) {
            $res['isDelete'] = $this->isDelete;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['isDelete'])) {
            $model->isDelete = $map['isDelete'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
