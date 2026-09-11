<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePayableReceiptRequest;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePayableReceiptRequest\receipt\dangAnDataInfoList;
use AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\CreatePayableReceiptRequest\receipt\receiptPlans;
use AlibabaCloud\Tea\Model;

class receipt extends Model
{
    /**
     * @var string
     */
    public $amount;

    /**
     * @var string
     */
    public $categoryCode;

    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $companyCode;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var string
     */
    public $customerCode;

    /**
     * @var dangAnDataInfoList[]
     */
    public $dangAnDataInfoList;

    /**
     * @var string
     */
    public $departmentCode;

    /**
     * @var string
     */
    public $empAccountUserId;

    /**
     * @var string
     */
    public $enterpriseAccountCode;

    /**
     * @var string
     */
    public $formCode;

    /**
     * @var int
     */
    public $occurDate;

    /**
     * @var string
     */
    public $principalId;

    /**
     * @var string
     */
    public $productCode;

    /**
     * @var string
     */
    public $projectCode;

    /**
     * @var receiptPlans[]
     */
    public $receiptPlans;

    /**
     * @var int
     */
    public $receiptType;

    /**
     * @var int
     */
    public $recodeTime;

    /**
     * @var string
     */
    public $remark;

    /**
     * @var string
     */
    public $supplierCode;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'amount' => 'amount',
        'categoryCode' => 'categoryCode',
        'code' => 'code',
        'companyCode' => 'companyCode',
        'corpId' => 'corpId',
        'createTime' => 'createTime',
        'customerCode' => 'customerCode',
        'dangAnDataInfoList' => 'dangAnDataInfoList',
        'departmentCode' => 'departmentCode',
        'empAccountUserId' => 'empAccountUserId',
        'enterpriseAccountCode' => 'enterpriseAccountCode',
        'formCode' => 'formCode',
        'occurDate' => 'occurDate',
        'principalId' => 'principalId',
        'productCode' => 'productCode',
        'projectCode' => 'projectCode',
        'receiptPlans' => 'receiptPlans',
        'receiptType' => 'receiptType',
        'recodeTime' => 'recodeTime',
        'remark' => 'remark',
        'supplierCode' => 'supplierCode',
        'title' => 'title',
        'userId' => 'userId',
    ];

    public function validate() {}

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
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->customerCode) {
            $res['customerCode'] = $this->customerCode;
        }
        if (null !== $this->dangAnDataInfoList) {
            $res['dangAnDataInfoList'] = [];
            if (null !== $this->dangAnDataInfoList && \is_array($this->dangAnDataInfoList)) {
                $n = 0;
                foreach ($this->dangAnDataInfoList as $item) {
                    $res['dangAnDataInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->departmentCode) {
            $res['departmentCode'] = $this->departmentCode;
        }
        if (null !== $this->empAccountUserId) {
            $res['empAccountUserId'] = $this->empAccountUserId;
        }
        if (null !== $this->enterpriseAccountCode) {
            $res['enterpriseAccountCode'] = $this->enterpriseAccountCode;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->occurDate) {
            $res['occurDate'] = $this->occurDate;
        }
        if (null !== $this->principalId) {
            $res['principalId'] = $this->principalId;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->receiptPlans) {
            $res['receiptPlans'] = [];
            if (null !== $this->receiptPlans && \is_array($this->receiptPlans)) {
                $n = 0;
                foreach ($this->receiptPlans as $item) {
                    $res['receiptPlans'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->receiptType) {
            $res['receiptType'] = $this->receiptType;
        }
        if (null !== $this->recodeTime) {
            $res['recodeTime'] = $this->recodeTime;
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return receipt
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
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['customerCode'])) {
            $model->customerCode = $map['customerCode'];
        }
        if (isset($map['dangAnDataInfoList'])) {
            if (!empty($map['dangAnDataInfoList'])) {
                $model->dangAnDataInfoList = [];
                $n = 0;
                foreach ($map['dangAnDataInfoList'] as $item) {
                    $model->dangAnDataInfoList[$n++] = null !== $item ? dangAnDataInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['departmentCode'])) {
            $model->departmentCode = $map['departmentCode'];
        }
        if (isset($map['empAccountUserId'])) {
            $model->empAccountUserId = $map['empAccountUserId'];
        }
        if (isset($map['enterpriseAccountCode'])) {
            $model->enterpriseAccountCode = $map['enterpriseAccountCode'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['occurDate'])) {
            $model->occurDate = $map['occurDate'];
        }
        if (isset($map['principalId'])) {
            $model->principalId = $map['principalId'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['receiptPlans'])) {
            if (!empty($map['receiptPlans'])) {
                $model->receiptPlans = [];
                $n = 0;
                foreach ($map['receiptPlans'] as $item) {
                    $model->receiptPlans[$n++] = null !== $item ? receiptPlans::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['receiptType'])) {
            $model->receiptType = $map['receiptType'];
        }
        if (isset($map['recodeTime'])) {
            $model->recodeTime = $map['recodeTime'];
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
