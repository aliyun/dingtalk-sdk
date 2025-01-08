<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList;

use AlibabaCloud\Tea\Model;

class eTrainTicketDetailVOList extends Model
{
    /**
     * @var string
     */
    public $airConditionType;

    /**
     * @var string
     */
    public $carriageNo;

    /**
     * @var string
     */
    public $destination;

    /**
     * @var string
     */
    public $eticketNo;

    /**
     * @var string
     */
    public $getOnTime;

    /**
     * @var string
     */
    public $invoiceId;

    /**
     * @var string
     */
    public $origin;

    /**
     * @var string
     */
    public $passenger;

    /**
     * @var string
     */
    public $passengerUserId;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $seatClass;

    /**
     * @var string
     */
    public $startTime;

    /**
     * @var string
     */
    public $taxRate;

    /**
     * @var string
     */
    public $ticketType;

    /**
     * @var string
     */
    public $trainNo;
    protected $_name = [
        'airConditionType' => 'airConditionType',
        'carriageNo'       => 'carriageNo',
        'destination'      => 'destination',
        'eticketNo'        => 'eticketNo',
        'getOnTime'        => 'getOnTime',
        'invoiceId'        => 'invoiceId',
        'origin'           => 'origin',
        'passenger'        => 'passenger',
        'passengerUserId'  => 'passengerUserId',
        'remark'           => 'remark',
        'seatClass'        => 'seatClass',
        'startTime'        => 'startTime',
        'taxRate'          => 'taxRate',
        'ticketType'       => 'ticketType',
        'trainNo'          => 'trainNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->airConditionType) {
            $res['airConditionType'] = $this->airConditionType;
        }
        if (null !== $this->carriageNo) {
            $res['carriageNo'] = $this->carriageNo;
        }
        if (null !== $this->destination) {
            $res['destination'] = $this->destination;
        }
        if (null !== $this->eticketNo) {
            $res['eticketNo'] = $this->eticketNo;
        }
        if (null !== $this->getOnTime) {
            $res['getOnTime'] = $this->getOnTime;
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->origin) {
            $res['origin'] = $this->origin;
        }
        if (null !== $this->passenger) {
            $res['passenger'] = $this->passenger;
        }
        if (null !== $this->passengerUserId) {
            $res['passengerUserId'] = $this->passengerUserId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->seatClass) {
            $res['seatClass'] = $this->seatClass;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->taxRate) {
            $res['taxRate'] = $this->taxRate;
        }
        if (null !== $this->ticketType) {
            $res['ticketType'] = $this->ticketType;
        }
        if (null !== $this->trainNo) {
            $res['trainNo'] = $this->trainNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return eTrainTicketDetailVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['airConditionType'])) {
            $model->airConditionType = $map['airConditionType'];
        }
        if (isset($map['carriageNo'])) {
            $model->carriageNo = $map['carriageNo'];
        }
        if (isset($map['destination'])) {
            $model->destination = $map['destination'];
        }
        if (isset($map['eticketNo'])) {
            $model->eticketNo = $map['eticketNo'];
        }
        if (isset($map['getOnTime'])) {
            $model->getOnTime = $map['getOnTime'];
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['origin'])) {
            $model->origin = $map['origin'];
        }
        if (isset($map['passenger'])) {
            $model->passenger = $map['passenger'];
        }
        if (isset($map['passengerUserId'])) {
            $model->passengerUserId = $map['passengerUserId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['seatClass'])) {
            $model->seatClass = $map['seatClass'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['taxRate'])) {
            $model->taxRate = $map['taxRate'];
        }
        if (isset($map['ticketType'])) {
            $model->ticketType = $map['ticketType'];
        }
        if (isset($map['trainNo'])) {
            $model->trainNo = $map['trainNo'];
        }

        return $model;
    }
}
