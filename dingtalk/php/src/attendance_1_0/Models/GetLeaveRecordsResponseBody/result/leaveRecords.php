<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveRecordsResponseBody\result;

use AlibabaCloud\Tea\Model;

class leaveRecords extends Model
{
    /**
     * @description 计算类型。
     *
     * @var string
     */
    public $calType;

    /**
     * @description 额度有效期结束时间或请假结束时间，毫秒级时间戳。
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 记录创建时间。
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @description 记录修改时间。
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @description 假期类型唯一标识。
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description 原因。
     *
     * @var string
     */
    public $leaveReason;

    /**
     * @description 假期记录类型。
     *
     * @var string
     */
    public $leaveRecordType;

    /**
     * @description 请假状态。
     *
     * @var string
     */
    public $leaveStatus;

    /**
     * @description 显示单位。
     *
     * @var string
     */
    public $leaveViewUnit;

    /**
     * @description 额度唯一标识。
     *
     * @var string
     */
    public $quotaId;

    /**
     * @description 假期记录唯一标识。
     *
     * @var string
     */
    public $recordId;

    /**
     * @description 以天计算的消费额度。
     *
     * @var int
     */
    public $recordNumPerDay;

    /**
     * @description 以小时计算的消费额度。
     *
     * @var int
     */
    public $recordNumPerHour;

    /**
     * @description 额度有效期开始时间或请假开始时间，毫秒级时间戳。
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 员工userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'calType'          => 'calType',
        'endTime'          => 'endTime',
        'gmtCreate'        => 'gmtCreate',
        'gmtModified'      => 'gmtModified',
        'leaveCode'        => 'leaveCode',
        'leaveReason'      => 'leaveReason',
        'leaveRecordType'  => 'leaveRecordType',
        'leaveStatus'      => 'leaveStatus',
        'leaveViewUnit'    => 'leaveViewUnit',
        'quotaId'          => 'quotaId',
        'recordId'         => 'recordId',
        'recordNumPerDay'  => 'recordNumPerDay',
        'recordNumPerHour' => 'recordNumPerHour',
        'startTime'        => 'startTime',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

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
