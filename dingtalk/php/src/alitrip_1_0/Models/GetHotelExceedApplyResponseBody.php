<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetHotelExceedApplyResponseBody\applyIntentionInfoDO;
use AlibabaCloud\Tea\Model;

class GetHotelExceedApplyResponseBody extends Model
{
    /**
     * @example 12345
     *
     * @var int
     */
    public $applyId;

    /**
     * @var applyIntentionInfoDO
     */
    public $applyIntentionInfoDO;

    /**
     * @example 出差
     *
     * @var string
     */
    public $btripCause;

    /**
     * @example ding12345
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 出差
     *
     * @var string
     */
    public $exceedReason;

    /**
     * @example 16
     *
     * @var int
     */
    public $exceedType;

    /**
     * @example 210000
     *
     * @var string
     */
    public $originStandard;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @example 2021-07-08 15:23:56
     *
     * @var string
     */
    public $submitTime;

    /**
     * @example 0001A1100000007EX08O
     *
     * @var string
     */
    public $thirdpartApplyId;

    /**
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
     * @return GetHotelExceedApplyResponseBody
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
