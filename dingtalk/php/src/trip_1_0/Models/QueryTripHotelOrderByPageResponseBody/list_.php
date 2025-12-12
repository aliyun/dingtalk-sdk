<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripHotelOrderByPageResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\QueryTripHotelOrderByPageResponseBody\list_\consumerInfos;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $checkInTime;

    /**
     * @var string
     */
    public $checkOutTime;

    /**
     * @var string
     */
    public $city;

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
    public $guest;

    /**
     * @var string
     */
    public $hotelName;

    /**
     * @var string
     */
    public $hotelOrderStatus;

    /**
     * @var string
     */
    public $hotelOrderStatusDesc;

    /**
     * @var string
     */
    public $invoiceId;

    /**
     * @var string
     */
    public $invoiceTitle;

    /**
     * @var int
     */
    public $night;

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
     * @var int
     */
    public $roomNum;

    /**
     * @var string
     */
    public $roomType;

    /**
     * @var int
     */
    public $totalAmount;

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
        'checkInTime' => 'checkInTime',
        'checkOutTime' => 'checkOutTime',
        'city' => 'city',
        'consumerInfos' => 'consumerInfos',
        'contactName' => 'contactName',
        'costCenter' => 'costCenter',
        'costCenterCode' => 'costCenterCode',
        'createTime' => 'createTime',
        'departmentId' => 'departmentId',
        'departmentName' => 'departmentName',
        'gmtOrder' => 'gmtOrder',
        'gmtPay' => 'gmtPay',
        'guest' => 'guest',
        'hotelName' => 'hotelName',
        'hotelOrderStatus' => 'hotelOrderStatus',
        'hotelOrderStatusDesc' => 'hotelOrderStatusDesc',
        'invoiceId' => 'invoiceId',
        'invoiceTitle' => 'invoiceTitle',
        'night' => 'night',
        'orderDetails' => 'orderDetails',
        'orderNo' => 'orderNo',
        'payType' => 'payType',
        'processInstanceId' => 'processInstanceId',
        'roomNum' => 'roomNum',
        'roomType' => 'roomType',
        'totalAmount' => 'totalAmount',
        'updateTime' => 'updateTime',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkInTime) {
            $res['checkInTime'] = $this->checkInTime;
        }
        if (null !== $this->checkOutTime) {
            $res['checkOutTime'] = $this->checkOutTime;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
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
        if (null !== $this->gmtOrder) {
            $res['gmtOrder'] = $this->gmtOrder;
        }
        if (null !== $this->gmtPay) {
            $res['gmtPay'] = $this->gmtPay;
        }
        if (null !== $this->guest) {
            $res['guest'] = $this->guest;
        }
        if (null !== $this->hotelName) {
            $res['hotelName'] = $this->hotelName;
        }
        if (null !== $this->hotelOrderStatus) {
            $res['hotelOrderStatus'] = $this->hotelOrderStatus;
        }
        if (null !== $this->hotelOrderStatusDesc) {
            $res['hotelOrderStatusDesc'] = $this->hotelOrderStatusDesc;
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->invoiceTitle) {
            $res['invoiceTitle'] = $this->invoiceTitle;
        }
        if (null !== $this->night) {
            $res['night'] = $this->night;
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
        if (null !== $this->roomNum) {
            $res['roomNum'] = $this->roomNum;
        }
        if (null !== $this->roomType) {
            $res['roomType'] = $this->roomType;
        }
        if (null !== $this->totalAmount) {
            $res['totalAmount'] = $this->totalAmount;
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
        if (isset($map['checkInTime'])) {
            $model->checkInTime = $map['checkInTime'];
        }
        if (isset($map['checkOutTime'])) {
            $model->checkOutTime = $map['checkOutTime'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
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
        if (isset($map['gmtOrder'])) {
            $model->gmtOrder = $map['gmtOrder'];
        }
        if (isset($map['gmtPay'])) {
            $model->gmtPay = $map['gmtPay'];
        }
        if (isset($map['guest'])) {
            $model->guest = $map['guest'];
        }
        if (isset($map['hotelName'])) {
            $model->hotelName = $map['hotelName'];
        }
        if (isset($map['hotelOrderStatus'])) {
            $model->hotelOrderStatus = $map['hotelOrderStatus'];
        }
        if (isset($map['hotelOrderStatusDesc'])) {
            $model->hotelOrderStatusDesc = $map['hotelOrderStatusDesc'];
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['invoiceTitle'])) {
            $model->invoiceTitle = $map['invoiceTitle'];
        }
        if (isset($map['night'])) {
            $model->night = $map['night'];
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
        if (isset($map['roomNum'])) {
            $model->roomNum = $map['roomNum'];
        }
        if (isset($map['roomType'])) {
            $model->roomType = $map['roomType'];
        }
        if (isset($map['totalAmount'])) {
            $model->totalAmount = $map['totalAmount'];
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
