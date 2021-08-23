<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptUsersResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $jobNumber;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int[]
     */
    public $deptIdList;

    /**
     * @var bool
     */
    public $active;
    protected $_name = [
        'userId'     => 'userId',
        'unionId'    => 'unionId',
        'jobNumber'  => 'jobNumber',
        'name'       => 'name',
        'deptIdList' => 'deptIdList',
        'active'     => 'active',
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
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->active) {
            $res['active'] = $this->active;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
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
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['active'])) {
            $model->active = $map['active'];
        }

        return $model;
    }
}
