<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementFlightResponseBody\module;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @var int
     */
    public $advanceDay;

    /**
     * @var string
     */
    public $airlineCorpCode;

    /**
     * @var string
     */
    public $airlineCorpName;

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
    public $arrAirportCode;

    /**
     * @var string
     */
    public $arrCity;

    /**
     * @var string
     */
    public $arrDate;

    /**
     * @var string
     */
    public $arrStation;

    /**
     * @var string
     */
    public $arrTime;

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
     * @var float
     */
    public $btripCouponFee;

    /**
     * @var float
     */
    public $buildFee;

    /**
     * @var string
     */
    public $cabin;

    /**
     * @var string
     */
    public $cabinClass;

    /**
     * @var string
     */
    public $capitalDirection;

    /**
     * @var string
     */
    public $cascadeDepartment;

    /**
     * @var float
     */
    public $changeFee;

    /**
     * @var float
     */
    public $corpPayOrderFee;

    /**
     * @var string
     */
    public $costCenter;

    /**
     * @var string
     */
    public $costCenterNumber;

    /**
     * @var float
     */
    public $coupon;

    /**
     * @var string
     */
    public $depAirportCode;

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
    public $deptCity;

    /**
     * @var string
     */
    public $deptDate;

    /**
     * @var string
     */
    public $deptStation;

    /**
     * @var string
     */
    public $deptTime;

    /**
     * @var string
     */
    public $discount;

    /**
     * @var string
     */
    public $feeType;

    /**
     * @var string
     */
    public $flightNo;

    /**
     * @var string
     */
    public $index;

    /**
     * @var float
     */
    public $insuranceFee;

    /**
     * @var string
     */
    public $invoiceTitle;

    /**
     * @var string
     */
    public $itineraryNum;

    /**
     * @var float
     */
    public $itineraryPrice;

    /**
     * @var string
     */
    public $mostDifferenceDeptTime;

    /**
     * @var string
     */
    public $mostDifferenceDiscount;

    /**
     * @var string
     */
    public $mostDifferenceFlightNo;

    /**
     * @var float
     */
    public $mostDifferencePrice;

    /**
     * @var string
     */
    public $mostDifferenceReason;

    /**
     * @var float
     */
    public $mostPrice;

    /**
     * @var float
     */
    public $negotiationCouponFee;

    /**
     * @var float
     */
    public $oilFee;

    /**
     * @var string
     */
    public $orderId;

    /**
     * @var string
     */
    public $overApplyId;

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
    public $refundFee;

    /**
     * @var float
     */
    public $refundUpgradeCost;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $repeatRefund;

    /**
     * @var float
     */
    public $sealPrice;

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
     * @var string
     */
    public $ticketId;

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
     * @var float
     */
    public $upgradeCost;

    /**
     * @var int
     */
    public $voucherType;
    protected $_name = [
        'advanceDay' => 'advanceDay',
        'airlineCorpCode' => 'airlineCorpCode',
        'airlineCorpName' => 'airlineCorpName',
        'alipayTradeNo' => 'alipayTradeNo',
        'applyId' => 'applyId',
        'arrAirportCode' => 'arrAirportCode',
        'arrCity' => 'arrCity',
        'arrDate' => 'arrDate',
        'arrStation' => 'arrStation',
        'arrTime' => 'arrTime',
        'billRecordTime' => 'billRecordTime',
        'bookTime' => 'bookTime',
        'bookerId' => 'bookerId',
        'bookerJobNo' => 'bookerJobNo',
        'bookerName' => 'bookerName',
        'btripCouponFee' => 'btripCouponFee',
        'buildFee' => 'buildFee',
        'cabin' => 'cabin',
        'cabinClass' => 'cabinClass',
        'capitalDirection' => 'capitalDirection',
        'cascadeDepartment' => 'cascadeDepartment',
        'changeFee' => 'changeFee',
        'corpPayOrderFee' => 'corpPayOrderFee',
        'costCenter' => 'costCenter',
        'costCenterNumber' => 'costCenterNumber',
        'coupon' => 'coupon',
        'depAirportCode' => 'depAirportCode',
        'department' => 'department',
        'departmentId' => 'departmentId',
        'deptCity' => 'deptCity',
        'deptDate' => 'deptDate',
        'deptStation' => 'deptStation',
        'deptTime' => 'deptTime',
        'discount' => 'discount',
        'feeType' => 'feeType',
        'flightNo' => 'flightNo',
        'index' => 'index',
        'insuranceFee' => 'insuranceFee',
        'invoiceTitle' => 'invoiceTitle',
        'itineraryNum' => 'itineraryNum',
        'itineraryPrice' => 'itineraryPrice',
        'mostDifferenceDeptTime' => 'mostDifferenceDeptTime',
        'mostDifferenceDiscount' => 'mostDifferenceDiscount',
        'mostDifferenceFlightNo' => 'mostDifferenceFlightNo',
        'mostDifferencePrice' => 'mostDifferencePrice',
        'mostDifferenceReason' => 'mostDifferenceReason',
        'mostPrice' => 'mostPrice',
        'negotiationCouponFee' => 'negotiationCouponFee',
        'oilFee' => 'oilFee',
        'orderId' => 'orderId',
        'overApplyId' => 'overApplyId',
        'primaryId' => 'primaryId',
        'projectCode' => 'projectCode',
        'projectName' => 'projectName',
        'refundFee' => 'refundFee',
        'refundUpgradeCost' => 'refundUpgradeCost',
        'remark' => 'remark',
        'repeatRefund' => 'repeatRefund',
        'sealPrice' => 'sealPrice',
        'serviceFee' => 'serviceFee',
        'settlementFee' => 'settlementFee',
        'settlementGrantFee' => 'settlementGrantFee',
        'settlementTime' => 'settlementTime',
        'settlementType' => 'settlementType',
        'status' => 'status',
        'ticketId' => 'ticketId',
        'travelerId' => 'travelerId',
        'travelerJobNo' => 'travelerJobNo',
        'travelerName' => 'travelerName',
        'upgradeCost' => 'upgradeCost',
        'voucherType' => 'voucherType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->advanceDay) {
            $res['advanceDay'] = $this->advanceDay;
        }
        if (null !== $this->airlineCorpCode) {
            $res['airlineCorpCode'] = $this->airlineCorpCode;
        }
        if (null !== $this->airlineCorpName) {
            $res['airlineCorpName'] = $this->airlineCorpName;
        }
        if (null !== $this->alipayTradeNo) {
            $res['alipayTradeNo'] = $this->alipayTradeNo;
        }
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }
        if (null !== $this->arrAirportCode) {
            $res['arrAirportCode'] = $this->arrAirportCode;
        }
        if (null !== $this->arrCity) {
            $res['arrCity'] = $this->arrCity;
        }
        if (null !== $this->arrDate) {
            $res['arrDate'] = $this->arrDate;
        }
        if (null !== $this->arrStation) {
            $res['arrStation'] = $this->arrStation;
        }
        if (null !== $this->arrTime) {
            $res['arrTime'] = $this->arrTime;
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
        if (null !== $this->btripCouponFee) {
            $res['btripCouponFee'] = $this->btripCouponFee;
        }
        if (null !== $this->buildFee) {
            $res['buildFee'] = $this->buildFee;
        }
        if (null !== $this->cabin) {
            $res['cabin'] = $this->cabin;
        }
        if (null !== $this->cabinClass) {
            $res['cabinClass'] = $this->cabinClass;
        }
        if (null !== $this->capitalDirection) {
            $res['capitalDirection'] = $this->capitalDirection;
        }
        if (null !== $this->cascadeDepartment) {
            $res['cascadeDepartment'] = $this->cascadeDepartment;
        }
        if (null !== $this->changeFee) {
            $res['changeFee'] = $this->changeFee;
        }
        if (null !== $this->corpPayOrderFee) {
            $res['corpPayOrderFee'] = $this->corpPayOrderFee;
        }
        if (null !== $this->costCenter) {
            $res['costCenter'] = $this->costCenter;
        }
        if (null !== $this->costCenterNumber) {
            $res['costCenterNumber'] = $this->costCenterNumber;
        }
        if (null !== $this->coupon) {
            $res['coupon'] = $this->coupon;
        }
        if (null !== $this->depAirportCode) {
            $res['depAirportCode'] = $this->depAirportCode;
        }
        if (null !== $this->department) {
            $res['department'] = $this->department;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->deptCity) {
            $res['deptCity'] = $this->deptCity;
        }
        if (null !== $this->deptDate) {
            $res['deptDate'] = $this->deptDate;
        }
        if (null !== $this->deptStation) {
            $res['deptStation'] = $this->deptStation;
        }
        if (null !== $this->deptTime) {
            $res['deptTime'] = $this->deptTime;
        }
        if (null !== $this->discount) {
            $res['discount'] = $this->discount;
        }
        if (null !== $this->feeType) {
            $res['feeType'] = $this->feeType;
        }
        if (null !== $this->flightNo) {
            $res['flightNo'] = $this->flightNo;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->insuranceFee) {
            $res['insuranceFee'] = $this->insuranceFee;
        }
        if (null !== $this->invoiceTitle) {
            $res['invoiceTitle'] = $this->invoiceTitle;
        }
        if (null !== $this->itineraryNum) {
            $res['itineraryNum'] = $this->itineraryNum;
        }
        if (null !== $this->itineraryPrice) {
            $res['itineraryPrice'] = $this->itineraryPrice;
        }
        if (null !== $this->mostDifferenceDeptTime) {
            $res['mostDifferenceDeptTime'] = $this->mostDifferenceDeptTime;
        }
        if (null !== $this->mostDifferenceDiscount) {
            $res['mostDifferenceDiscount'] = $this->mostDifferenceDiscount;
        }
        if (null !== $this->mostDifferenceFlightNo) {
            $res['mostDifferenceFlightNo'] = $this->mostDifferenceFlightNo;
        }
        if (null !== $this->mostDifferencePrice) {
            $res['mostDifferencePrice'] = $this->mostDifferencePrice;
        }
        if (null !== $this->mostDifferenceReason) {
            $res['mostDifferenceReason'] = $this->mostDifferenceReason;
        }
        if (null !== $this->mostPrice) {
            $res['mostPrice'] = $this->mostPrice;
        }
        if (null !== $this->negotiationCouponFee) {
            $res['negotiationCouponFee'] = $this->negotiationCouponFee;
        }
        if (null !== $this->oilFee) {
            $res['oilFee'] = $this->oilFee;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->overApplyId) {
            $res['overApplyId'] = $this->overApplyId;
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
        if (null !== $this->refundFee) {
            $res['refundFee'] = $this->refundFee;
        }
        if (null !== $this->refundUpgradeCost) {
            $res['refundUpgradeCost'] = $this->refundUpgradeCost;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->repeatRefund) {
            $res['repeatRefund'] = $this->repeatRefund;
        }
        if (null !== $this->sealPrice) {
            $res['sealPrice'] = $this->sealPrice;
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
        if (null !== $this->ticketId) {
            $res['ticketId'] = $this->ticketId;
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
        if (null !== $this->upgradeCost) {
            $res['upgradeCost'] = $this->upgradeCost;
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
        if (isset($map['advanceDay'])) {
            $model->advanceDay = $map['advanceDay'];
        }
        if (isset($map['airlineCorpCode'])) {
            $model->airlineCorpCode = $map['airlineCorpCode'];
        }
        if (isset($map['airlineCorpName'])) {
            $model->airlineCorpName = $map['airlineCorpName'];
        }
        if (isset($map['alipayTradeNo'])) {
            $model->alipayTradeNo = $map['alipayTradeNo'];
        }
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }
        if (isset($map['arrAirportCode'])) {
            $model->arrAirportCode = $map['arrAirportCode'];
        }
        if (isset($map['arrCity'])) {
            $model->arrCity = $map['arrCity'];
        }
        if (isset($map['arrDate'])) {
            $model->arrDate = $map['arrDate'];
        }
        if (isset($map['arrStation'])) {
            $model->arrStation = $map['arrStation'];
        }
        if (isset($map['arrTime'])) {
            $model->arrTime = $map['arrTime'];
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
        if (isset($map['btripCouponFee'])) {
            $model->btripCouponFee = $map['btripCouponFee'];
        }
        if (isset($map['buildFee'])) {
            $model->buildFee = $map['buildFee'];
        }
        if (isset($map['cabin'])) {
            $model->cabin = $map['cabin'];
        }
        if (isset($map['cabinClass'])) {
            $model->cabinClass = $map['cabinClass'];
        }
        if (isset($map['capitalDirection'])) {
            $model->capitalDirection = $map['capitalDirection'];
        }
        if (isset($map['cascadeDepartment'])) {
            $model->cascadeDepartment = $map['cascadeDepartment'];
        }
        if (isset($map['changeFee'])) {
            $model->changeFee = $map['changeFee'];
        }
        if (isset($map['corpPayOrderFee'])) {
            $model->corpPayOrderFee = $map['corpPayOrderFee'];
        }
        if (isset($map['costCenter'])) {
            $model->costCenter = $map['costCenter'];
        }
        if (isset($map['costCenterNumber'])) {
            $model->costCenterNumber = $map['costCenterNumber'];
        }
        if (isset($map['coupon'])) {
            $model->coupon = $map['coupon'];
        }
        if (isset($map['depAirportCode'])) {
            $model->depAirportCode = $map['depAirportCode'];
        }
        if (isset($map['department'])) {
            $model->department = $map['department'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['deptCity'])) {
            $model->deptCity = $map['deptCity'];
        }
        if (isset($map['deptDate'])) {
            $model->deptDate = $map['deptDate'];
        }
        if (isset($map['deptStation'])) {
            $model->deptStation = $map['deptStation'];
        }
        if (isset($map['deptTime'])) {
            $model->deptTime = $map['deptTime'];
        }
        if (isset($map['discount'])) {
            $model->discount = $map['discount'];
        }
        if (isset($map['feeType'])) {
            $model->feeType = $map['feeType'];
        }
        if (isset($map['flightNo'])) {
            $model->flightNo = $map['flightNo'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['insuranceFee'])) {
            $model->insuranceFee = $map['insuranceFee'];
        }
        if (isset($map['invoiceTitle'])) {
            $model->invoiceTitle = $map['invoiceTitle'];
        }
        if (isset($map['itineraryNum'])) {
            $model->itineraryNum = $map['itineraryNum'];
        }
        if (isset($map['itineraryPrice'])) {
            $model->itineraryPrice = $map['itineraryPrice'];
        }
        if (isset($map['mostDifferenceDeptTime'])) {
            $model->mostDifferenceDeptTime = $map['mostDifferenceDeptTime'];
        }
        if (isset($map['mostDifferenceDiscount'])) {
            $model->mostDifferenceDiscount = $map['mostDifferenceDiscount'];
        }
        if (isset($map['mostDifferenceFlightNo'])) {
            $model->mostDifferenceFlightNo = $map['mostDifferenceFlightNo'];
        }
        if (isset($map['mostDifferencePrice'])) {
            $model->mostDifferencePrice = $map['mostDifferencePrice'];
        }
        if (isset($map['mostDifferenceReason'])) {
            $model->mostDifferenceReason = $map['mostDifferenceReason'];
        }
        if (isset($map['mostPrice'])) {
            $model->mostPrice = $map['mostPrice'];
        }
        if (isset($map['negotiationCouponFee'])) {
            $model->negotiationCouponFee = $map['negotiationCouponFee'];
        }
        if (isset($map['oilFee'])) {
            $model->oilFee = $map['oilFee'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['overApplyId'])) {
            $model->overApplyId = $map['overApplyId'];
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
        if (isset($map['refundFee'])) {
            $model->refundFee = $map['refundFee'];
        }
        if (isset($map['refundUpgradeCost'])) {
            $model->refundUpgradeCost = $map['refundUpgradeCost'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['repeatRefund'])) {
            $model->repeatRefund = $map['repeatRefund'];
        }
        if (isset($map['sealPrice'])) {
            $model->sealPrice = $map['sealPrice'];
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
        if (isset($map['ticketId'])) {
            $model->ticketId = $map['ticketId'];
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
        if (isset($map['upgradeCost'])) {
            $model->upgradeCost = $map['upgradeCost'];
        }
        if (isset($map['voucherType'])) {
            $model->voucherType = $map['voucherType'];
        }

        return $model;
    }
}
