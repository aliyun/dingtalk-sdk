<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\DeductionPointBatchRequest\targetUserList;
use AlibabaCloud\Tea\Model;

class DeductionPointBatchRequest extends Model
{
    /**
     * @description 扣减数量 范围：1—100000
     *
     * @var int
     */
    public $deductionAmount;

    /**
     * @description 扣减积分原因
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
     * @description 批量扣减积分用户
     *
     * @var targetUserList[]
     */
    public $targetUserList;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deductionAmount'      => 'deductionAmount',
        'remark'               => 'remark',
        'sendOrgCultureInform' => 'sendOrgCultureInform',
        'targetUserList'       => 'targetUserList',
        'userId'               => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deductionAmount) {
            $res['deductionAmount'] = $this->deductionAmount;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->sendOrgCultureInform) {
            $res['sendOrgCultureInform'] = $this->sendOrgCultureInform;
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeductionPointBatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deductionAmount'])) {
            $model->deductionAmount = $map['deductionAmount'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['sendOrgCultureInform'])) {
            $model->sendOrgCultureInform = $map['sendOrgCultureInform'];
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
