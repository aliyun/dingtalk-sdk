<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementCarResponseBody\module;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @description 支付交易流水号
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
     * @description 到达地
     *
     * @var string
     */
    public $arrLocation;

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
     * @description 用车事由
     *
     * @var string
     */
    public $businessCategory;

    /**
     * @description 资金方向
     *
     * @var string
     */
    public $capitalDirection;

    /**
     * @description 车型
     *
     * @var string
     */
    public $carLevel;

    /**
     * @description 级联部门
     *
     * @var string
     */
    public $cascadeDepartment;

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
     * @description 优惠金额
     *
     * @var float
     */
    public $couponPrice;

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
     * @description 出发城市
     *
     * @var string
     */
    public $deptCity;

    /**
     * @description 出发日期
     *
     * @var string
     */
    public $deptDate;

    /**
     * @description 出发地
     *
     * @var string
     */
    public $deptLocation;

    /**
     * @description 出发时间
     *
     * @var string
     */
    public $deptTime;

    /**
     * @description 预估行驶距离
     *
     * @var string
     */
    public $estimateDriveDistance;

    /**
     * @description 预估金额
     *
     * @var float
     */
    public $estimatePrice;

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
     * @description 用车事由
     *
     * @var string
     */
    public $memo;

    /**
     * @description 订单id
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
     * @description 个人支付金额
     *
     * @var float
     */
    public $personSettleFee;

    /**
     * @var string
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
     * @description 供应商
     *
     * @var string
     */
    public $providerName;

    /**
     * @description 实际行驶距离
     *
     * @var string
     */
    public $realDriveDistance;

    /**
     * @description 实际上车点
     *
     * @var string
     */
    public $realFromAddr;

    /**
     * @description 实际下车点
     *
     * @var string
     */
    public $realToAddr;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 服务费，仅在feeType 40111 中展示
     *
     * @var string
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
     * @description 特别关注订单
     *
     * @var string
     */
    public $specialOrder;

    /**
     * @description 特别关注原因
     *
     * @var string
     */
    public $specialReason;

    /**
     * @description 入账状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 子订单号
     *
     * @var string
     */
    public $subOrderId;

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
     * @description 员工是否认可
     *
     * @var string
     */
    public $userConfirmDesc;

    /**
     * @description 发票类型
     *
     * @var int
     */
    public $voucherType;
    protected $_name = [
        'alipayTradeNo'         => 'alipayTradeNo',
        'applyId'               => 'applyId',
        'arrCity'               => 'arrCity',
        'arrDate'               => 'arrDate',
        'arrLocation'           => 'arrLocation',
        'arrTime'               => 'arrTime',
        'billRecordTime'        => 'billRecordTime',
        'bookTime'              => 'bookTime',
        'bookerId'              => 'bookerId',
        'bookerJobNo'           => 'bookerJobNo',
        'bookerName'            => 'bookerName',
        'businessCategory'      => 'businessCategory',
        'capitalDirection'      => 'capitalDirection',
        'carLevel'              => 'carLevel',
        'cascadeDepartment'     => 'cascadeDepartment',
        'costCenter'            => 'costCenter',
        'costCenterNumber'      => 'costCenterNumber',
        'coupon'                => 'coupon',
        'couponPrice'           => 'couponPrice',
        'department'            => 'department',
        'departmentId'          => 'departmentId',
        'deptCity'              => 'deptCity',
        'deptDate'              => 'deptDate',
        'deptLocation'          => 'deptLocation',
        'deptTime'              => 'deptTime',
        'estimateDriveDistance' => 'estimateDriveDistance',
        'estimatePrice'         => 'estimatePrice',
        'feeType'               => 'feeType',
        'index'                 => 'index',
        'invoiceTitle'          => 'invoiceTitle',
        'memo'                  => 'memo',
        'orderId'               => 'orderId',
        'orderPrice'            => 'orderPrice',
        'overApplyId'           => 'overApplyId',
        'personSettleFee'       => 'personSettleFee',
        'primaryId'             => 'primaryId',
        'projectCode'           => 'projectCode',
        'projectName'           => 'projectName',
        'providerName'          => 'providerName',
        'realDriveDistance'     => 'realDriveDistance',
        'realFromAddr'          => 'realFromAddr',
        'realToAddr'            => 'realToAddr',
        'remark'                => 'remark',
        'serviceFee'            => 'serviceFee',
        'settlementFee'         => 'settlementFee',
        'settlementGrantFee'    => 'settlementGrantFee',
        'settlementTime'        => 'settlementTime',
        'settlementType'        => 'settlementType',
        'specialOrder'          => 'specialOrder',
        'specialReason'         => 'specialReason',
        'status'                => 'status',
        'subOrderId'            => 'subOrderId',
        'travelerId'            => 'travelerId',
        'travelerJobNo'         => 'travelerJobNo',
        'travelerName'          => 'travelerName',
        'userConfirmDesc'       => 'userConfirmDesc',
        'voucherType'           => 'voucherType',
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
        if (null !== $this->arrCity) {
            $res['arrCity'] = $this->arrCity;
        }
        if (null !== $this->arrDate) {
            $res['arrDate'] = $this->arrDate;
        }
        if (null !== $this->arrLocation) {
            $res['arrLocation'] = $this->arrLocation;
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
        if (null !== $this->businessCategory) {
            $res['businessCategory'] = $this->businessCategory;
        }
        if (null !== $this->capitalDirection) {
            $res['capitalDirection'] = $this->capitalDirection;
        }
        if (null !== $this->carLevel) {
            $res['carLevel'] = $this->carLevel;
        }
        if (null !== $this->cascadeDepartment) {
            $res['cascadeDepartment'] = $this->cascadeDepartment;
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
        if (null !== $this->couponPrice) {
            $res['couponPrice'] = $this->couponPrice;
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
        if (null !== $this->deptLocation) {
            $res['deptLocation'] = $this->deptLocation;
        }
        if (null !== $this->deptTime) {
            $res['deptTime'] = $this->deptTime;
        }
        if (null !== $this->estimateDriveDistance) {
            $res['estimateDriveDistance'] = $this->estimateDriveDistance;
        }
        if (null !== $this->estimatePrice) {
            $res['estimatePrice'] = $this->estimatePrice;
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
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
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
        if (null !== $this->personSettleFee) {
            $res['personSettleFee'] = $this->personSettleFee;
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
        if (null !== $this->providerName) {
            $res['providerName'] = $this->providerName;
        }
        if (null !== $this->realDriveDistance) {
            $res['realDriveDistance'] = $this->realDriveDistance;
        }
        if (null !== $this->realFromAddr) {
            $res['realFromAddr'] = $this->realFromAddr;
        }
        if (null !== $this->realToAddr) {
            $res['realToAddr'] = $this->realToAddr;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
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
        if (null !== $this->specialOrder) {
            $res['specialOrder'] = $this->specialOrder;
        }
        if (null !== $this->specialReason) {
            $res['specialReason'] = $this->specialReason;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->subOrderId) {
            $res['subOrderId'] = $this->subOrderId;
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
        if (null !== $this->userConfirmDesc) {
            $res['userConfirmDesc'] = $this->userConfirmDesc;
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
        if (isset($map['arrCity'])) {
            $model->arrCity = $map['arrCity'];
        }
        if (isset($map['arrDate'])) {
            $model->arrDate = $map['arrDate'];
        }
        if (isset($map['arrLocation'])) {
            $model->arrLocation = $map['arrLocation'];
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
        if (isset($map['businessCategory'])) {
            $model->businessCategory = $map['businessCategory'];
        }
        if (isset($map['capitalDirection'])) {
            $model->capitalDirection = $map['capitalDirection'];
        }
        if (isset($map['carLevel'])) {
            $model->carLevel = $map['carLevel'];
        }
        if (isset($map['cascadeDepartment'])) {
            $model->cascadeDepartment = $map['cascadeDepartment'];
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
        if (isset($map['couponPrice'])) {
            $model->couponPrice = $map['couponPrice'];
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
        if (isset($map['deptLocation'])) {
            $model->deptLocation = $map['deptLocation'];
        }
        if (isset($map['deptTime'])) {
            $model->deptTime = $map['deptTime'];
        }
        if (isset($map['estimateDriveDistance'])) {
            $model->estimateDriveDistance = $map['estimateDriveDistance'];
        }
        if (isset($map['estimatePrice'])) {
            $model->estimatePrice = $map['estimatePrice'];
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
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
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
        if (isset($map['personSettleFee'])) {
            $model->personSettleFee = $map['personSettleFee'];
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
        if (isset($map['providerName'])) {
            $model->providerName = $map['providerName'];
        }
        if (isset($map['realDriveDistance'])) {
            $model->realDriveDistance = $map['realDriveDistance'];
        }
        if (isset($map['realFromAddr'])) {
            $model->realFromAddr = $map['realFromAddr'];
        }
        if (isset($map['realToAddr'])) {
            $model->realToAddr = $map['realToAddr'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
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
        if (isset($map['specialOrder'])) {
            $model->specialOrder = $map['specialOrder'];
        }
        if (isset($map['specialReason'])) {
            $model->specialReason = $map['specialReason'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['subOrderId'])) {
            $model->subOrderId = $map['subOrderId'];
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
        if (isset($map['userConfirmDesc'])) {
            $model->userConfirmDesc = $map['userConfirmDesc'];
        }
        if (isset($map['voucherType'])) {
            $model->voucherType = $map['voucherType'];
        }

        return $model;
    }
}
