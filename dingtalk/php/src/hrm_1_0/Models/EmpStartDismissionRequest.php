<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class EmpStartDismissionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $lastWorkDate;

    /**
     * @var bool
     */
    public $partner;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string[]
     */
    public $terminationReasonPassive;

    /**
     * @var string[]
     */
    public $terminationReasonVoluntary;

    /**
     * @var bool
     */
    public $toHireBlackList;

    /**
     * @var bool
     */
    public $toHireDismissionTalent;

    /**
     * @var bool
     */
    public $toHrmBlackList;

    /**
     * @description This parameter is required.
     *
     * @example 2163515669935611
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'lastWorkDate' => 'lastWorkDate',
        'partner' => 'partner',
        'remark' => 'remark',
        'terminationReasonPassive' => 'terminationReasonPassive',
        'terminationReasonVoluntary' => 'terminationReasonVoluntary',
        'toHireBlackList' => 'toHireBlackList',
        'toHireDismissionTalent' => 'toHireDismissionTalent',
        'toHrmBlackList' => 'toHrmBlackList',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->lastWorkDate) {
            $res['lastWorkDate'] = $this->lastWorkDate;
        }
        if (null !== $this->partner) {
            $res['partner'] = $this->partner;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->terminationReasonPassive) {
            $res['terminationReasonPassive'] = $this->terminationReasonPassive;
        }
        if (null !== $this->terminationReasonVoluntary) {
            $res['terminationReasonVoluntary'] = $this->terminationReasonVoluntary;
        }
        if (null !== $this->toHireBlackList) {
            $res['toHireBlackList'] = $this->toHireBlackList;
        }
        if (null !== $this->toHireDismissionTalent) {
            $res['toHireDismissionTalent'] = $this->toHireDismissionTalent;
        }
        if (null !== $this->toHrmBlackList) {
            $res['toHrmBlackList'] = $this->toHrmBlackList;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EmpStartDismissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['lastWorkDate'])) {
            $model->lastWorkDate = $map['lastWorkDate'];
        }
        if (isset($map['partner'])) {
            $model->partner = $map['partner'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['terminationReasonPassive'])) {
            if (!empty($map['terminationReasonPassive'])) {
                $model->terminationReasonPassive = $map['terminationReasonPassive'];
            }
        }
        if (isset($map['terminationReasonVoluntary'])) {
            if (!empty($map['terminationReasonVoluntary'])) {
                $model->terminationReasonVoluntary = $map['terminationReasonVoluntary'];
            }
        }
        if (isset($map['toHireBlackList'])) {
            $model->toHireBlackList = $map['toHireBlackList'];
        }
        if (isset($map['toHireDismissionTalent'])) {
            $model->toHireDismissionTalent = $map['toHireDismissionTalent'];
        }
        if (isset($map['toHrmBlackList'])) {
            $model->toHrmBlackList = $map['toHrmBlackList'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
