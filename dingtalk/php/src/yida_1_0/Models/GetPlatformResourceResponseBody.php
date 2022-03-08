<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPlatformResourceResponseBody extends Model
{
    /**
     * @description accountTotalAmount
     *
     * @var int
     */
    public $accountTotalAmount;

    /**
     * @description accountUsageAmount
     *
     * @var int
     */
    public $accountUsageAmount;

    /**
     * @description appTotalAmount
     *
     * @var int
     */
    public $appTotalAmount;

    /**
     * @description attachmentTotalAmount
     *
     * @var int
     */
    public $attachmentTotalAmount;

    /**
     * @description attachmentUsageAmount
     *
     * @var int
     */
    public $attachmentUsageAmount;

    /**
     * @description instanceTotalAmount
     *
     * @var int
     */
    public $instanceTotalAmount;

    /**
     * @description instanceUsageAmount
     *
     * @var int
     */
    public $instanceUsageAmount;

    /**
     * @description pluginUsageAmount
     *
     * @var int
     */
    public $pluginUsageAmount;
    protected $_name = [
        'accountTotalAmount'    => 'accountTotalAmount',
        'accountUsageAmount'    => 'accountUsageAmount',
        'appTotalAmount'        => 'appTotalAmount',
        'attachmentTotalAmount' => 'attachmentTotalAmount',
        'attachmentUsageAmount' => 'attachmentUsageAmount',
        'instanceTotalAmount'   => 'instanceTotalAmount',
        'instanceUsageAmount'   => 'instanceUsageAmount',
        'pluginUsageAmount'     => 'pluginUsageAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountTotalAmount) {
            $res['accountTotalAmount'] = $this->accountTotalAmount;
        }
        if (null !== $this->accountUsageAmount) {
            $res['accountUsageAmount'] = $this->accountUsageAmount;
        }
        if (null !== $this->appTotalAmount) {
            $res['appTotalAmount'] = $this->appTotalAmount;
        }
        if (null !== $this->attachmentTotalAmount) {
            $res['attachmentTotalAmount'] = $this->attachmentTotalAmount;
        }
        if (null !== $this->attachmentUsageAmount) {
            $res['attachmentUsageAmount'] = $this->attachmentUsageAmount;
        }
        if (null !== $this->instanceTotalAmount) {
            $res['instanceTotalAmount'] = $this->instanceTotalAmount;
        }
        if (null !== $this->instanceUsageAmount) {
            $res['instanceUsageAmount'] = $this->instanceUsageAmount;
        }
        if (null !== $this->pluginUsageAmount) {
            $res['pluginUsageAmount'] = $this->pluginUsageAmount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPlatformResourceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountTotalAmount'])) {
            $model->accountTotalAmount = $map['accountTotalAmount'];
        }
        if (isset($map['accountUsageAmount'])) {
            $model->accountUsageAmount = $map['accountUsageAmount'];
        }
        if (isset($map['appTotalAmount'])) {
            $model->appTotalAmount = $map['appTotalAmount'];
        }
        if (isset($map['attachmentTotalAmount'])) {
            $model->attachmentTotalAmount = $map['attachmentTotalAmount'];
        }
        if (isset($map['attachmentUsageAmount'])) {
            $model->attachmentUsageAmount = $map['attachmentUsageAmount'];
        }
        if (isset($map['instanceTotalAmount'])) {
            $model->instanceTotalAmount = $map['instanceTotalAmount'];
        }
        if (isset($map['instanceUsageAmount'])) {
            $model->instanceUsageAmount = $map['instanceUsageAmount'];
        }
        if (isset($map['pluginUsageAmount'])) {
            $model->pluginUsageAmount = $map['pluginUsageAmount'];
        }

        return $model;
    }
}
