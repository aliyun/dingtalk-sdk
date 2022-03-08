<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUsersResponseBody;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @var bool
     */
    public $active;

    /**
     * @description 部门ID列表
     *
     * @var int[]
     */
    public $departmentList;

    /**
     * @var string
     */
    public $jobNumber;

    /**
     * @var string
     */
    public $name;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 用户ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'active'         => 'active',
        'departmentList' => 'departmentList',
        'jobNumber'      => 'jobNumber',
        'name'           => 'name',
        'unionId'        => 'unionId',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }
        if (null !== $this->departmentList) {
            $res['departmentList'] = $this->departmentList;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
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
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }
        if (isset($map['departmentList'])) {
            if (!empty($map['departmentList'])) {
                $model->departmentList = $map['departmentList'];
            }
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
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

        return $model;
    }
}
