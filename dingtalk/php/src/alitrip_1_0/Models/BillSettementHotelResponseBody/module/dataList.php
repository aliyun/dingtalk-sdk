<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementHotelResponseBody\module;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @description 交易流水号
     *
     * @var string
     */
    public $alipayTradeNo;

    /**
     * @description 审批单号
     *
     * @var string
     */
    public $applyId;

    /**
     * @description 入账时间
     *
     * @var string
     */
    public $billRecordTime;

    /**
     * @description 预定时间
     *
     * @var string
     */
    public $bookTime;

    /**
     * @description 预定人use id
     *
     * @var string
     */
    public $bookerId;

    /**
     * @description 预订人工号
     *
     * @var string
     */
    public $bookerJobNo;

    /**
     * @description 预订人名称
     *
     * @var string
     */
    public $bookerName;

    /**
     * @description 资金方向
     *
     * @var string
     */
    public $capitalDirection;

    /**
     * @description 级联部门
     *
     * @var string
     */
    public $cascadeDepartment;

    /**
     * @description 入住时间
     *
     * @var string
     */
    public $checkInDate;

    /**
     * @description 离店时间
     *
     * @var string
     */
    public $checkoutDate;

    /**
     * @description 入住城市
     *
     * @var string
     */
    public $city;

    /**
     * @description 城市编码
     *
     * @var string
     */
    public $cityCode;

    /**
     * @description 企业退款金额
     *
     * @var float
     */
    public $corpRefundFee;

    /**
     * @description 企业支付金额
     *
     * @var float
     */
    public $corpTotalFee;

    /**
     * @description 成本中心名称
     *
     * @var string
     */
    public $costCenter;

    /**
     * @description 成本中心编码
     *
     * @var string
     */
    public $costCenterNumber;

    /**
     * @description 末级部门
     *
     * @var string
     */
    public $department;

    /**
     * @description 部门id
     *
     * @var string
     */
    public $departmentId;

    /**
     * @description 费用类型
     *
     * @var string
     */
    public $feeType;

    /**
     * @description 杂费
     *
     * @var float
     */
    public $fees;

    /**
     * @description 福豆支付
     *
     * @var float
     */
    public $fuPointFee;

    /**
     * @description 酒店名称
     *
     * @var string
     */
    public $hotelName;

    /**
     * @description 序号
     *
     * @var string
     */
    public $index;

    /**
     * @description 发票抬头
     *
     * @var string
     */
    public $invoiceTitle;

    /**
     * @description 是否协议价
     *
     * @var bool
     */
    public $isNegotiation;

    /**
     * @description 是否合住
     *
     * @var string
     */
    public $isShareStr;

    /**
     * @description 入住天数
     *
     * @var int
     */
    public $nights;

    /**
     * @description 订单号
     *
     * @var string
     */
    public $orderId;

    /**
     * @description 订单金额
     *
     * @var float
     */
    public $orderPrice;

    /**
     * @description 订单类型
     *
     * @var string
     */
    public $orderType;

    /**
     * @description 超标审批单号
     *
     * @var string
     */
    public $overApplyId;

    /**
     * @description 个人退款金额
     *
     * @var float
     */
    public $personRefundFee;

    /**
     * @description 个人支付金额
     *
     * @var float
     */
    public $personSettlePrice;

    /**
     * @description 主键id
     *
     * @var int
     */
    public $primaryId;

    /**
     * @description 项目编码
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description 项目名称
     *
     * @var string
     */
    public $projectName;

    /**
     * @description 优惠券
     *
     * @var float
     */
    public $promotionFee;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 房间数
     *
     * @var int
     */
    public $roomNumber;

    /**
     * @description 房价
     *
     * @var float
     */
    public $roomPrice;

    /**
     * @description 房间类型
     *
     * @var string
     */
    public $roomType;

    /**
     * @description 服务费,仅在 feeType 20111、20112中展示
     *
     * @var float
     */
    public $serviceFee;

    /**
     * @description 结算金额
     *
     * @var float
     */
    public $settlementFee;

    /**
     * @description 预存赠送金额消费
     *
     * @var float
     */
    public $settlementGrantFee;

    /**
     * @description 结算时间
     *
     * @var string
     */
    public $settlementTime;

    /**
     * @description 结算类型
     *
     * @var string
     */
    public $settlementType;

    /**
     * @description 入账状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 总间夜数
     *
     * @var int
     */
    public $totalNights;

    /**
     * @description 出行人use id
     *
     * @var string
     */
    public $travelerId;

    /**
     * @description 出行人工号
     *
     * @var string
     */
    public $travelerJobNo;

    /**
     * @description 出行人名称
     *
     * @var string
     */
    public $travelerName;

    /**
     * @description 发票类型
     *
     * @var int
     */
    public $voucherType;
    protected $_name = [
        'alipayTradeNo'      => 'alipayTradeNo',
        'applyId'            => 'applyId',
        'billRecordTime'     => 'billRecordTime',
        'bookTime'           => 'bookTime',
        'bookerId'           => 'bookerId',
        'bookerJobNo'        => 'bookerJobNo',
        'bookerName'         => 'bookerName',
        'capitalDirection'   => 'capitalDirection',
        'cascadeDepartment'  => 'cascadeDepartment',
        'checkInDate'        => 'checkInDate',
        'checkoutDate'       => 'checkoutDate',
        'city'               => 'city',
        'cityCode'           => 'cityCode',
        'corpRefundFee'      => 'corpRefundFee',
        'corpTotalFee'       => 'corpTotalFee',
        'costCenter'         => 'costCenter',
        'costCenterNumber'   => 'costCenterNumber',
        'department'         => 'department',
        'departmentId'       => 'departmentId',
        'feeType'            => 'feeType',
        'fees'               => 'fees',
        'fuPointFee'         => 'fuPointFee',
        'hotelName'          => 'hotelName',
        'index'              => 'index',
        'invoiceTitle'       => 'invoiceTitle',
        'isNegotiation'      => 'isNegotiation',
        'isShareStr'         => 'isShareStr',
        'nights'             => 'nights',
        'orderId'            => 'orderId',
        'orderPrice'         => 'orderPrice',
        'orderType'          => 'orderType',
        'overApplyId'        => 'overApplyId',
        'personRefundFee'    => 'personRefundFee',
        'personSettlePrice'  => 'personSettlePrice',
        'primaryId'          => 'primaryId',
        'projectCode'        => 'projectCode',
        'projectName'        => 'projectName',
        'promotionFee'       => 'promotionFee',
        'remark'             => 'remark',
        'roomNumber'         => 'roomNumber',
        'roomPrice'          => 'roomPrice',
        'roomType'           => 'roomType',
        'serviceFee'         => 'serviceFee',
        'settlementFee'      => 'settlementFee',
        'settlementGrantFee' => 'settlementGrantFee',
        'settlementTime'     => 'settlementTime',
        'settlementType'     => 'settlementType',
        'status'             => 'status',
        'totalNights'        => 'totalNights',
        'travelerId'         => 'travelerId',
        'travelerJobNo'      => 'travelerJobNo',
        'travelerName'       => 'travelerName',
        'voucherType'        => 'voucherType',
    ];

    public function validate()
    {
    }

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
