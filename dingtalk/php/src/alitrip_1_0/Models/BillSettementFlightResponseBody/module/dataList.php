<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementFlightResponseBody\module;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @description 提前预定天数
     *
     * @var int
     */
    public $advanceDay;

    /**
     * @description 航司三字码
     *
     * @var string
     */
    public $airlineCorpCode;

    /**
     * @description 航司名称
     *
     * @var string
     */
    public $airlineCorpName;

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
     * @description 到达机场二字码
     *
     * @var string
     */
    public $arrAirportCode;

    /**
     * @description 到达城市
     *
     * @var string
     */
    public $arrCity;

    /**
     * @description 到达日期
     *
     * @var string
     */
    public $arrDate;

    /**
     * @description 到达机场
     *
     * @var string
     */
    public $arrStation;

    /**
     * @description 到达时间
     *
     * @var string
     */
    public $arrTime;

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
     * @description 预订人use id
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
     * @description 商旅优惠金额
     *
     * @var float
     */
    public $btripCouponFee;

    /**
     * @description 基建费
     *
     * @var float
     */
    public $buildFee;

    /**
     * @description 舱位
     *
     * @var string
     */
    public $cabin;

    /**
     * @description 舱位码
     *
     * @var string
     */
    public $cabinClass;

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
     * @description 改签费用
     *
     * @var float
     */
    public $changeFee;

    /**
     * @description 订单金额
     *
     * @var float
     */
    public $corpPayOrderFee;

    /**
     * @description 成本中心名称
     *
     * @var string
     */
    public $costCenter;

    /**
     * @description 成本中心编号
     *
     * @var string
     */
    public $costCenterNumber;

    /**
     * @description 优惠券
     *
     * @var float
     */
    public $coupon;

    /**
     * @description 起飞机场二字码
     *
     * @var string
     */
    public $depAirportCode;

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
     * @description 起飞城市
     *
     * @var string
     */
    public $deptCity;

    /**
     * @description 起飞日期
     *
     * @var string
     */
    public $deptDate;

    /**
     * @description 起飞机场
     *
     * @var string
     */
    public $deptStation;

    /**
     * @description 起飞时间
     *
     * @var string
     */
    public $deptTime;

    /**
     * @description 折扣率
     *
     * @var string
     */
    public $discount;

    /**
     * @description 费用类型
     *
     * @var string
     */
    public $feeType;

    /**
     * @description 航班号
     *
     * @var string
     */
    public $flightNo;

    /**
     * @description 序号
     *
     * @var string
     */
    public $index;

    /**
     * @description 保险费
     *
     * @var float
     */
    public $insuranceFee;

    /**
     * @description 发票抬头
     *
     * @var string
     */
    public $invoiceTitle;

    /**
     * @description 行程单打印序号
     *
     * @var string
     */
    public $itineraryNum;

    /**
     * @description 行程单金额
     *
     * @var float
     */
    public $itineraryPrice;

    /**
     * @description 低价提醒（起飞时间）
     *
     * @var string
     */
    public $mostDifferenceDeptTime;

    /**
     * @description 低价提醒（折扣）
     *
     * @var string
     */
    public $mostDifferenceDiscount;

    /**
     * @description 低价提醒(航班号)
     *
     * @var string
     */
    public $mostDifferenceFlightNo;

    /**
     * @description 低价提醒(与最低价差额)
     *
     * @var float
     */
    public $mostDifferencePrice;

    /**
     * @description 不选低价原因
     *
     * @var string
     */
    public $mostDifferenceReason;

    /**
     * @description 低价航班价格
     *
     * @var float
     */
    public $mostPrice;

    /**
     * @description 协议价优惠金额
     *
     * @var float
     */
    public $negotiationCouponFee;

    /**
     * @description 燃油费
     *
     * @var float
     */
    public $oilFee;

    /**
     * @description 订单号
     *
     * @var string
     */
    public $orderId;

    /**
     * @description 超标审批单号
     *
     * @var string
     */
    public $overApplyId;

    /**
     * @description 主键id
     *
     * @var int
     */
    public $primaryId;

    /**
     * @description 项目代码
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
     * @description 退款手续费
     *
     * @var float
     */
    public $refundFee;

    /**
     * @description 改签退票手续费
     *
     * @var float
     */
    public $refundUpgradeCost;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 是否重复退
     *
     * @var string
     */
    public $repeatRefund;

    /**
     * @description 销售价
     *
     * @var float
     */
    public $sealPrice;

    /**
     * @description 服务费，仅在feeType  11001、11002中展示
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
     * @description 行程单号
     *
     * @var string
     */
    public $ticketId;

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
     * @description 改签差价
     *
     * @var float
     */
    public $upgradeCost;

    /**
     * @description 发票类型
     *
     * @var int
     */
    public $voucherType;
    protected $_name = [
        'advanceDay'             => 'advanceDay',
        'airlineCorpCode'        => 'airlineCorpCode',
        'airlineCorpName'        => 'airlineCorpName',
        'alipayTradeNo'          => 'alipayTradeNo',
        'applyId'                => 'applyId',
        'arrAirportCode'         => 'arrAirportCode',
        'arrCity'                => 'arrCity',
        'arrDate'                => 'arrDate',
        'arrStation'             => 'arrStation',
        'arrTime'                => 'arrTime',
        'billRecordTime'         => 'billRecordTime',
        'bookTime'               => 'bookTime',
        'bookerId'               => 'bookerId',
        'bookerJobNo'            => 'bookerJobNo',
        'bookerName'             => 'bookerName',
        'btripCouponFee'         => 'btripCouponFee',
        'buildFee'               => 'buildFee',
        'cabin'                  => 'cabin',
        'cabinClass'             => 'cabinClass',
        'capitalDirection'       => 'capitalDirection',
        'cascadeDepartment'      => 'cascadeDepartment',
        'changeFee'              => 'changeFee',
        'corpPayOrderFee'        => 'corpPayOrderFee',
        'costCenter'             => 'costCenter',
        'costCenterNumber'       => 'costCenterNumber',
        'coupon'                 => 'coupon',
        'depAirportCode'         => 'depAirportCode',
        'department'             => 'department',
        'departmentId'           => 'departmentId',
        'deptCity'               => 'deptCity',
        'deptDate'               => 'deptDate',
        'deptStation'            => 'deptStation',
        'deptTime'               => 'deptTime',
        'discount'               => 'discount',
        'feeType'                => 'feeType',
        'flightNo'               => 'flightNo',
        'index'                  => 'index',
        'insuranceFee'           => 'insuranceFee',
        'invoiceTitle'           => 'invoiceTitle',
        'itineraryNum'           => 'itineraryNum',
        'itineraryPrice'         => 'itineraryPrice',
        'mostDifferenceDeptTime' => 'mostDifferenceDeptTime',
        'mostDifferenceDiscount' => 'mostDifferenceDiscount',
        'mostDifferenceFlightNo' => 'mostDifferenceFlightNo',
        'mostDifferencePrice'    => 'mostDifferencePrice',
        'mostDifferenceReason'   => 'mostDifferenceReason',
        'mostPrice'              => 'mostPrice',
        'negotiationCouponFee'   => 'negotiationCouponFee',
        'oilFee'                 => 'oilFee',
        'orderId'                => 'orderId',
        'overApplyId'            => 'overApplyId',
        'primaryId'              => 'primaryId',
        'projectCode'            => 'projectCode',
        'projectName'            => 'projectName',
        'refundFee'              => 'refundFee',
        'refundUpgradeCost'      => 'refundUpgradeCost',
        'remark'                 => 'remark',
        'repeatRefund'           => 'repeatRefund',
        'sealPrice'              => 'sealPrice',
        'serviceFee'             => 'serviceFee',
        'settlementFee'          => 'settlementFee',
        'settlementGrantFee'     => 'settlementGrantFee',
        'settlementTime'         => 'settlementTime',
        'settlementType'         => 'settlementType',
        'status'                 => 'status',
        'ticketId'               => 'ticketId',
        'travelerId'             => 'travelerId',
        'travelerJobNo'          => 'travelerJobNo',
        'travelerName'           => 'travelerName',
        'upgradeCost'            => 'upgradeCost',
        'voucherType'            => 'voucherType',
    ];

    public function validate()
    {
    }

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
