<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateEmpDismissionInfoRequest extends Model
{
    /**
     * @var string
     */
    public $dismissionMemo;

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
     * @var string[]
     */
    public $terminationReasonPassive;

    /**
     * @var string[]
     */
    public $terminationReasonVoluntary;

    /**
     * @description This parameter is required.
     *
     * @example 2163515669935611
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dismissionMemo' => 'dismissionMemo',
        'lastWorkDate' => 'lastWorkDate',
        'partner' => 'partner',
        'terminationReasonPassive' => 'terminationReasonPassive',
        'terminationReasonVoluntary' => 'terminationReasonVoluntary',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dismissionMemo) {
            $res['dismissionMemo'] = $this->dismissionMemo;
        }
        if (null !== $this->lastWorkDate) {
            $res['lastWorkDate'] = $this->lastWorkDate;
        }
        if (null !== $this->partner) {
            $res['partner'] = $this->partner;
        }
        if (null !== $this->terminationReasonPassive) {
            $res['terminationReasonPassive'] = $this->terminationReasonPassive;
        }
        if (null !== $this->terminationReasonVoluntary) {
            $res['terminationReasonVoluntary'] = $this->terminationReasonVoluntary;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateEmpDismissionInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dismissionMemo'])) {
            $model->dismissionMemo = $map['dismissionMemo'];
        }
        if (isset($map['lastWorkDate'])) {
            $model->lastWorkDate = $map['lastWorkDate'];
        }
        if (isset($map['partner'])) {
            $model->partner = $map['partner'];
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
