<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetMultiCompanyInfoByCodeResponseBody;

use AlibabaCloud\Tea\Model;

class advancedSettingList extends Model
{
    /**
     * @example relateedInvoice
     *
     * @var string
     */
    public $advancedSettingKey;

    /**
     * @example 关联发票
     *
     * @var string
     */
    public $advancedSettingName;

    /**
     * @example 123456789
     *
     * @var int
     */
    public $endDate;

    /**
     * @var bool
     */
    public $value;
    protected $_name = [
        'advancedSettingKey' => 'advancedSettingKey',
        'advancedSettingName' => 'advancedSettingName',
        'endDate' => 'endDate',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->advancedSettingKey) {
            $res['advancedSettingKey'] = $this->advancedSettingKey;
        }
        if (null !== $this->advancedSettingName) {
            $res['advancedSettingName'] = $this->advancedSettingName;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return advancedSettingList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['advancedSettingKey'])) {
            $model->advancedSettingKey = $map['advancedSettingKey'];
        }
        if (isset($map['advancedSettingName'])) {
            $model->advancedSettingName = $map['advancedSettingName'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
