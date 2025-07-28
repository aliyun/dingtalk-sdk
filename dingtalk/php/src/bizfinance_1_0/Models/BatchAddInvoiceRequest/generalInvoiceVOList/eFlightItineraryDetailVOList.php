<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchAddInvoiceRequest\generalInvoiceVOList;

use AlibabaCloud\Tea\Model;

class eFlightItineraryDetailVOList extends Model
{
    /**
     * @var string
     */
    public $carrier;

    /**
     * @var string
     */
    public $className;

    /**
     * @var string
     */
    public $flightNumber;

    /**
     * @var string
     */
    public $flyDate;

    /**
     * @var string
     */
    public $flyFrom;

    /**
     * @var string
     */
    public $flyTime;

    /**
     * @var string
     */
    public $flyTo;

    /**
     * @var string
     */
    public $invoiceDetailNumber;

    /**
     * @var string
     */
    public $invoiceId;

    /**
     * @var string
     */
    public $seat;
    protected $_name = [
        'carrier' => 'carrier',
        'className' => 'className',
        'flightNumber' => 'flightNumber',
        'flyDate' => 'flyDate',
        'flyFrom' => 'flyFrom',
        'flyTime' => 'flyTime',
        'flyTo' => 'flyTo',
        'invoiceDetailNumber' => 'invoiceDetailNumber',
        'invoiceId' => 'invoiceId',
        'seat' => 'seat',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->carrier) {
            $res['carrier'] = $this->carrier;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->flightNumber) {
            $res['flightNumber'] = $this->flightNumber;
        }
        if (null !== $this->flyDate) {
            $res['flyDate'] = $this->flyDate;
        }
        if (null !== $this->flyFrom) {
            $res['flyFrom'] = $this->flyFrom;
        }
        if (null !== $this->flyTime) {
            $res['flyTime'] = $this->flyTime;
        }
        if (null !== $this->flyTo) {
            $res['flyTo'] = $this->flyTo;
        }
        if (null !== $this->invoiceDetailNumber) {
            $res['invoiceDetailNumber'] = $this->invoiceDetailNumber;
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->seat) {
            $res['seat'] = $this->seat;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return eFlightItineraryDetailVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['carrier'])) {
            $model->carrier = $map['carrier'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['flightNumber'])) {
            $model->flightNumber = $map['flightNumber'];
        }
        if (isset($map['flyDate'])) {
            $model->flyDate = $map['flyDate'];
        }
        if (isset($map['flyFrom'])) {
            $model->flyFrom = $map['flyFrom'];
        }
        if (isset($map['flyTime'])) {
            $model->flyTime = $map['flyTime'];
        }
        if (isset($map['flyTo'])) {
            $model->flyTo = $map['flyTo'];
        }
        if (isset($map['invoiceDetailNumber'])) {
            $model->invoiceDetailNumber = $map['invoiceDetailNumber'];
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['seat'])) {
            $model->seat = $map['seat'];
        }

        return $model;
    }
}
