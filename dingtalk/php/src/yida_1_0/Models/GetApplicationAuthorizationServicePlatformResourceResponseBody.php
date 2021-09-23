<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetApplicationAuthorizationServicePlatformResourceResponseBody extends Model
{
    /**
     * @description appTotalAmount
     *
     * @var int
     */
    public $appTotalAmount;

    /**
     * @description instanceId
     *
     * @var string
     */
    public $instanceId;

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
     * @description accountUsageAmount
     *
     * @var int
     */
    public $accountUsageAmount;

    /**
     * @description accountTotalAmount
     *
     * @var int
     */
    public $accountTotalAmount;

    /**
     * @description pluginUsageAmount
     *
     * @var int
     */
    public $pluginUsageAmount;

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
    protected $_name = [
        'appTotalAmount'        => 'appTotalAmount',
        'instanceId'            => 'instanceId',
        'instanceTotalAmount'   => 'instanceTotalAmount',
        'instanceUsageAmount'   => 'instanceUsageAmount',
        'accountUsageAmount'    => 'accountUsageAmount',
        'accountTotalAmount'    => 'accountTotalAmount',
        'pluginUsageAmount'     => 'pluginUsageAmount',
        'attachmentTotalAmount' => 'attachmentTotalAmount',
        'attachmentUsageAmount' => 'attachmentUsageAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appTotalAmount) {
            $res['appTotalAmount'] = $this->appTotalAmount;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->instanceTotalAmount) {
            $res['instanceTotalAmount'] = $this->instanceTotalAmount;
        }
        if (null !== $this->instanceUsageAmount) {
            $res['instanceUsageAmount'] = $this->instanceUsageAmount;
        }
        if (null !== $this->accountUsageAmount) {
            $res['accountUsageAmount'] = $this->accountUsageAmount;
        }
        if (null !== $this->accountTotalAmount) {
            $res['accountTotalAmount'] = $this->accountTotalAmount;
        }
        if (null !== $this->pluginUsageAmount) {
            $res['pluginUsageAmount'] = $this->pluginUsageAmount;
        }
        if (null !== $this->attachmentTotalAmount) {
            $res['attachmentTotalAmount'] = $this->attachmentTotalAmount;
        }
        if (null !== $this->attachmentUsageAmount) {
            $res['attachmentUsageAmount'] = $this->attachmentUsageAmount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetApplicationAuthorizationServicePlatformResourceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appTotalAmount'])) {
            $model->appTotalAmount = $map['appTotalAmount'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['instanceTotalAmount'])) {
            $model->instanceTotalAmount = $map['instanceTotalAmount'];
        }
        if (isset($map['instanceUsageAmount'])) {
            $model->instanceUsageAmount = $map['instanceUsageAmount'];
        }
        if (isset($map['accountUsageAmount'])) {
            $model->accountUsageAmount = $map['accountUsageAmount'];
        }
        if (isset($map['accountTotalAmount'])) {
            $model->accountTotalAmount = $map['accountTotalAmount'];
        }
        if (isset($map['pluginUsageAmount'])) {
            $model->pluginUsageAmount = $map['pluginUsageAmount'];
        }
        if (isset($map['attachmentTotalAmount'])) {
            $model->attachmentTotalAmount = $map['attachmentTotalAmount'];
        }
        if (isset($map['attachmentUsageAmount'])) {
            $model->attachmentUsageAmount = $map['attachmentUsageAmount'];
        }

        return $model;
    }
}
