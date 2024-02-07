<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody\result\creator;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody\result\customer;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryReceiptDetailForInvoiceResponseBody\result\productInfoList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $accountantBookId;

    /**
     * @example 4000
     *
     * @var string
     */
    public $amount;

    /**
     * @example applied
     *
     * @var string
     */
    public $applyStatus;

    /**
     * @example invoicing
     *
     * @var string
     */
    public $bizStatus;

    /**
     * @example 123
     *
     * @var string
     */
    public $businessId;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example 123000
     *
     * @var string
     */
    public $createTime;

    /**
     * @var creator
     */
    public $creator;

    /**
     * @var customer
     */
    public $customer;

    /**
     * @example www.abc.com
     *
     * @var string
     */
    public $drawerEmail;

    /**
     * @example 12345678901
     *
     * @var string
     */
    public $drawerTelephone;

    /**
     * @example VAT_NORMAL_E
     *
     * @var string
     */
    public $invoiceType;

    /**
     * @example EM-xxxxx
     *
     * @var string
     */
    public $modelId;

    /**
     * @var productInfoList[]
     */
    public $productInfoList;

    /**
     * @example 32131131231
     *
     * @var string
     */
    public $purchaserAccount;

    /**
     * @example 杭州市
     *
     * @var string
     */
    public $purchaserAddress;

    /**
     * @example 工商银行XX支行
     *
     * @var string
     */
    public $purchaserBankName;

    /**
     * @example 钉有限公司
     *
     * @var string
     */
    public $purchaserName;

    /**
     * @example 123456
     *
     * @var string
     */
    public $purchaserTaxNo;

    /**
     * @example 12345678901
     *
     * @var string
     */
    public $purchaserTel;

    /**
     * @example abc
     *
     * @var string
     */
    public $receiptId;

    /**
     * @example 16000000
     *
     * @var string
     */
    public $recordTime;

    /**
     * @example 备注信息
     *
     * @var string
     */
    public $remark;

    /**
     * @example approval
     *
     * @var string
     */
    public $source;

    /**
     * @example agree
     *
     * @var string
     */
    public $status;

    /**
     * @example 张三提交的开票申请单
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'accountantBookId'  => 'accountantBookId',
        'amount'            => 'amount',
        'applyStatus'       => 'applyStatus',
        'bizStatus'         => 'bizStatus',
        'businessId'        => 'businessId',
        'companyCode'       => 'companyCode',
        'createTime'        => 'createTime',
        'creator'           => 'creator',
        'customer'          => 'customer',
        'drawerEmail'       => 'drawerEmail',
        'drawerTelephone'   => 'drawerTelephone',
        'invoiceType'       => 'invoiceType',
        'modelId'           => 'modelId',
        'productInfoList'   => 'productInfoList',
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
        if (null !== $this->accountantBookId) {
            $res['accountantBookId'] = $this->accountantBookId;
        }
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->applyStatus) {
            $res['applyStatus'] = $this->applyStatus;
        }
        if (null !== $this->bizStatus) {
            $res['bizStatus'] = $this->bizStatus;
        }
        if (null !== $this->businessId) {
            $res['businessId'] = $this->businessId;
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
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
        if (null !== $this->drawerEmail) {
            $res['drawerEmail'] = $this->drawerEmail;
        }
        if (null !== $this->drawerTelephone) {
            $res['drawerTelephone'] = $this->drawerTelephone;
        }
        if (null !== $this->invoiceType) {
            $res['invoiceType'] = $this->invoiceType;
        }
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->productInfoList) {
            $res['productInfoList'] = [];
            if (null !== $this->productInfoList && \is_array($this->productInfoList)) {
                $n = 0;
                foreach ($this->productInfoList as $item) {
                    $res['productInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountantBookId'])) {
            $model->accountantBookId = $map['accountantBookId'];
        }
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['applyStatus'])) {
            $model->applyStatus = $map['applyStatus'];
        }
        if (isset($map['bizStatus'])) {
            $model->bizStatus = $map['bizStatus'];
        }
        if (isset($map['businessId'])) {
            $model->businessId = $map['businessId'];
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
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
        if (isset($map['drawerEmail'])) {
            $model->drawerEmail = $map['drawerEmail'];
        }
        if (isset($map['drawerTelephone'])) {
            $model->drawerTelephone = $map['drawerTelephone'];
        }
        if (isset($map['invoiceType'])) {
            $model->invoiceType = $map['invoiceType'];
        }
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['productInfoList'])) {
            if (!empty($map['productInfoList'])) {
                $model->productInfoList = [];
                $n                      = 0;
                foreach ($map['productInfoList'] as $item) {
                    $model->productInfoList[$n++] = null !== $item ? productInfoList::fromMap($item) : $item;
                }
            }
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
