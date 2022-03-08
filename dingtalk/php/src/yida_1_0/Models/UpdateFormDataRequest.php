<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFormDataRequest extends Model
{
    /**
     * @description 应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 要更新的表单数据ID
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 语言。可选值：zh_CN/en_US 默认：zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @description 应用秘钥。在应用数据中获取。
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 要更新的表单组件值。参数有的组件更新，没有的组件保持不变。 明细的值只能统一更新，无法只更新明细下某个组件的值
     *
     * @var string
     */
    public $updateFormDataJson;

    /**
     * @description 使用最新的表单版本进行更新。默认为false
     *
     * @var bool
     */
    public $useLatestVersion;

    /**
     * @description 钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'            => 'appType',
        'formInstanceId'     => 'formInstanceId',
        'language'           => 'language',
        'systemToken'        => 'systemToken',
        'updateFormDataJson' => 'updateFormDataJson',
        'useLatestVersion'   => 'useLatestVersion',
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
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->updateFormDataJson) {
            $res['updateFormDataJson'] = $this->updateFormDataJson;
        }
        if (null !== $this->useLatestVersion) {
            $res['useLatestVersion'] = $this->useLatestVersion;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFormDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['updateFormDataJson'])) {
            $model->updateFormDataJson = $map['updateFormDataJson'];
        }
        if (isset($map['useLatestVersion'])) {
            $model->useLatestVersion = $map['useLatestVersion'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
