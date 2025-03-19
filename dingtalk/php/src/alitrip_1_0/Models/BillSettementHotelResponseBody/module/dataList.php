<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementHotelResponseBody\module;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @var string
     */
    public $alipayTradeNo;

    /**
     * @var string
     */
    public $applyId;

    /**
     * @var string
     */
    public $billRecordTime;

    /**
     * @var string
     */
    public $bookTime;

    /**
     * @var string
     */
    public $bookerId;

    /**
     * @var string
     */
    public $bookerJobNo;

    /**
     * @var string
     */
    public $bookerName;

    /**
     * @var string
     */
    public $capitalDirection;

    /**
     * @var string
     */
    public $cascadeDepartment;

    /**
     * @var string
     */
    public $checkInDate;

    /**
     * @var string
     */
    public $checkoutDate;

    /**
     * @var string
     */
    public $city;

    /**
     * @var string
     */
    public $cityCode;

    /**
     * @var float
     */
    public $corpRefundFee;

    /**
     * @var float
     */
    public $corpTotalFee;

    /**
     * @var string
     */
    public $costCenter;

    /**
     * @var string
     */
    public $costCenterNumber;

    /**
     * @var string
     */
    public $department;

    /**
     * @var string
     */
    public $departmentId;

    /**
     * @var string
     */
    public $feeType;

    /**
     * @var float
     */
    public $fees;

    /**
     * @var float
     */
    public $fuPointFee;

    /**
     * @var string
     */
    public $hotelName;

    /**
     * @var string
     */
    public $index;

    /**
     * @var string
     */
    public $invoiceTitle;

    /**
     * @var bool
     */
    public $isNegotiation;

    /**
     * @var string
     */
    public $isShareStr;

    /**
     * @var int
     */
    public $nights;

    /**
     * @var string
     */
    public $orderId;

    /**
     * @var float
     */
    public $orderPrice;

    /**
     * @var string
     */
    public $orderType;

    /**
     * @var string
     */
    public $overApplyId;

    /**
     * @var float
     */
    public $personRefundFee;

    /**
     * @var float
     */
    public $personSettlePrice;

    /**
     * @var int
     */
    public $primaryId;

    /**
     * @var string
     */
    public $projectCode;

    /**
     * @var string
     */
    public $projectName;

    /**
     * @var float
     */
    public $promotionFee;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var int
     */
    public $roomNumber;

    /**
     * @var float
     */
    public $roomPrice;

    /**
     * @var string
     */
    public $roomType;

    /**
     * @var float
     */
    public $serviceFee;

    /**
     * @var float
     */
    public $settlementFee;

    /**
     * @var float
     */
    public $settlementGrantFee;

    /**
     * @var string
     */
    public $settlementTime;

    /**
     * @var string
     */
    public $settlementType;

    /**
     * @var int
     */
    public $status;

    /**
     * @var int
     */
    public $totalNights;

    /**
     * @var string
     */
    public $travelerId;

    /**
     * @var string
     */
    public $travelerJobNo;

    /**
     * @var string
     */
    public $travelerName;

    /**
     * @var int
     */
    public $voucherType;
    protected $_name = [
        'alipayTradeNo' => 'alipayTradeNo',
        'applyId' => 'applyId',
        'billRecordTime' => 'billRecordTime',
        'bookTime' => 'bookTime',
        'bookerId' => 'bookerId',
        'bookerJobNo' => 'bookerJobNo',
        'bookerName' => 'bookerName',
        'capitalDirection' => 'capitalDirection',
        'cascadeDepartment' => 'cascadeDepartment',
        'checkInDate' => 'checkInDate',
        'checkoutDate' => 'checkoutDate',
        'city' => 'city',
        'cityCode' => 'cityCode',
        'corpRefundFee' => 'corpRefundFee',
        'corpTotalFee' => 'corpTotalFee',
        'costCenter' => 'costCenter',
        'costCenterNumber' => 'costCenterNumber',
        'department' => 'department',
        'departmentId' => 'departmentId',
        'feeType' => 'feeType',
        'fees' => 'fees',
        'fuPointFee' => 'fuPointFee',
        'hotelName' => 'hotelName',
        'index' => 'index',
        'invoiceTitle' => 'invoiceTitle',
        'isNegotiation' => 'isNegotiation',
        'isShareStr' => 'isShareStr',
        'nights' => 'nights',
        'orderId' => 'orderId',
        'orderPrice' => 'orderPrice',
        'orderType' => 'orderType',
        'overApplyId' => 'overApplyId',
        'personRefundFee' => 'personRefundFee',
        'personSettlePrice' => 'personSettlePrice',
        'primaryId' => 'primaryId',
        'projectCode' => 'projectCode',
        'projectName' => 'projectName',
        'promotionFee' => 'promotionFee',
        'remark' => 'remark',
        'roomNumber' => 'roomNumber',
        'roomPrice' => 'roomPrice',
        'roomType' => 'roomType',
        'serviceFee' => 'serviceFee',
        'settlementFee' => 'settlementFee',
        'settlementGrantFee' => 'settlementGrantFee',
        'settlementTime' => 'settlementTime',
        'settlementType' => 'settlementType',
        'status' => 'status',
        'totalNights' => 'totalNights',
        'travelerId' => 'travelerId',
        'travelerJobNo' => 'travelerJobNo',
        'travelerName' => 'travelerName',
        'voucherType' => 'voucherType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->alipayTradeNo) {
            $res['alipayTradeNo'] = $this->alipayTradeNo;
        }
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }
        if (null !== $this->billRecordTime) {
            $res['billRecordTime'] = $this->billRecordTime;
        }
        if (null !== $this->bookTime) {
            $res['bookTime'] = $this->bookTime;
        }
        if (null !== $this->bookerId) {
            $res['bookerId'] = $this->bookerId;
        }
        if (null !== $this->bookerJobNo) {
            $res['bookerJobNo'] = $this->bookerJobNo;
        }
        if (null !== $this->bookerName) {
            $res['bookerName'] = $this->bookerName;
        }
        if (null !== $this->capitalDirection) {
            $res['capitalDirection'] = $this->capitalDirection;
        }
        if (null !== $this->cascadeDepartment) {
            $res['cascadeDepartment'] = $this->cascadeDepartment;
        }
        if (null !== $this->checkInDate) {
            $res['checkInDate'] = $this->checkInDate;
        }
        if (null !== $this->checkoutDate) {
            $res['checkoutDate'] = $this->checkoutDate;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->cityCode) {
            $res['cityCode'] = $this->cityCode;
        }
        if (null !== $this->corpRefundFee) {
            $res['corpRefundFee'] = $this->corpRefundFee;
        }
        if (null !== $this->corpTotalFee) {
            $res['corpTotalFee'] = $this->corpTotalFee;
        }
        if (null !== $this->costCenter) {
            $res['costCenter'] = $this->costCenter;
        }
        if (null !== $this->costCenterNumber) {
            $res['costCenterNumber'] = $this->costCenterNumber;
        }
        if (null !== $this->department) {
            $res['department'] = $this->department;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->feeType) {
            $res['feeType'] = $this->feeType;
        }
        if (null !== $this->fees) {
            $res['fees'] = $this->fees;
        }
        if (null !== $this->fuPointFee) {
            $res['fuPointFee'] = $this->fuPointFee;
        }
        if (null !== $this->hotelName) {
            $res['hotelName'] = $this->hotelName;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->invoiceTitle) {
            $res['invoiceTitle'] = $this->invoiceTitle;
        }
        if (null !== $this->isNegotiation) {
            $res['isNegotiation'] = $this->isNegotiation;
        }
        if (null !== $this->isShareStr) {
            $res['isShareStr'] = $this->isShareStr;
        }
        if (null !== $this->nights) {
            $res['nights'] = $this->nights;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->orderPrice) {
            $res['orderPrice'] = $this->orderPrice;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }
        if (null !== $this->overApplyId) {
            $res['overApplyId'] = $this->overApplyId;
        }
        if (null !== $this->personRefundFee) {
            $res['personRefundFee'] = $this->personRefundFee;
        }
        if (null !== $this->personSettlePrice) {
            $res['personSettlePrice'] = $this->personSettlePrice;
        }
        if (null !== $this->primaryId) {
            $res['primaryId'] = $this->primaryId;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->projectName) {
            $res['projectName'] = $this->projectName;
        }
        if (null !== $this->promotionFee) {
            $res['promotionFee'] = $this->promotionFee;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->roomNumber) {
            $res['roomNumber'] = $this->roomNumber;
        }
        if (null !== $this->roomPrice) {
            $res['roomPrice'] = $this->roomPrice;
        }
        if (null !== $this->roomType) {
            $res['roomType'] = $this->roomType;
        }
        if (null !== $this->serviceFee) {
            $res['serviceFee'] = $this->serviceFee;
        }
        if (null !== $this->settlementFee) {
            $res['settlementFee'] = $this->settlementFee;
        }
        if (null !== $this->settlementGrantFee) {
            $res['settlementGrantFee'] = $this->settlementGrantFee;
        }
        if (null !== $this->settlementTime) {
            $res['settlementTime'] = $this->settlementTime;
        }
        if (null !== $this->settlementType) {
            $res['settlementType'] = $this->settlementType;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->totalNights) {
            $res['totalNights'] = $this->totalNights;
        }
        if (null !== $this->travelerId) {
            $res['travelerId'] = $this->travelerId;
        }
        if (null !== $this->travelerJobNo) {
            $res['travelerJobNo'] = $this->travelerJobNo;
        }
        if (null !== $this->travelerName) {
            $res['travelerName'] = $this->travelerName;
        }
        if (null !== $this->voucherType) {
            $res['voucherType'] = $this->voucherType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alipayTradeNo'])) {
            $model->alipayTradeNo = $map['alipayTradeNo'];
        }
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }
        if (isset($map['billRecordTime'])) {
            $model->billRecordTime = $map['billRecordTime'];
        }
        if (isset($map['bookTime'])) {
            $model->bookTime = $map['bookTime'];
        }
        if (isset($map['bookerId'])) {
            $model->bookerId = $map['bookerId'];
        }
        if (isset($map['bookerJobNo'])) {
            $model->bookerJobNo = $map['bookerJobNo'];
        }
        if (isset($map['bookerName'])) {
            $model->bookerName = $map['bookerName'];
        }
        if (isset($map['capitalDirection'])) {
            $model->capitalDirection = $map['capitalDirection'];
        }
        if (isset($map['cascadeDepartment'])) {
            $model->cascadeDepartment = $map['cascadeDepartment'];
        }
        if (isset($map['checkInDate'])) {
            $model->checkInDate = $map['checkInDate'];
        }
        if (isset($map['checkoutDate'])) {
            $model->checkoutDate = $map['checkoutDate'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['cityCode'])) {
            $model->cityCode = $map['cityCode'];
        }
        if (isset($map['corpRefundFee'])) {
            $model->corpRefundFee = $map['corpRefundFee'];
        }
        if (isset($map['corpTotalFee'])) {
            $model->corpTotalFee = $map['corpTotalFee'];
        }
        if (isset($map['costCenter'])) {
            $model->costCenter = $map['costCenter'];
        }
        if (isset($map['costCenterNumber'])) {
            $model->costCenterNumber = $map['costCenterNumber'];
        }
        if (isset($map['department'])) {
            $model->department = $map['department'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['feeType'])) {
            $model->feeType = $map['feeType'];
        }
        if (isset($map['fees'])) {
            $model->fees = $map['fees'];
        }
        if (isset($map['fuPointFee'])) {
            $model->fuPointFee = $map['fuPointFee'];
        }
        if (isset($map['hotelName'])) {
            $model->hotelName = $map['hotelName'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['invoiceTitle'])) {
            $model->invoiceTitle = $map['invoiceTitle'];
        }
        if (isset($map['isNegotiation'])) {
            $model->isNegotiation = $map['isNegotiation'];
        }
        if (isset($map['isShareStr'])) {
            $model->isShareStr = $map['isShareStr'];
        }
        if (isset($map['nights'])) {
            $model->nights = $map['nights'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['orderPrice'])) {
            $model->orderPrice = $map['orderPrice'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }
        if (isset($map['overApplyId'])) {
            $model->overApplyId = $map['overApplyId'];
        }
        if (isset($map['personRefundFee'])) {
            $model->personRefundFee = $map['personRefundFee'];
        }
        if (isset($map['personSettlePrice'])) {
            $model->personSettlePrice = $map['personSettlePrice'];
        }
        if (isset($map['primaryId'])) {
            $model->primaryId = $map['primaryId'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['projectName'])) {
            $model->projectName = $map['projectName'];
        }
        if (isset($map['promotionFee'])) {
            $model->promotionFee = $map['promotionFee'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['roomNumber'])) {
            $model->roomNumber = $map['roomNumber'];
        }
        if (isset($map['roomPrice'])) {
            $model->roomPrice = $map['roomPrice'];
        }
        if (isset($map['roomType'])) {
            $model->roomType = $map['roomType'];
        }
        if (isset($map['serviceFee'])) {
            $model->serviceFee = $map['serviceFee'];
        }
        if (isset($map['settlementFee'])) {
            $model->settlementFee = $map['settlementFee'];
        }
        if (isset($map['settlementGrantFee'])) {
            $model->settlementGrantFee = $map['settlementGrantFee'];
        }
        if (isset($map['settlementTime'])) {
            $model->settlementTime = $map['settlementTime'];
        }
        if (isset($map['settlementType'])) {
            $model->settlementType = $map['settlementType'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['totalNights'])) {
            $model->totalNights = $map['totalNights'];
        }
        if (isset($map['travelerId'])) {
            $model->travelerId = $map['travelerId'];
        }
        if (isset($map['travelerJobNo'])) {
            $model->travelerJobNo = $map['travelerJobNo'];
        }
        if (isset($map['travelerName'])) {
            $model->travelerName = $map['travelerName'];
        }
        if (isset($map['voucherType'])) {
            $model->voucherType = $map['voucherType'];
        }

        return $model;
    }
}
