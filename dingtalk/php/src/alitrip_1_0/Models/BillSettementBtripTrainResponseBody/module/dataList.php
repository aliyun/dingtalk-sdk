<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementBtripTrainResponseBody\module;

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
     * @description 到达日期
     *
     * @var string
     */
    public $arrDate;

    /**
     * @description 到达站点
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
     * @description 改签手续费
     *
     * @var float
     */
    public $changeFee;

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
     * @description 折扣率
     *
     * @var float
     */
    public $coupon;

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
     * @description 出发日期
     *
     * @var string
     */
    public $deptDate;

    /**
     * @description 出发站
     *
     * @var string
     */
    public $deptStation;

    /**
     * @description 出发时间
     *
     * @var string
     */
    public $deptTime;

    /**
     * @description 费用类型
     *
     * @var string
     */
    public $feeType;

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
     * @description 项目编号
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
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 运行时长
     *
     * @var string
     */
    public $runTime;

    /**
     * @description 座位号
     *
     * @var string
     */
    public $seatNo;

    /**
     * @description 坐席
     *
     * @var string
     */
    public $seatType;

    /**
     * @description 服务费，仅在feeType 6007、6008中展示
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
     * @description 票面票号
     *
     * @var string
     */
    public $ticketNo;

    /**
     * @description 票价
     *
     * @var float
     */
    public $ticketPrice;

    /**
     * @description 车次号
     *
     * @var string
     */
    public $trainNo;

    /**
     * @description 车次类型
     *
     * @var string
     */
    public $trainType;

    /**
     * @description 出行人useId
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
        'arrDate'            => 'arrDate',
        'arrStation'         => 'arrStation',
        'arrTime'            => 'arrTime',
        'billRecordTime'     => 'billRecordTime',
        'bookTime'           => 'bookTime',
        'bookerId'           => 'bookerId',
        'bookerJobNo'        => 'bookerJobNo',
        'bookerName'         => 'bookerName',
        'capitalDirection'   => 'capitalDirection',
        'cascadeDepartment'  => 'cascadeDepartment',
        'changeFee'          => 'changeFee',
        'costCenter'         => 'costCenter',
        'costCenterNumber'   => 'costCenterNumber',
        'coupon'             => 'coupon',
        'department'         => 'department',
        'departmentId'       => 'departmentId',
        'deptDate'           => 'deptDate',
        'deptStation'        => 'deptStation',
        'deptTime'           => 'deptTime',
        'feeType'            => 'feeType',
        'index'              => 'index',
        'invoiceTitle'       => 'invoiceTitle',
        'orderId'            => 'orderId',
        'orderPrice'         => 'orderPrice',
        'overApplyId'        => 'overApplyId',
        'primaryId'          => 'primaryId',
        'projectCode'        => 'projectCode',
        'projectName'        => 'projectName',
        'refundFee'          => 'refundFee',
        'remark'             => 'remark',
        'runTime'            => 'runTime',
        'seatNo'             => 'seatNo',
        'seatType'           => 'seatType',
        'serviceFee'         => 'serviceFee',
        'settlementFee'      => 'settlementFee',
        'settlementGrantFee' => 'settlementGrantFee',
        'settlementTime'     => 'settlementTime',
        'settlementType'     => 'settlementType',
        'status'             => 'status',
        'ticketNo'           => 'ticketNo',
        'ticketPrice'        => 'ticketPrice',
        'trainNo'            => 'trainNo',
        'trainType'          => 'trainType',
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
        if (null !== $this->capitalDirection) {
            $res['capitalDirection'] = $this->capitalDirection;
        }
        if (null !== $this->cascadeDepartment) {
            $res['cascadeDepartment'] = $this->cascadeDepartment;
        }
        if (null !== $this->changeFee) {
            $res['changeFee'] = $this->changeFee;
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
        if (null !== $this->department) {
            $res['department'] = $this->department;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
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
        if (null !== $this->feeType) {
            $res['feeType'] = $this->feeType;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->invoiceTitle) {
            $res['invoiceTitle'] = $this->invoiceTitle;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->orderPrice) {
            $res['orderPrice'] = $this->orderPrice;
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
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->runTime) {
            $res['runTime'] = $this->runTime;
        }
        if (null !== $this->seatNo) {
            $res['seatNo'] = $this->seatNo;
        }
        if (null !== $this->seatType) {
            $res['seatType'] = $this->seatType;
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
        if (null !== $this->ticketNo) {
            $res['ticketNo'] = $this->ticketNo;
        }
        if (null !== $this->ticketPrice) {
            $res['ticketPrice'] = $this->ticketPrice;
        }
        if (null !== $this->trainNo) {
            $res['trainNo'] = $this->trainNo;
        }
        if (null !== $this->trainType) {
            $res['trainType'] = $this->trainType;
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
        if (isset($map['capitalDirection'])) {
            $model->capitalDirection = $map['capitalDirection'];
        }
        if (isset($map['cascadeDepartment'])) {
            $model->cascadeDepartment = $map['cascadeDepartment'];
        }
        if (isset($map['changeFee'])) {
            $model->changeFee = $map['changeFee'];
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
        if (isset($map['department'])) {
            $model->department = $map['department'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
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
        if (isset($map['feeType'])) {
            $model->feeType = $map['feeType'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['invoiceTitle'])) {
            $model->invoiceTitle = $map['invoiceTitle'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['orderPrice'])) {
            $model->orderPrice = $map['orderPrice'];
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
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['runTime'])) {
            $model->runTime = $map['runTime'];
        }
        if (isset($map['seatNo'])) {
            $model->seatNo = $map['seatNo'];
        }
        if (isset($map['seatType'])) {
            $model->seatType = $map['seatType'];
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
        if (isset($map['ticketNo'])) {
            $model->ticketNo = $map['ticketNo'];
        }
        if (isset($map['ticketPrice'])) {
            $model->ticketPrice = $map['ticketPrice'];
        }
        if (isset($map['trainNo'])) {
            $model->trainNo = $map['trainNo'];
        }
        if (isset($map['trainType'])) {
            $model->trainType = $map['trainType'];
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
