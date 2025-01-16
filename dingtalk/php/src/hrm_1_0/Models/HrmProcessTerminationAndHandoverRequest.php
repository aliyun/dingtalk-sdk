<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmProcessTerminationAndHandoverRequest extends Model
{
    /**
     * @example user123
     *
     * @var string
     */
    public $aflowHandOverUserId;

    /**
     * @example user123
     *
     * @var string
     */
    public $dingPanHandoverUserId;

    /**
     * @example user123
     *
     * @var string
     */
    public $directSubordinatesHandoverUserId;

    /**
     * @description This parameter is required.
     *
     * @example aefadfadaewedad
     *
     * @var string
     */
    public $dismissionMemo;

    /**
     * @example 1
     *
     * @var int
     */
    public $dismissionReason;

    /**
     * @example user123
     *
     * @var string
     */
    public $docNoteHandoverUserId;

    /**
     * @description This parameter is required.
     *
     * @example 1704074400000
     *
     * @var int
     */
    public $lastWorkDate;

    /**
     * @description This parameter is required.
     *
     * @example 经理
     *
     * @var string
     */
    public $optUserId;

    /**
     * @example user123
     *
     * @var string
     */
    public $permissionHandoverUserId;

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
     * @example 2332
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'aflowHandOverUserId'              => 'aflowHandOverUserId',
        'dingPanHandoverUserId'            => 'dingPanHandoverUserId',
        'directSubordinatesHandoverUserId' => 'directSubordinatesHandoverUserId',
        'dismissionMemo'                   => 'dismissionMemo',
        'dismissionReason'                 => 'dismissionReason',
        'docNoteHandoverUserId'            => 'docNoteHandoverUserId',
        'lastWorkDate'                     => 'lastWorkDate',
        'optUserId'                        => 'optUserId',
        'permissionHandoverUserId'         => 'permissionHandoverUserId',
        'terminationReasonPassive'         => 'terminationReasonPassive',
        'terminationReasonVoluntary'       => 'terminationReasonVoluntary',
        'userId'                           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->aflowHandOverUserId) {
            $res['aflowHandOverUserId'] = $this->aflowHandOverUserId;
        }
        if (null !== $this->dingPanHandoverUserId) {
            $res['dingPanHandoverUserId'] = $this->dingPanHandoverUserId;
        }
        if (null !== $this->directSubordinatesHandoverUserId) {
            $res['directSubordinatesHandoverUserId'] = $this->directSubordinatesHandoverUserId;
        }
        if (null !== $this->dismissionMemo) {
            $res['dismissionMemo'] = $this->dismissionMemo;
        }
        if (null !== $this->dismissionReason) {
            $res['dismissionReason'] = $this->dismissionReason;
        }
        if (null !== $this->docNoteHandoverUserId) {
            $res['docNoteHandoverUserId'] = $this->docNoteHandoverUserId;
        }
        if (null !== $this->lastWorkDate) {
            $res['lastWorkDate'] = $this->lastWorkDate;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }
        if (null !== $this->permissionHandoverUserId) {
            $res['permissionHandoverUserId'] = $this->permissionHandoverUserId;
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
     * @return HrmProcessTerminationAndHandoverRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aflowHandOverUserId'])) {
            $model->aflowHandOverUserId = $map['aflowHandOverUserId'];
        }
        if (isset($map['dingPanHandoverUserId'])) {
            $model->dingPanHandoverUserId = $map['dingPanHandoverUserId'];
        }
        if (isset($map['directSubordinatesHandoverUserId'])) {
            $model->directSubordinatesHandoverUserId = $map['directSubordinatesHandoverUserId'];
        }
        if (isset($map['dismissionMemo'])) {
            $model->dismissionMemo = $map['dismissionMemo'];
        }
        if (isset($map['dismissionReason'])) {
            $model->dismissionReason = $map['dismissionReason'];
        }
        if (isset($map['docNoteHandoverUserId'])) {
            $model->docNoteHandoverUserId = $map['docNoteHandoverUserId'];
        }
        if (isset($map['lastWorkDate'])) {
            $model->lastWorkDate = $map['lastWorkDate'];
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }
        if (isset($map['permissionHandoverUserId'])) {
            $model->permissionHandoverUserId = $map['permissionHandoverUserId'];
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
