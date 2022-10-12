<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetAllCustomerRecyclesResponseBody;

use AlibabaCloud\Tea\Model;

class resultList extends Model
{
    /**
     * @description 客户ID
     *
     * @var string
     */
    public $customerId;

    /**
     * @description 上次跟进时间
     *
     * @var string
     */
    public $followUpActionTime;

    /**
     * @var bool
     */
    public $isDeleted;

    /**
     * @description 掉保提醒时间
     *
     * @var string
     */
    public $notifyTime;

    /**
     * @description 掉保规则ID
     *
     * @var int
     */
    public $recycleRuleId;

    /**
     * @description 掉保时间
     *
     * @var string
     */
    public $recycleTime;
    protected $_name = [
        'customerId'         => 'customerId',
        'followUpActionTime' => 'followUpActionTime',
        'isDeleted'          => 'isDeleted',
        'notifyTime'         => 'notifyTime',
        'recycleRuleId'      => 'recycleRuleId',
        'recycleTime'        => 'recycleTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }
        if (null !== $this->followUpActionTime) {
            $res['followUpActionTime'] = $this->followUpActionTime;
        }
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->notifyTime) {
            $res['notifyTime'] = $this->notifyTime;
        }
        if (null !== $this->recycleRuleId) {
            $res['recycleRuleId'] = $this->recycleRuleId;
        }
        if (null !== $this->recycleTime) {
            $res['recycleTime'] = $this->recycleTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }
        if (isset($map['followUpActionTime'])) {
            $model->followUpActionTime = $map['followUpActionTime'];
        }
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['notifyTime'])) {
            $model->notifyTime = $map['notifyTime'];
        }
        if (isset($map['recycleRuleId'])) {
            $model->recycleRuleId = $map['recycleRuleId'];
        }
        if (isset($map['recycleTime'])) {
            $model->recycleTime = $map['recycleTime'];
        }

        return $model;
    }
}
