<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\orderDetails\hotelLocation;
use AlibabaCloud\Tea\Model;

class orderDetails extends Model
{
    /**
     * @description 到达时间
     *
     * @var string
     */
    public $arrivalTime;

    /**
     * @description 车辆颜色
     *
     * @var string
     */
    public $carColor;

    /**
     * @description 车辆型号
     *
     * @var string
     */
    public $carModel;

    /**
     * @description 车牌号
     *
     * @var string
     */
    public $carNumber;

    /**
     * @description 餐食描述
     *
     * @var string
     */
    public $cateringType;

    /**
     * @description 入住时间
     *
     * @var string
     */
    public $checkInTime;

    /**
     * @description 离店时间
     *
     * @var string
     */
    public $checkOutTime;

    /**
     * @description 出发时间
     *
     * @var string
     */
    public $departTime;

    /**
     * @description 目的地城市
     *
     * @var string
     */
    public $destinationCity;

    /**
     * @description 目的地城市码
     *
     * @var string
     */
    public $destinationCityCode;

    /**
     * @description 目的站名称
     *
     * @var string
     */
    public $destinationStation;

    /**
     * @description 酒店地址
     *
     * @var string
     */
    public $hotelAddress;

    /**
     * @var string
     */
    public $hotelCity;

    /**
     * @description 酒店定位信息
     *
     * @var hotelLocation
     */
    public $hotelLocation;

    /**
     * @description 酒店名称
     *
     * @var string
     */
    public $hotelName;

    /**
     * @description 出发地城市
     *
     * @var string
     */
    public $originCity;

    /**
     * @description 出发地城市码
     *
     * @var string
     */
    public $originCityCode;

    /**
     * @description 出发站名称
     *
     * @var string
     */
    public $originStation;

    /**
     * @description 房间数
     *
     * @var int
     */
    public $roomCount;

    /**
     * @description 舱位
     *
     * @var string
     */
    public $seatInfo;

    /**
     * @description “服务类型”
     *
     * @var string
     */
    public $serviceType;

    /**
     * @description 下游供应商logo
     *
     * @var string
     */
    public $subSupplyLogo;

    /**
     * @description 下游供应商名称
     *
     * @var string
     */
    public $subSupplyName;

    /**
     * @description 专车类型
     *
     * @var string
     */
    public $taxiType;

    /**
     * @description 联系方式
     *
     * @var string
     */
    public $telephone;

    /**
     * @description 火车/航班班次
     *
     * @var string
     */
    public $transportNumber;

    /**
     * @description 房型描述
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
