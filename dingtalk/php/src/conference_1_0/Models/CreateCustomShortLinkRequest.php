<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCustomShortLinkRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example COOLAPP-0-1026633886192127xxxB000W
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description This parameter is required.
     *
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @example bizData
     *
     * @var string
     */
    public $extensionAppBizData;

    /**
     * @description This parameter is required.
     *
     * @example f6fb627e-a7e8-403e-b1f8-26e85450f4a9
     *
     * @var string
     */
    public $scheduleConferenceId;

    /**
     * @example true：使用 false：不使用
     *
     * @var bool
     */
    public $useExtensionApp;
    protected $_name = [
        'coolAppCode' => 'coolAppCode',
        'creatorUnionId' => 'creatorUnionId',
        'extensionAppBizData' => 'extensionAppBizData',
        'scheduleConferenceId' => 'scheduleConferenceId',
        'useExtensionApp' => 'useExtensionApp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->extensionAppBizData) {
            $res['extensionAppBizData'] = $this->extensionAppBizData;
        }
        if (null !== $this->scheduleConferenceId) {
            $res['scheduleConferenceId'] = $this->scheduleConferenceId;
        }
        if (null !== $this->useExtensionApp) {
            $res['useExtensionApp'] = $this->useExtensionApp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCustomShortLinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['extensionAppBizData'])) {
            $model->extensionAppBizData = $map['extensionAppBizData'];
        }
        if (isset($map['scheduleConferenceId'])) {
            $model->scheduleConferenceId = $map['scheduleConferenceId'];
        }
        if (isset($map['useExtensionApp'])) {
            $model->useExtensionApp = $map['useExtensionApp'];
        }

        return $model;
    }
}
