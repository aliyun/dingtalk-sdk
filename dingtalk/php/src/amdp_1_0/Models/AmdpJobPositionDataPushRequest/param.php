<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpJobPositionDataPushRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @var string
     */
    public $deptId;

    /**
     * @var string
     */
    public $deptLeader;

    /**
     * @var string
     */
    public $isDelete;

    /**
     * @var string
     */
    public $leaderDeptId;

    /**
     * @var string
     */
    public $orderNumber;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptId'       => 'deptId',
        'deptLeader'   => 'deptLeader',
        'isDelete'     => 'isDelete',
        'leaderDeptId' => 'leaderDeptId',
        'orderNumber'  => 'orderNumber',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptLeader) {
            $res['deptLeader'] = $this->deptLeader;
        }
        if (null !== $this->isDelete) {
            $res['isDelete'] = $this->isDelete;
        }
        if (null !== $this->leaderDeptId) {
            $res['leaderDeptId'] = $this->leaderDeptId;
        }
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptLeader'])) {
            $model->deptLeader = $map['deptLeader'];
        }
        if (isset($map['isDelete'])) {
            $model->isDelete = $map['isDelete'];
        }
        if (isset($map['leaderDeptId'])) {
            $model->leaderDeptId = $map['leaderDeptId'];
        }
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
