<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateInstanceRequest extends Model
{
    /**
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example 未知
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example hello1234
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example 未知
     *
     * @var string
     */
    public $updateFormDataJson;

    /**
     * @example 未知
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'            => 'appType',
        'language'           => 'language',
        'processInstanceId'  => 'processInstanceId',
        'systemToken'        => 'systemToken',
        'updateFormDataJson' => 'updateFormDataJson',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->updateFormDataJson) {
            $res['updateFormDataJson'] = $this->updateFormDataJson;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['updateFormDataJson'])) {
            $model->updateFormDataJson = $map['updateFormDataJson'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
