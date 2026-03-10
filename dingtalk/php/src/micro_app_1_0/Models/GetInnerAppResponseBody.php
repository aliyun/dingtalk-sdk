<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInnerAppResponseBody extends Model
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
    public $mobileOriginalHomepageUrl;

    /**
     * @var string
     */
    public $mobileTransferUrl;

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
    public $pcOriginalHomepageUrl;

    /**
     * @var string
     */
    public $pcTransferUrl;
    protected $_name = [
        'agentId' => 'agentId',
        'appName' => 'appName',
        'customerAppId' => 'customerAppId',
        'mobileLoginAddressKey' => 'mobileLoginAddressKey',
        'mobileLoginLoginUrl' => 'mobileLoginLoginUrl',
        'mobileOriginalHomepageUrl' => 'mobileOriginalHomepageUrl',
        'mobileTransferUrl' => 'mobileTransferUrl',
        'pcEffectiveHomepageUrl' => 'pcEffectiveHomepageUrl',
        'pcLoginAddressKey' => 'pcLoginAddressKey',
        'pcLoginLoginUrl' => 'pcLoginLoginUrl',
        'pcOriginalHomepageUrl' => 'pcOriginalHomepageUrl',
        'pcTransferUrl' => 'pcTransferUrl',
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
        if (null !== $this->mobileLoginAddressKey) {
            $res['mobileLoginAddressKey'] = $this->mobileLoginAddressKey;
        }
        if (null !== $this->mobileLoginLoginUrl) {
            $res['mobileLoginLoginUrl'] = $this->mobileLoginLoginUrl;
        }
        if (null !== $this->mobileOriginalHomepageUrl) {
            $res['mobileOriginalHomepageUrl'] = $this->mobileOriginalHomepageUrl;
        }
        if (null !== $this->mobileTransferUrl) {
            $res['mobileTransferUrl'] = $this->mobileTransferUrl;
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
        if (null !== $this->pcOriginalHomepageUrl) {
            $res['pcOriginalHomepageUrl'] = $this->pcOriginalHomepageUrl;
        }
        if (null !== $this->pcTransferUrl) {
            $res['pcTransferUrl'] = $this->pcTransferUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInnerAppResponseBody
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
        if (isset($map['mobileLoginAddressKey'])) {
            $model->mobileLoginAddressKey = $map['mobileLoginAddressKey'];
        }
        if (isset($map['mobileLoginLoginUrl'])) {
            $model->mobileLoginLoginUrl = $map['mobileLoginLoginUrl'];
        }
        if (isset($map['mobileOriginalHomepageUrl'])) {
            $model->mobileOriginalHomepageUrl = $map['mobileOriginalHomepageUrl'];
        }
        if (isset($map['mobileTransferUrl'])) {
            $model->mobileTransferUrl = $map['mobileTransferUrl'];
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
        if (isset($map['pcOriginalHomepageUrl'])) {
            $model->pcOriginalHomepageUrl = $map['pcOriginalHomepageUrl'];
        }
        if (isset($map['pcTransferUrl'])) {
            $model->pcTransferUrl = $map['pcTransferUrl'];
        }

        return $model;
    }
}
