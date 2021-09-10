<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetFlightExceedApplyResponseBody\applyIntentionInfoDO;
use AlibabaCloud\Tea\Model;

class GetFlightExceedApplyResponseBody extends Model
{
    /**
     * @description 第三方企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 商旅超标审批单id
     *
     * @var int
     */
    public $applyId;

    /**
     * @description 审批单状态 0:审批中 1:已同意 2:已拒绝
     *
     * @var int
     */
    public $status;

    /**
     * @description 出差原因
     *
     * @var string
     */
    public $btripCause;

    /**
     * @description 超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间
     *
     * @var int
     */
    public $exceedType;

    /**
     * @description 超标原因
     *
     * @var string
     */
    public $exceedReason;

    /**
     * @description 原差旅标准
     *
     * @var string
     */
    public $originStandard;

    /**
     * @description 审批单提交时间
     *
     * @var string
     */
    public $submitTime;

    /**
     * @description 第三方用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 意向出行信息
     *
     * @var applyIntentionInfoDO
     */
    public $applyIntentionInfoDO;

    /**
     * @description 第三方出差审批单号
     *
     * @var string
     */
    public $thirdpartApplyId;
    protected $_name = [
        'corpId'               => 'corpId',
        'applyId'              => 'applyId',
        'status'               => 'status',
        'btripCause'           => 'btripCause',
        'exceedType'           => 'exceedType',
        'exceedReason'         => 'exceedReason',
        'originStandard'       => 'originStandard',
        'submitTime'           => 'submitTime',
        'userId'               => 'userId',
        'applyIntentionInfoDO' => 'applyIntentionInfoDO',
        'thirdpartApplyId'     => 'thirdpartApplyId',
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
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->btripCause) {
            $res['btripCause'] = $this->btripCause;
        }
        if (null !== $this->exceedType) {
            $res['exceedType'] = $this->exceedType;
        }
        if (null !== $this->exceedReason) {
            $res['exceedReason'] = $this->exceedReason;
        }
        if (null !== $this->originStandard) {
            $res['originStandard'] = $this->originStandard;
        }
        if (null !== $this->submitTime) {
            $res['submitTime'] = $this->submitTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->applyIntentionInfoDO) {
            $res['applyIntentionInfoDO'] = null !== $this->applyIntentionInfoDO ? $this->applyIntentionInfoDO->toMap() : null;
        }
        if (null !== $this->thirdpartApplyId) {
            $res['thirdpartApplyId'] = $this->thirdpartApplyId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['btripCause'])) {
            $model->btripCause = $map['btripCause'];
        }
        if (isset($map['exceedType'])) {
            $model->exceedType = $map['exceedType'];
        }
        if (isset($map['exceedReason'])) {
            $model->exceedReason = $map['exceedReason'];
        }
        if (isset($map['originStandard'])) {
            $model->originStandard = $map['originStandard'];
        }
        if (isset($map['submitTime'])) {
            $model->submitTime = $map['submitTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['applyIntentionInfoDO'])) {
            $model->applyIntentionInfoDO = applyIntentionInfoDO::fromMap($map['applyIntentionInfoDO']);
        }
        if (isset($map['thirdpartApplyId'])) {
            $model->thirdpartApplyId = $map['thirdpartApplyId'];
        }

        return $model;
    }
}
