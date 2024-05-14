<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpLeaveRecordsResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example oapi
     *
     * @var string
     */
    public $leaveReason;

    /**
     * @description This parameter is required.
     *
     * @example 2021-01-06T11:47:37Z
     *
     * @var string
     */
    public $leaveTime;

    /**
     * @description This parameter is required.
     *
     * @example 185xxxx7676
     *
     * @var string
     */
    public $mobile;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 86
     *
     * @var string
     */
    public $stateCode;

    /**
     * @description This parameter is required.
     *
     * @example 10000
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'leaveReason' => 'leaveReason',
        'leaveTime'   => 'leaveTime',
        'mobile'      => 'mobile',
        'name'        => 'name',
        'stateCode'   => 'stateCode',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->leaveReason) {
            $res['leaveReason'] = $this->leaveReason;
        }
        if (null !== $this->leaveTime) {
            $res['leaveTime'] = $this->leaveTime;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leaveReason'])) {
            $model->leaveReason = $map['leaveReason'];
        }
        if (isset($map['leaveTime'])) {
            $model->leaveTime = $map['leaveTime'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
