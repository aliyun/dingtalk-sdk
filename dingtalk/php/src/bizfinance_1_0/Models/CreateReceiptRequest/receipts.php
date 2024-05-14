<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateReceiptRequest;

use AlibabaCloud\Tea\Model;

class receipts extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 4.44
     *
     * @var string
     */
    public $amount;

    /**
     * @description This parameter is required.
     *
     * @example INC_XXX
     *
     * @var string
     */
    public $categoryCode;

    /**
     * @description This parameter is required.
     *
     * @example abcd_efgh
     *
     * @var string
     */
    public $code;

    /**
     * @example 1636445218000
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @example emp_xxx
     *
     * @var string
     */
    public $createUserId;

    /**
     * @example CUS_XXX
     *
     * @var string
     */
    public $customerCode;

    /**
     * @example ACC_XXX
     *
     * @var string
     */
    public $enterpriseAcountCode;

    /**
     * @example 1636445218000
     *
     * @var int
     */
    public $occurDate;

    /**
     * @example emp_xxx
     *
     * @var string
     */
    public $principalId;

    /**
     * @example PROJ_XXX
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $receiptType;

    /**
     * @example 测试
     *
     * @var string
     */
    public $remark;

    /**
     * @example SUP_XXX
     *
     * @var string
     */
    public $supplierCode;

    /**
     * @example 收款单
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'amount'               => 'amount',
        'categoryCode'         => 'categoryCode',
        'code'                 => 'code',
        'createTime'           => 'createTime',
        'createUserId'         => 'createUserId',
        'customerCode'         => 'customerCode',
        'enterpriseAcountCode' => 'enterpriseAcountCode',
        'occurDate'            => 'occurDate',
        'principalId'          => 'principalId',
        'projectCode'          => 'projectCode',
        'receiptType'          => 'receiptType',
        'remark'               => 'remark',
        'supplierCode'         => 'supplierCode',
        'title'                => 'title',
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
        if (null !== $this->categoryCode) {
            $res['categoryCode'] = $this->categoryCode;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->createUserId) {
            $res['createUserId'] = $this->createUserId;
        }
        if (null !== $this->customerCode) {
            $res['customerCode'] = $this->customerCode;
        }
        if (null !== $this->enterpriseAcountCode) {
            $res['enterpriseAcountCode'] = $this->enterpriseAcountCode;
        }
        if (null !== $this->occurDate) {
            $res['occurDate'] = $this->occurDate;
        }
        if (null !== $this->principalId) {
            $res['principalId'] = $this->principalId;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->receiptType) {
            $res['receiptType'] = $this->receiptType;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->supplierCode) {
            $res['supplierCode'] = $this->supplierCode;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return receipts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['categoryCode'])) {
            $model->categoryCode = $map['categoryCode'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['createUserId'])) {
            $model->createUserId = $map['createUserId'];
        }
        if (isset($map['customerCode'])) {
            $model->customerCode = $map['customerCode'];
        }
        if (isset($map['enterpriseAcountCode'])) {
            $model->enterpriseAcountCode = $map['enterpriseAcountCode'];
        }
        if (isset($map['occurDate'])) {
            $model->occurDate = $map['occurDate'];
        }
        if (isset($map['principalId'])) {
            $model->principalId = $map['principalId'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['receiptType'])) {
            $model->receiptType = $map['receiptType'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['supplierCode'])) {
            $model->supplierCode = $map['supplierCode'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
