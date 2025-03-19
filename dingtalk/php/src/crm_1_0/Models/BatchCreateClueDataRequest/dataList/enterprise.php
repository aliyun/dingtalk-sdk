<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchCreateClueDataRequest\dataList;

use AlibabaCloud\Tea\Model;

class enterprise extends Model
{
    /**
     * @var string
     */
    public $address;

    /**
     * @var string
     */
    public $industryCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $region;

    /**
     * @var string
     */
    public $unifiedSocialCreditCode;
    protected $_name = [
        'address' => 'address',
        'industryCode' => 'industryCode',
        'name' => 'name',
        'region' => 'region',
        'unifiedSocialCreditCode' => 'unifiedSocialCreditCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->region) {
            $res['region'] = $this->region;
        }
        if (null !== $this->unifiedSocialCreditCode) {
            $res['unifiedSocialCreditCode'] = $this->unifiedSocialCreditCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return enterprise
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['region'])) {
            $model->region = $map['region'];
        }
        if (isset($map['unifiedSocialCreditCode'])) {
            $model->unifiedSocialCreditCode = $map['unifiedSocialCreditCode'];
        }

        return $model;
    }
}
