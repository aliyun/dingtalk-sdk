<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryMultiCompanyInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryMultiCompanyInfoResponseBody\list_\advancedSettingList;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $accountantBookId;

    /**
     * @var advancedSettingList[]
     */
    public $advancedSettingList;

    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example 钉钉
     *
     * @var string
     */
    public $companyName;

    /**
     * @example 123456789
     *
     * @var string
     */
    public $createTime;

    /**
     * @example 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @example valid
     *
     * @var string
     */
    public $status;

    /**
     * @example generalTaxpayer
     *
     * @var string
     */
    public $taxNature;

    /**
     * @example 123456789012345
     *
     * @var string
     */
    public $taxNo;
    protected $_name = [
        'accountantBookId' => 'accountantBookId',
        'advancedSettingList' => 'advancedSettingList',
        'companyCode' => 'companyCode',
        'companyName' => 'companyName',
        'createTime' => 'createTime',
        'remark' => 'remark',
        'status' => 'status',
        'taxNature' => 'taxNature',
        'taxNo' => 'taxNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountantBookId) {
            $res['accountantBookId'] = $this->accountantBookId;
        }
        if (null !== $this->advancedSettingList) {
            $res['advancedSettingList'] = [];
            if (null !== $this->advancedSettingList && \is_array($this->advancedSettingList)) {
                $n = 0;
                foreach ($this->advancedSettingList as $item) {
                    $res['advancedSettingList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->companyName) {
            $res['companyName'] = $this->companyName;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taxNature) {
            $res['taxNature'] = $this->taxNature;
        }
        if (null !== $this->taxNo) {
            $res['taxNo'] = $this->taxNo;
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
        if (isset($map['accountantBookId'])) {
            $model->accountantBookId = $map['accountantBookId'];
        }
        if (isset($map['advancedSettingList'])) {
            if (!empty($map['advancedSettingList'])) {
                $model->advancedSettingList = [];
                $n = 0;
                foreach ($map['advancedSettingList'] as $item) {
                    $model->advancedSettingList[$n++] = null !== $item ? advancedSettingList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['companyName'])) {
            $model->companyName = $map['companyName'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taxNature'])) {
            $model->taxNature = $map['taxNature'];
        }
        if (isset($map['taxNo'])) {
            $model->taxNo = $map['taxNo'];
        }

        return $model;
    }
}
