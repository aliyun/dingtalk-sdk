<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptRequest;

use AlibabaCloud\Tea\Model;

class receipts extends Model
{
    /**
     * @example 2.44
     *
     * @var string
     */
    public $amount;

    /**
     * @example INC_XXX
     *
     * @var string
     */
    public $categoryCode;

    /**
     * @example abcd_efgh
     *
     * @var string
     */
    public $code;

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
     * @example 1
     *
     * @var int
     */
    public $receiptType;

    /**
     * @example 测试单据
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
     * @example 付款单
     *
     * @var string
     */
    public $title;

    /**
     * @example 1636445218000
     *
     * @var int
     */
    public $updateTime;

    /**
     * @example emp_xxx
     *
     * @var string
     */
    public $updateUserId;
    protected $_name = [
        'amount'               => 'amount',
        'categoryCode'         => 'categoryCode',
        'code'                 => 'code',
        'customerCode'         => 'customerCode',
        'enterpriseAcountCode' => 'enterpriseAcountCode',
        'occurDate'            => 'occurDate',
        'principalId'          => 'principalId',
        'projectCode'          => 'projectCode',
        'receiptType'          => 'receiptType',
        'remark'               => 'remark',
        'supplierCode'         => 'supplierCode',
        'title'                => 'title',
        'updateTime'           => 'updateTime',
        'updateUserId'         => 'updateUserId',
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
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }
        if (null !== $this->updateUserId) {
            $res['updateUserId'] = $this->updateUserId;
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
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }
        if (isset($map['updateUserId'])) {
            $model->updateUserId = $map['updateUserId'];
        }

        return $model;
    }
}
