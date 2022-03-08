<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\CreateReceiptRequest;

use AlibabaCloud\Tea\Model;

class receipts extends Model
{
    /**
     * @description 单据金额
     *
     * @var string
     */
    public $amount;

    /**
     * @description 关联收支类别code
     *
     * @var string
     */
    public $categoryCode;

    /**
     * @description 单据唯一编号
     *
     * @var string
     */
    public $code;

    /**
     * @description 单据创建时间，默认当前时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 创建人工号
     *
     * @var string
     */
    public $createUserId;

    /**
     * @description 关联客户code
     *
     * @var string
     */
    public $customerCode;

    /**
     * @description 关联企业账户code
     *
     * @var string
     */
    public $enterpriseAcountCode;

    /**
     * @description 业务发生时间，默认当前时间
     *
     * @var int
     */
    public $occurDate;

    /**
     * @description 负责人工号，传空代表不修改
     *
     * @var string
     */
    public $principalId;

    /**
     * @description 关联项目code
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description 单据类型：1付款单，2收款单
     *
     * @var int
     */
    public $receiptType;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 关联供应商code
     *
     * @var string
     */
    public $supplierCode;

    /**
     * @description 单据标题，不传由系统默认生成
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
