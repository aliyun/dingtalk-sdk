<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripFlightOrderByPageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripFlightOrderByPageResponseBody\list_\consumerInfos;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $arrivalTime;

    /**
     * @var consumerInfos[]
     */
    public $consumerInfos;

    /**
     * @var string
     */
    public $contactName;

    /**
     * @var string
     */
    public $costCenter;

    /**
     * @var string
     */
    public $costCenterCode;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $departTime;

    /**
     * @var string
     */
    public $departmentId;

    /**
     * @var string
     */
    public $departmentName;

    /**
     * @var string
     */
    public $destinationCity;

    /**
     * @var string
     */
    public $destinationStation;

    /**
     * @var int
     */
    public $flightOrderStatus;

    /**
     * @var string
     */
    public $flightOrderStatusDesc;

    /**
     * @var int
     */
    public $gmtOrder;

    /**
     * @var int
     */
    public $gmtPay;

    /**
     * @var string
     */
    public $invoiceId;

    /**
     * @var string
     */
    public $invoiceTitle;

    /**
     * @var string
     */
    public $orderDetails;

    /**
     * @var string
     */
    public $orderNo;

    /**
     * @var string
     */
    public $originCity;

    /**
     * @var string
     */
    public $originStation;

    /**
     * @var int
     */
    public $passengerCount;

    /**
     * @var string
     */
    public $passengerName;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $seatType;

    /**
     * @var int
     */
    public $totalAmount;

    /**
     * @var string
     */
    public $transportNumber;

    /**
     * @var string
     */
    public $tripType;

    /**
     * @var int
     */
    public $updateTime;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userName;
    protected $_name = [
        'arrivalTime' => 'arrivalTime',
        'consumerInfos' => 'consumerInfos',
        'contactName' => 'contactName',
        'costCenter' => 'costCenter',
        'costCenterCode' => 'costCenterCode',
        'createTime' => 'createTime',
        'departTime' => 'departTime',
        'departmentId' => 'departmentId',
        'departmentName' => 'departmentName',
        'destinationCity' => 'destinationCity',
        'destinationStation' => 'destinationStation',
        'flightOrderStatus' => 'flightOrderStatus',
        'flightOrderStatusDesc' => 'flightOrderStatusDesc',
        'gmtOrder' => 'gmtOrder',
        'gmtPay' => 'gmtPay',
        'invoiceId' => 'invoiceId',
        'invoiceTitle' => 'invoiceTitle',
        'orderDetails' => 'orderDetails',
        'orderNo' => 'orderNo',
        'originCity' => 'originCity',
        'originStation' => 'originStation',
        'passengerCount' => 'passengerCount',
        'passengerName' => 'passengerName',
        'processInstanceId' => 'processInstanceId',
        'seatType' => 'seatType',
        'totalAmount' => 'totalAmount',
        'transportNumber' => 'transportNumber',
        'tripType' => 'tripType',
        'updateTime' => 'updateTime',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->arrivalTime) {
            $res['arrivalTime'] = $this->arrivalTime;
        }
        if (null !== $this->consumerInfos) {
            $res['consumerInfos'] = [];
            if (null !== $this->consumerInfos && \is_array($this->consumerInfos)) {
                $n = 0;
                foreach ($this->consumerInfos as $item) {
                    $res['consumerInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->contactName) {
            $res['contactName'] = $this->contactName;
        }
        if (null !== $this->costCenter) {
            $res['costCenter'] = $this->costCenter;
        }
        if (null !== $this->costCenterCode) {
            $res['costCenterCode'] = $this->costCenterCode;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->departTime) {
            $res['departTime'] = $this->departTime;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->destinationCity) {
            $res['destinationCity'] = $this->destinationCity;
        }
        if (null !== $this->destinationStation) {
            $res['destinationStation'] = $this->destinationStation;
        }
        if (null !== $this->flightOrderStatus) {
            $res['flightOrderStatus'] = $this->flightOrderStatus;
        }
        if (null !== $this->flightOrderStatusDesc) {
            $res['flightOrderStatusDesc'] = $this->flightOrderStatusDesc;
        }
        if (null !== $this->gmtOrder) {
            $res['gmtOrder'] = $this->gmtOrder;
        }
        if (null !== $this->gmtPay) {
            $res['gmtPay'] = $this->gmtPay;
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->invoiceTitle) {
            $res['invoiceTitle'] = $this->invoiceTitle;
        }
        if (null !== $this->orderDetails) {
            $res['orderDetails'] = $this->orderDetails;
        }
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }
        if (null !== $this->originCity) {
            $res['originCity'] = $this->originCity;
        }
        if (null !== $this->originStation) {
            $res['originStation'] = $this->originStation;
        }
        if (null !== $this->passengerCount) {
            $res['passengerCount'] = $this->passengerCount;
        }
        if (null !== $this->passengerName) {
            $res['passengerName'] = $this->passengerName;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->seatType) {
            $res['seatType'] = $this->seatType;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->transportNumber) {
            $res['transportNumber'] = $this->transportNumber;
        }
        if (null !== $this->tripType) {
            $res['tripType'] = $this->tripType;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['arrivalTime'])) {
            $model->arrivalTime = $map['arrivalTime'];
        }
        if (isset($map['consumerInfos'])) {
            if (!empty($map['consumerInfos'])) {
                $model->consumerInfos = [];
                $n = 0;
                foreach ($map['consumerInfos'] as $item) {
                    $model->consumerInfos[$n++] = null !== $item ? consumerInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['contactName'])) {
            $model->contactName = $map['contactName'];
        }
        if (isset($map['costCenter'])) {
            $model->costCenter = $map['costCenter'];
        }
        if (isset($map['costCenterCode'])) {
            $model->costCenterCode = $map['costCenterCode'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['departTime'])) {
            $model->departTime = $map['departTime'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['destinationCity'])) {
            $model->destinationCity = $map['destinationCity'];
        }
        if (isset($map['destinationStation'])) {
            $model->destinationStation = $map['destinationStation'];
        }
        if (isset($map['flightOrderStatus'])) {
            $model->flightOrderStatus = $map['flightOrderStatus'];
        }
        if (isset($map['flightOrderStatusDesc'])) {
            $model->flightOrderStatusDesc = $map['flightOrderStatusDesc'];
        }
        if (isset($map['gmtOrder'])) {
            $model->gmtOrder = $map['gmtOrder'];
        }
        if (isset($map['gmtPay'])) {
            $model->gmtPay = $map['gmtPay'];
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['invoiceTitle'])) {
            $model->invoiceTitle = $map['invoiceTitle'];
        }
        if (isset($map['orderDetails'])) {
            $model->orderDetails = $map['orderDetails'];
        }
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }
        if (isset($map['originCity'])) {
            $model->originCity = $map['originCity'];
        }
        if (isset($map['originStation'])) {
            $model->originStation = $map['originStation'];
        }
        if (isset($map['passengerCount'])) {
            $model->passengerCount = $map['passengerCount'];
        }
        if (isset($map['passengerName'])) {
            $model->passengerName = $map['passengerName'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['seatType'])) {
            $model->seatType = $map['seatType'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['transportNumber'])) {
            $model->transportNumber = $map['transportNumber'];
        }
        if (isset($map['tripType'])) {
            $model->tripType = $map['tripType'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
