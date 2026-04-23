<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInnerAppInfoResponseBody extends Model
{
    /**
     * @var int
     */
    public $agentId;

    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $customerAppId;

    /**
     * @var bool
     */
    public $hideDingNavBar;

    /**
     * @var string
     */
    public $mobileLoginAddressKey;

    /**
     * @var string
     */
    public $mobileLoginLoginUrl;

    /**
     * @var string
     */
    public $mobileLoginRequestMethod;

    /**
     * @var string
     */
    public $mobileOriginalHomepageUrl;

    /**
     * @var string
     */
    public $mobileTransferUrl;

    /**
     * @var string
     */
    public $padEffectiveHomepageUrl;

    /**
     * @var string
     */
    public $padLoginAddressKey;

    /**
     * @var string
     */
    public $padLoginLoginUrl;

    /**
     * @var string
     */
    public $padLoginRequestMethod;

    /**
     * @var string
     */
    public $padOriginalHomepageUrl;

    /**
     * @var string
     */
    public $padTransferUrl;

    /**
     * @var string
     */
    public $pcEffectiveHomepageUrl;

    /**
     * @var string
     */
    public $pcLoginAddressKey;

    /**
     * @var string
     */
    public $pcLoginLoginUrl;

    /**
     * @var string
     */
    public $pcLoginRequestMethod;

    /**
     * @var string
     */
    public $pcOriginalHomepageUrl;

    /**
     * @var string
     */
    public $pcTransferUrl;

    /**
     * @var string[]
     */
    public $ssoH5PageType;
    protected $_name = [
        'agentId' => 'agentId',
        'appName' => 'appName',
        'customerAppId' => 'customerAppId',
        'hideDingNavBar' => 'hideDingNavBar',
        'mobileLoginAddressKey' => 'mobileLoginAddressKey',
        'mobileLoginLoginUrl' => 'mobileLoginLoginUrl',
        'mobileLoginRequestMethod' => 'mobileLoginRequestMethod',
        'mobileOriginalHomepageUrl' => 'mobileOriginalHomepageUrl',
        'mobileTransferUrl' => 'mobileTransferUrl',
        'padEffectiveHomepageUrl' => 'padEffectiveHomepageUrl',
        'padLoginAddressKey' => 'padLoginAddressKey',
        'padLoginLoginUrl' => 'padLoginLoginUrl',
        'padLoginRequestMethod' => 'padLoginRequestMethod',
        'padOriginalHomepageUrl' => 'padOriginalHomepageUrl',
        'padTransferUrl' => 'padTransferUrl',
        'pcEffectiveHomepageUrl' => 'pcEffectiveHomepageUrl',
        'pcLoginAddressKey' => 'pcLoginAddressKey',
        'pcLoginLoginUrl' => 'pcLoginLoginUrl',
        'pcLoginRequestMethod' => 'pcLoginRequestMethod',
        'pcOriginalHomepageUrl' => 'pcOriginalHomepageUrl',
        'pcTransferUrl' => 'pcTransferUrl',
        'ssoH5PageType' => 'ssoH5PageType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->customerAppId) {
            $res['customerAppId'] = $this->customerAppId;
        }
        if (null !== $this->hideDingNavBar) {
            $res['hideDingNavBar'] = $this->hideDingNavBar;
        }
        if (null !== $this->mobileLoginAddressKey) {
            $res['mobileLoginAddressKey'] = $this->mobileLoginAddressKey;
        }
        if (null !== $this->mobileLoginLoginUrl) {
            $res['mobileLoginLoginUrl'] = $this->mobileLoginLoginUrl;
        }
        if (null !== $this->mobileLoginRequestMethod) {
            $res['mobileLoginRequestMethod'] = $this->mobileLoginRequestMethod;
        }
        if (null !== $this->mobileOriginalHomepageUrl) {
            $res['mobileOriginalHomepageUrl'] = $this->mobileOriginalHomepageUrl;
        }
        if (null !== $this->mobileTransferUrl) {
            $res['mobileTransferUrl'] = $this->mobileTransferUrl;
        }
        if (null !== $this->padEffectiveHomepageUrl) {
            $res['padEffectiveHomepageUrl'] = $this->padEffectiveHomepageUrl;
        }
        if (null !== $this->padLoginAddressKey) {
            $res['padLoginAddressKey'] = $this->padLoginAddressKey;
        }
        if (null !== $this->padLoginLoginUrl) {
            $res['padLoginLoginUrl'] = $this->padLoginLoginUrl;
        }
        if (null !== $this->padLoginRequestMethod) {
            $res['padLoginRequestMethod'] = $this->padLoginRequestMethod;
        }
        if (null !== $this->padOriginalHomepageUrl) {
            $res['padOriginalHomepageUrl'] = $this->padOriginalHomepageUrl;
        }
        if (null !== $this->padTransferUrl) {
            $res['padTransferUrl'] = $this->padTransferUrl;
        }
        if (null !== $this->pcEffectiveHomepageUrl) {
            $res['pcEffectiveHomepageUrl'] = $this->pcEffectiveHomepageUrl;
        }
        if (null !== $this->pcLoginAddressKey) {
            $res['pcLoginAddressKey'] = $this->pcLoginAddressKey;
        }
        if (null !== $this->pcLoginLoginUrl) {
            $res['pcLoginLoginUrl'] = $this->pcLoginLoginUrl;
        }
        if (null !== $this->pcLoginRequestMethod) {
            $res['pcLoginRequestMethod'] = $this->pcLoginRequestMethod;
        }
        if (null !== $this->pcOriginalHomepageUrl) {
            $res['pcOriginalHomepageUrl'] = $this->pcOriginalHomepageUrl;
        }
        if (null !== $this->pcTransferUrl) {
            $res['pcTransferUrl'] = $this->pcTransferUrl;
        }
        if (null !== $this->ssoH5PageType) {
            $res['ssoH5PageType'] = $this->ssoH5PageType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInnerAppInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['customerAppId'])) {
            $model->customerAppId = $map['customerAppId'];
        }
        if (isset($map['hideDingNavBar'])) {
            $model->hideDingNavBar = $map['hideDingNavBar'];
        }
        if (isset($map['mobileLoginAddressKey'])) {
            $model->mobileLoginAddressKey = $map['mobileLoginAddressKey'];
        }
        if (isset($map['mobileLoginLoginUrl'])) {
            $model->mobileLoginLoginUrl = $map['mobileLoginLoginUrl'];
        }
        if (isset($map['mobileLoginRequestMethod'])) {
            $model->mobileLoginRequestMethod = $map['mobileLoginRequestMethod'];
        }
        if (isset($map['mobileOriginalHomepageUrl'])) {
            $model->mobileOriginalHomepageUrl = $map['mobileOriginalHomepageUrl'];
        }
        if (isset($map['mobileTransferUrl'])) {
            $model->mobileTransferUrl = $map['mobileTransferUrl'];
        }
        if (isset($map['padEffectiveHomepageUrl'])) {
            $model->padEffectiveHomepageUrl = $map['padEffectiveHomepageUrl'];
        }
        if (isset($map['padLoginAddressKey'])) {
            $model->padLoginAddressKey = $map['padLoginAddressKey'];
        }
        if (isset($map['padLoginLoginUrl'])) {
            $model->padLoginLoginUrl = $map['padLoginLoginUrl'];
        }
        if (isset($map['padLoginRequestMethod'])) {
            $model->padLoginRequestMethod = $map['padLoginRequestMethod'];
        }
        if (isset($map['padOriginalHomepageUrl'])) {
            $model->padOriginalHomepageUrl = $map['padOriginalHomepageUrl'];
        }
        if (isset($map['padTransferUrl'])) {
            $model->padTransferUrl = $map['padTransferUrl'];
        }
        if (isset($map['pcEffectiveHomepageUrl'])) {
            $model->pcEffectiveHomepageUrl = $map['pcEffectiveHomepageUrl'];
        }
        if (isset($map['pcLoginAddressKey'])) {
            $model->pcLoginAddressKey = $map['pcLoginAddressKey'];
        }
        if (isset($map['pcLoginLoginUrl'])) {
            $model->pcLoginLoginUrl = $map['pcLoginLoginUrl'];
        }
        if (isset($map['pcLoginRequestMethod'])) {
            $model->pcLoginRequestMethod = $map['pcLoginRequestMethod'];
        }
        if (isset($map['pcOriginalHomepageUrl'])) {
            $model->pcOriginalHomepageUrl = $map['pcOriginalHomepageUrl'];
        }
        if (isset($map['pcTransferUrl'])) {
            $model->pcTransferUrl = $map['pcTransferUrl'];
        }
        if (isset($map['ssoH5PageType'])) {
            if (!empty($map['ssoH5PageType'])) {
                $model->ssoH5PageType = $map['ssoH5PageType'];
            }
        }

        return $model;
    }
}
