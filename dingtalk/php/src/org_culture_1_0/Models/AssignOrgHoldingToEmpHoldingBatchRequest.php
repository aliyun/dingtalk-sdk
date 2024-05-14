<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchRequest\targetUserList;
use AlibabaCloud\Tea\Model;

class AssignOrgHoldingToEmpHoldingBatchRequest extends Model
{
    /**
     * @example 表现优秀，特此奖励
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $sendOrgCultureInform;

    /**
     * @description This parameter is required.
     *
     * @example 10000
     *
     * @var int
     */
    public $singleAmount;

    /**
     * @description This parameter is required.
     *
     * @example OPEN_ORG_POINT_PERSONAL_ASSIGN
     *
     * @var string
     */
    public $sourceUsage;

    /**
     * @description This parameter is required.
     *
     * @example OPEN_EMP_POINT_PERSONAL_RECEIVE
     *
     * @var string
     */
    public $targetUsage;

    /**
     * @description This parameter is required.
     *
     * @var targetUserList[]
     */
    public $targetUserList;
    protected $_name = [
        'remark'               => 'remark',
        'sendOrgCultureInform' => 'sendOrgCultureInform',
        'singleAmount'         => 'singleAmount',
        'sourceUsage'          => 'sourceUsage',
        'targetUsage'          => 'targetUsage',
        'targetUserList'       => 'targetUserList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->sendOrgCultureInform) {
            $res['sendOrgCultureInform'] = $this->sendOrgCultureInform;
        }
        if (null !== $this->singleAmount) {
            $res['singleAmount'] = $this->singleAmount;
        }
        if (null !== $this->sourceUsage) {
            $res['sourceUsage'] = $this->sourceUsage;
        }
        if (null !== $this->targetUsage) {
            $res['targetUsage'] = $this->targetUsage;
        }
        if (null !== $this->targetUserList) {
            $res['targetUserList'] = [];
            if (null !== $this->targetUserList && \is_array($this->targetUserList)) {
                $n = 0;
                foreach ($this->targetUserList as $item) {
                    $res['targetUserList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AssignOrgHoldingToEmpHoldingBatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['sendOrgCultureInform'])) {
            $model->sendOrgCultureInform = $map['sendOrgCultureInform'];
        }
        if (isset($map['singleAmount'])) {
            $model->singleAmount = $map['singleAmount'];
        }
        if (isset($map['sourceUsage'])) {
            $model->sourceUsage = $map['sourceUsage'];
        }
        if (isset($map['targetUsage'])) {
            $model->targetUsage = $map['targetUsage'];
        }
        if (isset($map['targetUserList'])) {
            if (!empty($map['targetUserList'])) {
                $model->targetUserList = [];
                $n                     = 0;
                foreach ($map['targetUserList'] as $item) {
                    $model->targetUserList[$n++] = null !== $item ? targetUserList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
