<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\orderDetails\hotelLocation;
use AlibabaCloud\Tea\Model;

class orderDetails extends Model
{
    /**
     * @example 2022-05-20 12:20:00
     *
     * @var string
     */
    public $arrivalTime;

    /**
     * @example 红色
     *
     * @var string
     */
    public $carColor;

    /**
     * @example 帕萨特
     *
     * @var string
     */
    public $carModel;

    /**
     * @example 浙A0Z***7
     *
     * @var string
     */
    public $carNumber;

    /**
     * @example 单早
     *
     * @var string
     */
    public $cateringType;

    /**
     * @example 2022-05-20 14:00:00
     *
     * @var string
     */
    public $checkInTime;

    /**
     * @example 2022-05-21 12:00:00
     *
     * @var string
     */
    public $checkOutTime;

    /**
     * @example 2022-05-20 10:00:00
     *
     * @var string
     */
    public $departTime;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $destinationCity;

    /**
     * @example 151
     *
     * @var string
     */
    public $destinationCityCode;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $destinationStation;

    /**
     * @example 浙江省杭州市余杭区聚橙路文昌路
     *
     * @var string
     */
    public $hotelAddress;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $hotelCity;

    /**
     * @var hotelLocation
     */
    public $hotelLocation;

    /**
     * @example 亲橙客栈
     *
     * @var string
     */
    public $hotelName;

    /**
     * @example 北京
     *
     * @var string
     */
    public $originCity;

    /**
     * @example 150
     *
     * @var string
     */
    public $originCityCode;

    /**
     * @example 北京
     *
     * @var string
     */
    public $originStation;

    /**
     * @var int
     */
    public $roomCount;

    /**
     * @example 经济舱/7车12A
     *
     * @var string
     */
    public $seatInfo;

    /**
     * @example REALTIME
     *
     * @var string
     */
    public $serviceType;

    /**
     * @example http://dingtalk.com/static/logo.png
     *
     * @var string
     */
    public $subSupplyLogo;

    /**
     * @example 国航
     *
     * @var string
     */
    public $subSupplyName;

    /**
     * @example 专车
     *
     * @var string
     */
    public $taxiType;

    /**
     * @example 2022-05-20 14:00:00
     *
     * @var string
     */
    public $telephone;

    /**
     * @example CA1762
     *
     * @var string
     */
    public $transportNumber;

    /**
     * @example 商务标准间
     *
     * @var string
     */
    public $typeDescription;
    protected $_name = [
        'arrivalTime'         => 'arrivalTime',
        'carColor'            => 'carColor',
        'carModel'            => 'carModel',
        'carNumber'           => 'carNumber',
        'cateringType'        => 'cateringType',
        'checkInTime'         => 'checkInTime',
        'checkOutTime'        => 'checkOutTime',
        'departTime'          => 'departTime',
        'destinationCity'     => 'destinationCity',
        'destinationCityCode' => 'destinationCityCode',
        'destinationStation'  => 'destinationStation',
        'hotelAddress'        => 'hotelAddress',
        'hotelCity'           => 'hotelCity',
        'hotelLocation'       => 'hotelLocation',
        'hotelName'           => 'hotelName',
        'originCity'          => 'originCity',
        'originCityCode'      => 'originCityCode',
        'originStation'       => 'originStation',
        'roomCount'           => 'roomCount',
        'seatInfo'            => 'seatInfo',
        'serviceType'         => 'serviceType',
        'subSupplyLogo'       => 'subSupplyLogo',
        'subSupplyName'       => 'subSupplyName',
        'taxiType'            => 'taxiType',
        'telephone'           => 'telephone',
        'transportNumber'     => 'transportNumber',
        'typeDescription'     => 'typeDescription',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->arrivalTime) {
            $res['arrivalTime'] = $this->arrivalTime;
        }
        if (null !== $this->carColor) {
            $res['carColor'] = $this->carColor;
        }
        if (null !== $this->carModel) {
            $res['carModel'] = $this->carModel;
        }
        if (null !== $this->carNumber) {
            $res['carNumber'] = $this->carNumber;
        }
        if (null !== $this->cateringType) {
            $res['cateringType'] = $this->cateringType;
        }
        if (null !== $this->checkInTime) {
            $res['checkInTime'] = $this->checkInTime;
        }
        if (null !== $this->checkOutTime) {
            $res['checkOutTime'] = $this->checkOutTime;
        }
        if (null !== $this->departTime) {
            $res['departTime'] = $this->departTime;
        }
        if (null !== $this->destinationCity) {
            $res['destinationCity'] = $this->destinationCity;
        }
        if (null !== $this->destinationCityCode) {
            $res['destinationCityCode'] = $this->destinationCityCode;
        }
        if (null !== $this->destinationStation) {
            $res['destinationStation'] = $this->destinationStation;
        }
        if (null !== $this->hotelAddress) {
            $res['hotelAddress'] = $this->hotelAddress;
        }
        if (null !== $this->hotelCity) {
            $res['hotelCity'] = $this->hotelCity;
        }
        if (null !== $this->hotelLocation) {
            $res['hotelLocation'] = null !== $this->hotelLocation ? $this->hotelLocation->toMap() : null;
        }
        if (null !== $this->hotelName) {
            $res['hotelName'] = $this->hotelName;
        }
        if (null !== $this->originCity) {
            $res['originCity'] = $this->originCity;
        }
        if (null !== $this->originCityCode) {
            $res['originCityCode'] = $this->originCityCode;
        }
        if (null !== $this->originStation) {
            $res['originStation'] = $this->originStation;
        }
        if (null !== $this->roomCount) {
            $res['roomCount'] = $this->roomCount;
        }
        if (null !== $this->seatInfo) {
            $res['seatInfo'] = $this->seatInfo;
        }
        if (null !== $this->serviceType) {
            $res['serviceType'] = $this->serviceType;
        }
        if (null !== $this->subSupplyLogo) {
            $res['subSupplyLogo'] = $this->subSupplyLogo;
        }
        if (null !== $this->subSupplyName) {
            $res['subSupplyName'] = $this->subSupplyName;
        }
        if (null !== $this->taxiType) {
            $res['taxiType'] = $this->taxiType;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }
        if (null !== $this->transportNumber) {
            $res['transportNumber'] = $this->transportNumber;
        }
        if (null !== $this->typeDescription) {
            $res['typeDescription'] = $this->typeDescription;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orderDetails
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['arrivalTime'])) {
            $model->arrivalTime = $map['arrivalTime'];
        }
        if (isset($map['carColor'])) {
            $model->carColor = $map['carColor'];
        }
        if (isset($map['carModel'])) {
            $model->carModel = $map['carModel'];
        }
        if (isset($map['carNumber'])) {
            $model->carNumber = $map['carNumber'];
        }
        if (isset($map['cateringType'])) {
            $model->cateringType = $map['cateringType'];
        }
        if (isset($map['checkInTime'])) {
            $model->checkInTime = $map['checkInTime'];
        }
        if (isset($map['checkOutTime'])) {
            $model->checkOutTime = $map['checkOutTime'];
        }
        if (isset($map['departTime'])) {
            $model->departTime = $map['departTime'];
        }
        if (isset($map['destinationCity'])) {
            $model->destinationCity = $map['destinationCity'];
        }
        if (isset($map['destinationCityCode'])) {
            $model->destinationCityCode = $map['destinationCityCode'];
        }
        if (isset($map['destinationStation'])) {
            $model->destinationStation = $map['destinationStation'];
        }
        if (isset($map['hotelAddress'])) {
            $model->hotelAddress = $map['hotelAddress'];
        }
        if (isset($map['hotelCity'])) {
            $model->hotelCity = $map['hotelCity'];
        }
        if (isset($map['hotelLocation'])) {
            $model->hotelLocation = hotelLocation::fromMap($map['hotelLocation']);
        }
        if (isset($map['hotelName'])) {
            $model->hotelName = $map['hotelName'];
        }
        if (isset($map['originCity'])) {
            $model->originCity = $map['originCity'];
        }
        if (isset($map['originCityCode'])) {
            $model->originCityCode = $map['originCityCode'];
        }
        if (isset($map['originStation'])) {
            $model->originStation = $map['originStation'];
        }
        if (isset($map['roomCount'])) {
            $model->roomCount = $map['roomCount'];
        }
        if (isset($map['seatInfo'])) {
            $model->seatInfo = $map['seatInfo'];
        }
        if (isset($map['serviceType'])) {
            $model->serviceType = $map['serviceType'];
        }
        if (isset($map['subSupplyLogo'])) {
            $model->subSupplyLogo = $map['subSupplyLogo'];
        }
        if (isset($map['subSupplyName'])) {
            $model->subSupplyName = $map['subSupplyName'];
        }
        if (isset($map['taxiType'])) {
            $model->taxiType = $map['taxiType'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }
        if (isset($map['transportNumber'])) {
            $model->transportNumber = $map['transportNumber'];
        }
        if (isset($map['typeDescription'])) {
            $model->typeDescription = $map['typeDescription'];
        }

        return $model;
    }
}
