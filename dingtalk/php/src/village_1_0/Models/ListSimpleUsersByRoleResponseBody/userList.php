<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSimpleUsersByRoleResponseBody;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @description 用户ID
     *
     * @var string
     */
    public $userId;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 工号
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'userId'    => 'userId',
        'unionId'   => 'unionId',
        'jobNumber' => 'jobNumber',
        'name'      => 'name',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
