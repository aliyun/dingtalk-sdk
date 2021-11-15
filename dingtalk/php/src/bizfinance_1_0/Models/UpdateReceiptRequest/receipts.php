<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\UpdateReceiptRequest;

use AlibabaCloud\Tea\Model;

class receipts extends Model
{
    /**
     * @description 修改者工号
     *
     * @var string
     */
    public $updateUserId;

    /**
     * @description 单据唯一编号
     *
     * @var string
     */
    public $code;

    /**
     * @description 单据标题，传空代表不修改
     *
     * @var string
     */
    public $title;

    /**
     * @description 单据更新时间
     *
     * @var int
     */
    public $updateTime;

    /**
     * @description 业务发生时间，传空代表不修改
     *
     * @var int
     */
    public $occurDate;

    /**
     * @description 总金额，传空代表不修改
     *
     * @var string
     */
    public $amount;

    /**
     * @description 单据类型：1付款单，2收款单
     *
     * @var int
     */
    public $receiptType;

    /**
     * @description 负责人工号，传空代表不修改
     *
     * @var string
     */
    public $principalId;

    /**
     * @description 关联收支类别，传空代表不修改
     *
     * @var string
     */
    public $categoryCode;

    /**
     * @description 关联项目code，传空代表不修改
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description 关联客户code，传空代表不修改
     *
     * @var string
     */
    public $customerCode;

    /**
     * @description 关联供应商code，传空代表不修改
     *
     * @var string
     */
    public $supplierCode;

    /**
     * @description 关联企业账户code，传空代表不修改
     *
     * @var string
     */
    public $enterpriseAcountCode;

    /**
     * @description 备注，传空代表不修改
     *
     * @var string
     */
    public $remark;
    protected $_name = [
        'updateUserId'         => 'updateUserId',
        'code'                 => 'code',
        'title'                => 'title',
        'updateTime'           => 'updateTime',
        'occurDate'            => 'occurDate',
        'amount'               => 'amount',
        'receiptType'          => 'receiptType',
        'principalId'          => 'principalId',
        'categoryCode'         => 'categoryCode',
        'projectCode'          => 'projectCode',
        'customerCode'         => 'customerCode',
        'supplierCode'         => 'supplierCode',
        'enterpriseAcountCode' => 'enterpriseAcountCode',
        'remark'               => 'remark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->updateUserId) {
            $res['updateUserId'] = $this->updateUserId;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }
        if (null !== $this->occurDate) {
            $res['occurDate'] = $this->occurDate;
        }
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->receiptType) {
            $res['receiptType'] = $this->receiptType;
        }
        if (null !== $this->principalId) {
            $res['principalId'] = $this->principalId;
        }
        if (null !== $this->categoryCode) {
            $res['categoryCode'] = $this->categoryCode;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->customerCode) {
            $res['customerCode'] = $this->customerCode;
        }
        if (null !== $this->supplierCode) {
            $res['supplierCode'] = $this->supplierCode;
        }
        if (null !== $this->enterpriseAcountCode) {
            $res['enterpriseAcountCode'] = $this->enterpriseAcountCode;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
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
        if (isset($map['updateUserId'])) {
            $model->updateUserId = $map['updateUserId'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }
        if (isset($map['occurDate'])) {
            $model->occurDate = $map['occurDate'];
        }
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['receiptType'])) {
            $model->receiptType = $map['receiptType'];
        }
        if (isset($map['principalId'])) {
            $model->principalId = $map['principalId'];
        }
        if (isset($map['categoryCode'])) {
            $model->categoryCode = $map['categoryCode'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['customerCode'])) {
            $model->customerCode = $map['customerCode'];
        }
        if (isset($map['supplierCode'])) {
            $model->supplierCode = $map['supplierCode'];
        }
        if (isset($map['enterpriseAcountCode'])) {
            $model->enterpriseAcountCode = $map['enterpriseAcountCode'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
