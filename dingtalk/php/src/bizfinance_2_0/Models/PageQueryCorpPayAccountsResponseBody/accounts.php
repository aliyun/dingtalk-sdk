<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\PageQueryCorpPayAccountsResponseBody;

use AlibabaCloud\Tea\Model;

class accounts extends Model
{
    /**
     * @var string
     */
    public $accountClass;

    /**
     * @var string
     */
    public $accountId;

    /**
     * @var string
     */
    public $accountName;

    /**
     * @var string
     */
    public $accountNo;

    /**
     * @var string
     */
    public $accountRemark;

    /**
     * @var string
     */
    public $accountType;

    /**
     * @var int
     */
    public $creatorUid;

    /**
     * @var bool
     */
    public $hasSignReceipt;
    protected $_name = [
        'accountClass' => 'accountClass',
        'accountId' => 'accountId',
        'accountName' => 'accountName',
        'accountNo' => 'accountNo',
        'accountRemark' => 'accountRemark',
        'accountType' => 'accountType',
        'creatorUid' => 'creatorUid',
        'hasSignReceipt' => 'hasSignReceipt',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountClass) {
            $res['accountClass'] = $this->accountClass;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->accountNo) {
            $res['accountNo'] = $this->accountNo;
        }
        if (null !== $this->accountRemark) {
            $res['accountRemark'] = $this->accountRemark;
        }
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->creatorUid) {
            $res['creatorUid'] = $this->creatorUid;
        }
        if (null !== $this->hasSignReceipt) {
            $res['hasSignReceipt'] = $this->hasSignReceipt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return accounts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountClass'])) {
            $model->accountClass = $map['accountClass'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['accountNo'])) {
            $model->accountNo = $map['accountNo'];
        }
        if (isset($map['accountRemark'])) {
            $model->accountRemark = $map['accountRemark'];
        }
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['creatorUid'])) {
            $model->creatorUid = $map['creatorUid'];
        }
        if (isset($map['hasSignReceipt'])) {
            $model->hasSignReceipt = $map['hasSignReceipt'];
        }

        return $model;
    }
}
