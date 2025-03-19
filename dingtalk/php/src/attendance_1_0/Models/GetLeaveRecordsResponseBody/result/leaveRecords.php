<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveRecordsResponseBody\result;

use AlibabaCloud\Tea\Model;

class leaveRecords extends Model
{
    /**
     * @example add
     *
     * @var string
     */
    public $calType;

    /**
     * @example 1753851001000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 1653851001000
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @example 1753851001000
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @example f84a2dxxxx
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @example 管理员导入
     *
     * @var string
     */
    public $leaveReason;

    /**
     * @example update
     *
     * @var string
     */
    public $leaveRecordType;

    /**
     * @example init
     *
     * @var string
     */
    public $leaveStatus;

    /**
     * @example day
     *
     * @var string
     */
    public $leaveViewUnit;

    /**
     * @example manage223
     *
     * @var string
     */
    public $opUserId;

    /**
     * @example db1d74xxxxbaa
     *
     * @var string
     */
    public $quotaId;

    /**
     * @example db1d74xxxxbaa
     *
     * @var string
     */
    public $recordId;

    /**
     * @example 100
     *
     * @var int
     */
    public $recordNumPerDay;

    /**
     * @example 100
     *
     * @var int
     */
    public $recordNumPerHour;

    /**
     * @example 1653851001000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example user1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'calType' => 'calType',
        'endTime' => 'endTime',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'leaveCode' => 'leaveCode',
        'leaveReason' => 'leaveReason',
        'leaveRecordType' => 'leaveRecordType',
        'leaveStatus' => 'leaveStatus',
        'leaveViewUnit' => 'leaveViewUnit',
        'opUserId' => 'opUserId',
        'quotaId' => 'quotaId',
        'recordId' => 'recordId',
        'recordNumPerDay' => 'recordNumPerDay',
        'recordNumPerHour' => 'recordNumPerHour',
        'startTime' => 'startTime',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->calType) {
            $res['calType'] = $this->calType;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->leaveReason) {
            $res['leaveReason'] = $this->leaveReason;
        }
        if (null !== $this->leaveRecordType) {
            $res['leaveRecordType'] = $this->leaveRecordType;
        }
        if (null !== $this->leaveStatus) {
            $res['leaveStatus'] = $this->leaveStatus;
        }
        if (null !== $this->leaveViewUnit) {
            $res['leaveViewUnit'] = $this->leaveViewUnit;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->quotaId) {
            $res['quotaId'] = $this->quotaId;
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
        }
        if (null !== $this->recordNumPerDay) {
            $res['recordNumPerDay'] = $this->recordNumPerDay;
        }
        if (null !== $this->recordNumPerHour) {
            $res['recordNumPerHour'] = $this->recordNumPerHour;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return leaveRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['calType'])) {
            $model->calType = $map['calType'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['leaveReason'])) {
            $model->leaveReason = $map['leaveReason'];
        }
        if (isset($map['leaveRecordType'])) {
            $model->leaveRecordType = $map['leaveRecordType'];
        }
        if (isset($map['leaveStatus'])) {
            $model->leaveStatus = $map['leaveStatus'];
        }
        if (isset($map['leaveViewUnit'])) {
            $model->leaveViewUnit = $map['leaveViewUnit'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['quotaId'])) {
            $model->quotaId = $map['quotaId'];
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }
        if (isset($map['recordNumPerDay'])) {
            $model->recordNumPerDay = $map['recordNumPerDay'];
        }
        if (isset($map['recordNumPerHour'])) {
            $model->recordNumPerHour = $map['recordNumPerHour'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
