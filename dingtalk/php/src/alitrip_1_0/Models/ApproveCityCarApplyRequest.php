<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApproveCityCarApplyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example corpx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2021-03-18 20:26:56
     *
     * @var string
     */
    public $operateTime;

    /**
     * @example 同意
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example apply1
     *
     * @var string
     */
    public $thirdPartApplyId;

    /**
     * @description This parameter is required.
     *
     * @example user1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId'           => 'corpId',
        'operateTime'      => 'operateTime',
        'remark'           => 'remark',
        'status'           => 'status',
        'thirdPartApplyId' => 'thirdPartApplyId',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->operateTime) {
            $res['operateTime'] = $this->operateTime;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->thirdPartApplyId) {
            $res['thirdPartApplyId'] = $this->thirdPartApplyId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ApproveCityCarApplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['operateTime'])) {
            $model->operateTime = $map['operateTime'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['thirdPartApplyId'])) {
            $model->thirdPartApplyId = $map['thirdPartApplyId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
