<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetFlightExceedApplyResponseBody\applyIntentionInfoDO;
use AlibabaCloud\Tea\Model;

class GetFlightExceedApplyResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1234
     *
     * @var int
     */
    public $applyId;

    /**
     * @description This parameter is required.
     *
     * @var applyIntentionInfoDO
     */
    public $applyIntentionInfoDO;

    /**
     * @description This parameter is required.
     *
     * @example 出差
     *
     * @var string
     */
    public $btripCause;

    /**
     * @description This parameter is required.
     *
     * @example ding1234
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example 出差
     *
     * @var string
     */
    public $exceedReason;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $exceedType;

    /**
     * @description This parameter is required.
     *
     * @example 经济舱（2折及以下）
     *
     * @var string
     */
    public $originStandard;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 2021-07-08 15:23:56
     *
     * @var string
     */
    public $submitTime;

    /**
     * @description This parameter is required.
     *
     * @example 0001A1100000007EX08O
     *
     * @var string
     */
    public $thirdpartApplyId;

    /**
     * @description This parameter is required.
     *
     * @example weifeng
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'applyId'              => 'applyId',
        'applyIntentionInfoDO' => 'applyIntentionInfoDO',
        'btripCause'           => 'btripCause',
        'corpId'               => 'corpId',
        'exceedReason'         => 'exceedReason',
        'exceedType'           => 'exceedType',
        'originStandard'       => 'originStandard',
        'status'               => 'status',
        'submitTime'           => 'submitTime',
        'thirdpartApplyId'     => 'thirdpartApplyId',
        'userId'               => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }
        if (null !== $this->applyIntentionInfoDO) {
            $res['applyIntentionInfoDO'] = null !== $this->applyIntentionInfoDO ? $this->applyIntentionInfoDO->toMap() : null;
        }
        if (null !== $this->btripCause) {
            $res['btripCause'] = $this->btripCause;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->exceedReason) {
            $res['exceedReason'] = $this->exceedReason;
        }
        if (null !== $this->exceedType) {
            $res['exceedType'] = $this->exceedType;
        }
        if (null !== $this->originStandard) {
            $res['originStandard'] = $this->originStandard;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->submitTime) {
            $res['submitTime'] = $this->submitTime;
        }
        if (null !== $this->thirdpartApplyId) {
            $res['thirdpartApplyId'] = $this->thirdpartApplyId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFlightExceedApplyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }
        if (isset($map['applyIntentionInfoDO'])) {
            $model->applyIntentionInfoDO = applyIntentionInfoDO::fromMap($map['applyIntentionInfoDO']);
        }
        if (isset($map['btripCause'])) {
            $model->btripCause = $map['btripCause'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['exceedReason'])) {
            $model->exceedReason = $map['exceedReason'];
        }
        if (isset($map['exceedType'])) {
            $model->exceedType = $map['exceedType'];
        }
        if (isset($map['originStandard'])) {
            $model->originStandard = $map['originStandard'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['submitTime'])) {
            $model->submitTime = $map['submitTime'];
        }
        if (isset($map['thirdpartApplyId'])) {
            $model->thirdpartApplyId = $map['thirdpartApplyId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
