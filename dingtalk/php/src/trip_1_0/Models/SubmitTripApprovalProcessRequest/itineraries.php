<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SubmitTripApprovalProcessRequest;

use AlibabaCloud\Tea\Model;

class itineraries extends Model
{
    /**
     * @example 2026-01-20 09:00
     *
     * @var string
     */
    public $departureTime;

    /**
     * @example 北京
     *
     * @var string
     */
    public $destination;

    /**
     * @example 望京阿里巴巴园区
     *
     * @var string
     */
    public $destinationDetail;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $placeOfDeparture;

    /**
     * @example 余杭区文一西路969号
     *
     * @var string
     */
    public $placeOfDepartureDetail;

    /**
     * @example 2026-01-22 09:00
     *
     * @var string
     */
    public $returnTime;

    /**
     * @example 单程
     *
     * @var string
     */
    public $singleOrReturn;

    /**
     * @example 飞机
     *
     * @var string
     */
    public $vehicle;
    protected $_name = [
        'departureTime' => 'departureTime',
        'destination' => 'destination',
        'destinationDetail' => 'destinationDetail',
        'placeOfDeparture' => 'placeOfDeparture',
        'placeOfDepartureDetail' => 'placeOfDepartureDetail',
        'returnTime' => 'returnTime',
        'singleOrReturn' => 'singleOrReturn',
        'vehicle' => 'vehicle',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->departureTime) {
            $res['departureTime'] = $this->departureTime;
        }
        if (null !== $this->destination) {
            $res['destination'] = $this->destination;
        }
        if (null !== $this->destinationDetail) {
            $res['destinationDetail'] = $this->destinationDetail;
        }
        if (null !== $this->placeOfDeparture) {
            $res['placeOfDeparture'] = $this->placeOfDeparture;
        }
        if (null !== $this->placeOfDepartureDetail) {
            $res['placeOfDepartureDetail'] = $this->placeOfDepartureDetail;
        }
        if (null !== $this->returnTime) {
            $res['returnTime'] = $this->returnTime;
        }
        if (null !== $this->singleOrReturn) {
            $res['singleOrReturn'] = $this->singleOrReturn;
        }
        if (null !== $this->vehicle) {
            $res['vehicle'] = $this->vehicle;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return itineraries
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departureTime'])) {
            $model->departureTime = $map['departureTime'];
        }
        if (isset($map['destination'])) {
            $model->destination = $map['destination'];
        }
        if (isset($map['destinationDetail'])) {
            $model->destinationDetail = $map['destinationDetail'];
        }
        if (isset($map['placeOfDeparture'])) {
            $model->placeOfDeparture = $map['placeOfDeparture'];
        }
        if (isset($map['placeOfDepartureDetail'])) {
            $model->placeOfDepartureDetail = $map['placeOfDepartureDetail'];
        }
        if (isset($map['returnTime'])) {
            $model->returnTime = $map['returnTime'];
        }
        if (isset($map['singleOrReturn'])) {
            $model->singleOrReturn = $map['singleOrReturn'];
        }
        if (isset($map['vehicle'])) {
            $model->vehicle = $map['vehicle'];
        }

        return $model;
    }
}
