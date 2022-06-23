<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\AssignOrgHoldingToEmpHoldingBatchRequest\targetUserList;
use AlibabaCloud\Tea\Model;

class AssignOrgHoldingToEmpHoldingBatchRequest extends Model
{
    /**
     * @description 备注信息 长度小于40
     *
     * @var string
     */
    public $remark;

    /**
     * @description 是否发送组织文化通知
     *
     * @var bool
     */
    public $sendOrgCultureInform;

    /**
     * @description 发放积分或额度数量 1～100000
     *
     * @var int
     */
    public $singleAmount;

    /**
     * @description 发放人sourceUsage  发放人与接受人usage应一一对应
     * 行为规则发积分 sourceUsage：OPEN_ACTION_RULE_PERSONAL_ASSIGN 对应的 targetUsage为OPEN_ACTION_RULE_PERSONAL_RECEIVE
     * @var string
     */
    public $sourceUsage;

    /**
     * @description 接受人targetUsage  发放人与接受人usage应一一对应
     *
     * @var string
     */
    public $targetUsage;

    /**
     * @description 发放目标用户
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
