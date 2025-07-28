<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models\WriteAlibabaUserCarbonRequest;

use AlibabaCloud\Tea\Model;

class userDetailsList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2021-11-26 10:09:37
     *
     * @var string
     */
    public $actionEndTime;

    /**
     * @description This parameter is required.
     *
     * @example 12320211126
     *
     * @var string
     */
    public $actionId;

    /**
     * @description This parameter is required.
     *
     * @example 2021-11-26 10:09:37
     *
     * @var string
     */
    public $actionStartTime;

    /**
     * @description This parameter is required.
     *
     * @example VIDEO
     *
     * @var string
     */
    public $actionType;

    /**
     * @description This parameter is required.
     *
     * @example 3.21
     *
     * @var string
     */
    public $carbonAmount;

    /**
     * @description This parameter is required.
     *
     * @example ding12344
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example 111
     *
     * @var int
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'actionEndTime' => 'actionEndTime',
        'actionId' => 'actionId',
        'actionStartTime' => 'actionStartTime',
        'actionType' => 'actionType',
        'carbonAmount' => 'carbonAmount',
        'corpId' => 'corpId',
        'deptId' => 'deptId',
        'userId' => 'userId',
        'version' => 'version',
    ];

    public function validate() {}

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
