<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetTrainExceedApplyResponseBody\applyIntentionInfoDO;
use AlibabaCloud\Tea\Model;

class GetTrainExceedApplyResponseBody extends Model
{
    /**
     * @description 商旅超标审批单id
     *
     * @var int
     */
    public $applyId;

    /**
     * @description 意向出行信息
     *
     * @var applyIntentionInfoDO
     */
    public $applyIntentionInfoDO;

    /**
     * @description 出差原因
     *
     * @var string
     */
    public $btripCause;

    /**
     * @description 第三方企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 超标原因
     *
     * @var string
     */
    public $exceedReason;

    /**
     * @description 超标类型，32：坐席超标
     *
     * @var int
     */
    public $exceedType;

    /**
     * @description 原差旅标准
     *
     * @var string
     */
    public $originStandard;

    /**
     * @description 审批单状态 0:审批中 1:已同意 2:已拒绝
     *
     * @var int
     */
    public $status;

    /**
     * @description 审批单提交时间
     *
     * @var string
     */
    public $submitTime;

    /**
     * @description 第三方出差审批单号
     *
     * @var string
     */
    public $thirdpartApplyId;

    /**
     * @description 第三方用户id
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
     * @return GetTrainExceedApplyResponseBody
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
