<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryPayAccountListResponseBody;

use AlibabaCloud\Tea\Model;

class payAccountVOList extends Model
{
    /**
     * @description 付款账号（脱敏）
     *
     * @var string
     */
    public $accountNo;

    /**
     * @description 账号名称
     *
     * @var string
     */
    public $accountName;

    /**
     * @description 账户类型
     *
     * @var string
     */
    public $accountType;

    /**
     * @description 账户备注
     *
     * @var string
     */
    public $accountRemark;

    /**
     * @description 账号唯一id
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 账户分类
     *
     * @var string
     */
    public $accountClass;
    protected $_name = [
        'accountNo'     => 'accountNo',
        'accountName'   => 'accountName',
        'accountType'   => 'accountType',
        'accountRemark' => 'accountRemark',
        'accountId'     => 'accountId',
        'accountClass'  => 'accountClass',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountNo) {
            $res['accountNo'] = $this->accountNo;
        }
        if (null !== $this->accountName) {
            $res['accountName'] = $this->accountName;
        }
        if (null !== $this->accountType) {
            $res['accountType'] = $this->accountType;
        }
        if (null !== $this->accountRemark) {
            $res['accountRemark'] = $this->accountRemark;
        }
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->accountClass) {
            $res['accountClass'] = $this->accountClass;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payAccountVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountNo'])) {
            $model->accountNo = $map['accountNo'];
        }
        if (isset($map['accountName'])) {
            $model->accountName = $map['accountName'];
        }
        if (isset($map['accountType'])) {
            $model->accountType = $map['accountType'];
        }
        if (isset($map['accountRemark'])) {
            $model->accountRemark = $map['accountRemark'];
        }
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['accountClass'])) {
            $model->accountClass = $map['accountClass'];
        }

        return $model;
    }
}
