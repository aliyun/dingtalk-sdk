<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\QueryPayAccountListResponseBody;

use AlibabaCloud\Tea\Model;

class payAccountVOList extends Model
{
    /**
     * @example B
     *
     * @var string
     */
    public $accountClass;

    /**
     * @example 20210912001
     *
     * @var string
     */
    public $accountId;

    /**
     * @example test
     *
     * @var string
     */
    public $accountName;

    /**
     * @example 139****1
     *
     * @var string
     */
    public $accountNo;

    /**
     * @example 备注
     *
     * @var string
     */
    public $accountRemark;

    /**
     * @example ALIPAY
     *
     * @var string
     */
    public $accountType;
    protected $_name = [
        'accountClass'  => 'accountClass',
        'accountId'     => 'accountId',
        'accountName'   => 'accountName',
        'accountNo'     => 'accountNo',
        'accountRemark' => 'accountRemark',
        'accountType'   => 'accountType',
    ];

    public function validate()
    {
    }

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

        return $model;
    }
}
