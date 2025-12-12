<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripTrainOrderByPageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripTrainOrderByPageResponseBody\list_\consumerInfos;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $arrivalCity;

    /**
     * @var string
     */
    public $arrivalStation;

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
    public $departmentId;

    /**
     * @var string
     */
    public $departmentName;

    /**
     * @var string
     */
    public $departureCity;

    /**
     * @var string
     */
    public $departureStation;

    /**
     * @var string
     */
    public $departureTime;

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
    public $payType;

    /**
     * @var string
     */
    public $processInstanceId;

    /**
     * @var string
     */
    public $runTime;

    /**
     * @var string
     */
    public $seatType;

    /**
     * @var string
     */
    public $ticketCount;

    /**
     * @var int
     */
    public $totalAmount;

    /**
     * @var string
     */
    public $trainNumber;

    /**
     * @var string
     */
    public $trainOrderStatus;

    /**
     * @var string
     */
    public $trainOrderStatusDesc;

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
        'arrivalCity' => 'arrivalCity',
        'arrivalStation' => 'arrivalStation',
        'arrivalTime' => 'arrivalTime',
        'consumerInfos' => 'consumerInfos',
        'contactName' => 'contactName',
        'costCenter' => 'costCenter',
        'costCenterCode' => 'costCenterCode',
        'createTime' => 'createTime',
        'departmentId' => 'departmentId',
        'departmentName' => 'departmentName',
        'departureCity' => 'departureCity',
        'departureStation' => 'departureStation',
        'departureTime' => 'departureTime',
        'gmtOrder' => 'gmtOrder',
        'gmtPay' => 'gmtPay',
        'invoiceId' => 'invoiceId',
        'invoiceTitle' => 'invoiceTitle',
        'orderDetails' => 'orderDetails',
        'orderNo' => 'orderNo',
        'payType' => 'payType',
        'processInstanceId' => 'processInstanceId',
        'runTime' => 'runTime',
        'seatType' => 'seatType',
        'ticketCount' => 'ticketCount',
        'totalAmount' => 'totalAmount',
        'trainNumber' => 'trainNumber',
        'trainOrderStatus' => 'trainOrderStatus',
        'trainOrderStatusDesc' => 'trainOrderStatusDesc',
        'updateTime' => 'updateTime',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->arrivalCity) {
            $res['arrivalCity'] = $this->arrivalCity;
        }
        if (null !== $this->arrivalStation) {
            $res['arrivalStation'] = $this->arrivalStation;
        }
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
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->departureCity) {
            $res['departureCity'] = $this->departureCity;
        }
        if (null !== $this->departureStation) {
            $res['departureStation'] = $this->departureStation;
        }
        if (null !== $this->departureTime) {
            $res['departureTime'] = $this->departureTime;
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
        if (null !== $this->payType) {
            $res['payType'] = $this->payType;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->runTime) {
            $res['runTime'] = $this->runTime;
        }
        if (null !== $this->seatType) {
            $res['seatType'] = $this->seatType;
        }
        if (null !== $this->ticketCount) {
            $res['ticketCount'] = $this->ticketCount;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
        }
        if (null !== $this->trainNumber) {
            $res['trainNumber'] = $this->trainNumber;
        }
        if (null !== $this->trainOrderStatus) {
            $res['trainOrderStatus'] = $this->trainOrderStatus;
        }
        if (null !== $this->trainOrderStatusDesc) {
            $res['trainOrderStatusDesc'] = $this->trainOrderStatusDesc;
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
        if (isset($map['arrivalCity'])) {
            $model->arrivalCity = $map['arrivalCity'];
        }
        if (isset($map['arrivalStation'])) {
            $model->arrivalStation = $map['arrivalStation'];
        }
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
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['departureCity'])) {
            $model->departureCity = $map['departureCity'];
        }
        if (isset($map['departureStation'])) {
            $model->departureStation = $map['departureStation'];
        }
        if (isset($map['departureTime'])) {
            $model->departureTime = $map['departureTime'];
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
        if (isset($map['payType'])) {
            $model->payType = $map['payType'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['runTime'])) {
            $model->runTime = $map['runTime'];
        }
        if (isset($map['seatType'])) {
            $model->seatType = $map['seatType'];
        }
        if (isset($map['ticketCount'])) {
            $model->ticketCount = $map['ticketCount'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
        }
        if (isset($map['trainNumber'])) {
            $model->trainNumber = $map['trainNumber'];
        }
        if (isset($map['trainOrderStatus'])) {
            $model->trainOrderStatus = $map['trainOrderStatus'];
        }
        if (isset($map['trainOrderStatusDesc'])) {
            $model->trainOrderStatusDesc = $map['trainOrderStatusDesc'];
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
