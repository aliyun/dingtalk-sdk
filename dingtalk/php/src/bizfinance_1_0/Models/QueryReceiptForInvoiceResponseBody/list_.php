<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceResponseBody\list_\creator;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptForInvoiceResponseBody\list_\customer;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 开票状态
     *
     * @var string
     */
    public $applyStatus;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建人
     *
     * @var creator
     */
    public $creator;

    /**
     * @description 客户
     *
     * @var customer
     */
    public $customer;

    /**
     * @description 发票种类
     *
     * @var string
     */
    public $invoiceType;

    /**
     * @description 主数据modelId
     *
     * @var string
     */
    public $modelId;

    /**
     * @description 购方账户
     *
     * @var string
     */
    public $purchaserAccount;

    /**
     * @description 购方地址
     *
     * @var string
     */
    public $purchaserAddress;

    /**
     * @description 购方银行
     *
     * @var string
     */
    public $purchaserBankName;

    /**
     * @description 购方抬头
     *
     * @var string
     */
    public $purchaserName;

    /**
     * @description 购方税号
     *
     * @var string
     */
    public $purchaserTaxNo;

    /**
     * @description 购方电话
     *
     * @var string
     */
    public $purchaserTel;

    /**
     * @description 单据ID
     *
     * @var string
     */
    public $receiptId;

    /**
     * @description 记录时间，默认为审批通过时间
     *
     * @var string
     */
    public $recordTime;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 状态 agree running
     *
     * @var string
     */
    public $status;

    /**
     * @description 单据标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'amount'            => 'amount',
        'applyStatus'       => 'applyStatus',
        'createTime'        => 'createTime',
        'creator'           => 'creator',
        'customer'          => 'customer',
        'invoiceType'       => 'invoiceType',
        'modelId'           => 'modelId',
        'purchaserAccount'  => 'purchaserAccount',
        'purchaserAddress'  => 'purchaserAddress',
        'purchaserBankName' => 'purchaserBankName',
        'purchaserName'     => 'purchaserName',
        'purchaserTaxNo'    => 'purchaserTaxNo',
        'purchaserTel'      => 'purchaserTel',
        'receiptId'         => 'receiptId',
        'recordTime'        => 'recordTime',
        'remark'            => 'remark',
        'source'            => 'source',
        'status'            => 'status',
        'title'             => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->applyStatus) {
            $res['applyStatus'] = $this->applyStatus;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->customer) {
            $res['customer'] = null !== $this->customer ? $this->customer->toMap() : null;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->purchaserAccount) {
            $res['purchaserAccount'] = $this->purchaserAccount;
        }
        if (null !== $this->purchaserAddress) {
            $res['purchaserAddress'] = $this->purchaserAddress;
        }
        if (null !== $this->purchaserBankName) {
            $res['purchaserBankName'] = $this->purchaserBankName;
        }
        if (null !== $this->purchaserName) {
            $res['purchaserName'] = $this->purchaserName;
        }
        if (null !== $this->purchaserTaxNo) {
            $res['purchaserTaxNo'] = $this->purchaserTaxNo;
        }
        if (null !== $this->purchaserTel) {
            $res['purchaserTel'] = $this->purchaserTel;
        }
        if (null !== $this->receiptId) {
            $res['receiptId'] = $this->receiptId;
        }
        if (null !== $this->recordTime) {
            $res['recordTime'] = $this->recordTime;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['applyStatus'])) {
            $model->applyStatus = $map['applyStatus'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['customer'])) {
            $model->customer = customer::fromMap($map['customer']);
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['purchaserAccount'])) {
            $model->purchaserAccount = $map['purchaserAccount'];
        }
        if (isset($map['purchaserAddress'])) {
            $model->purchaserAddress = $map['purchaserAddress'];
        }
        if (isset($map['purchaserBankName'])) {
            $model->purchaserBankName = $map['purchaserBankName'];
        }
        if (isset($map['purchaserName'])) {
            $model->purchaserName = $map['purchaserName'];
        }
        if (isset($map['purchaserTaxNo'])) {
            $model->purchaserTaxNo = $map['purchaserTaxNo'];
        }
        if (isset($map['purchaserTel'])) {
            $model->purchaserTel = $map['purchaserTel'];
        }
        if (isset($map['receiptId'])) {
            $model->receiptId = $map['receiptId'];
        }
        if (isset($map['recordTime'])) {
            $model->recordTime = $map['recordTime'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
