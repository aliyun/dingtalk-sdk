<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaUserCarbonRequest;

use AlibabaCloud\Tea\Model;

class userDetailsList extends Model
{
    /**
     * @description 行为结束时间
     *
     * @var string
     */
    public $actionEndTime;

    /**
     * @description 系统唯一id，生成格式：userId+日期20211126
     *
     * @var string
     */
    public $actionId;

    /**
     * @description 行为起始时间
     *
     * @var string
     */
    public $actionStartTime;

    /**
     * @description 碳能量行为类型，需要联系管理员添加
     *
     * @var string
     */
    public $actionType;

    /**
     * @description 碳能量数据
     *
     * @var string
     */
    public $carbonAmount;

    /**
     * @description 钉钉组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 钉钉部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 钉钉用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 版本，默认为1
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'actionEndTime'   => 'actionEndTime',
        'actionId'        => 'actionId',
        'actionStartTime' => 'actionStartTime',
        'actionType'      => 'actionType',
        'carbonAmount'    => 'carbonAmount',
        'corpId'          => 'corpId',
        'deptId'          => 'deptId',
        'userId'          => 'userId',
        'version'         => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionEndTime) {
            $res['actionEndTime'] = $this->actionEndTime;
        }
        if (null !== $this->actionId) {
            $res['actionId'] = $this->actionId;
        }
        if (null !== $this->actionStartTime) {
            $res['actionStartTime'] = $this->actionStartTime;
        }
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->carbonAmount) {
            $res['carbonAmount'] = $this->carbonAmount;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userDetailsList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionEndTime'])) {
            $model->actionEndTime = $map['actionEndTime'];
        }
        if (isset($map['actionId'])) {
            $model->actionId = $map['actionId'];
        }
        if (isset($map['actionStartTime'])) {
            $model->actionStartTime = $map['actionStartTime'];
        }
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['carbonAmount'])) {
            $model->carbonAmount = $map['carbonAmount'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
