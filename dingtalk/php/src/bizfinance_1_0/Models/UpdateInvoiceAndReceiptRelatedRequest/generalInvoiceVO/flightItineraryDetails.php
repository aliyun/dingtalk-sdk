<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateInvoiceAndReceiptRelatedRequest\generalInvoiceVO;

use AlibabaCloud\Tea\Model;

class flightItineraryDetails extends Model
{
    /**
     * @example 北京国际机场
     *
     * @var string
     */
    public $carrier;

    /**
     * @example AA1234
     *
     * @var string
     */
    public $flightNumber;

    /**
     * @example 2023-05-11
     *
     * @var string
     */
    public $flyDate;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $flyFrom;

    /**
     * @example 16:00
     *
     * @var string
     */
    public $flyTime;

    /**
     * @example 北京
     *
     * @var string
     */
    public $flyTo;

    /**
     * @example 头等舱
     *
     * @var string
     */
    public $seat;
    protected $_name = [
        'carrier'      => 'carrier',
        'flightNumber' => 'flightNumber',
        'flyDate'      => 'flyDate',
        'flyFrom'      => 'flyFrom',
        'flyTime'      => 'flyTime',
        'flyTo'        => 'flyTo',
        'seat'         => 'seat',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->carrier) {
            $res['carrier'] = $this->carrier;
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
        if (null !== $this->seat) {
            $res['seat'] = $this->seat;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return flightItineraryDetails
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['carrier'])) {
            $model->carrier = $map['carrier'];
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
        if (isset($map['seat'])) {
            $model->seat = $map['seat'];
        }

        return $model;
    }
}
