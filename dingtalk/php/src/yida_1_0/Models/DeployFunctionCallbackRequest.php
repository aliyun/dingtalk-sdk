<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeployFunctionCallbackRequest extends Model
{
    /**
     * @example 202201061234
     *
     * @var string
     */
    public $appId;

    /**
     * @example abc.com
     *
     * @var string
     */
    public $customDomain;

    /**
     * @example RELEASE
     *
     * @var string
     */
    public $deployStage;

    /**
     * @example assdfasdfWwd12212
     *
     * @var string
     */
    public $gateWayAppKey;

    /**
     * @example fasdfsfasdf1212Sff
     *
     * @var string
     */
    public $gateWayAppSecret;

    /**
     * @example 1111shanghai-aliyunapi.com
     *
     * @var string
     */
    public $gateWayDomain;
    protected $_name = [
        'appId'            => 'appId',
        'customDomain'     => 'customDomain',
        'deployStage'      => 'deployStage',
        'gateWayAppKey'    => 'gateWayAppKey',
        'gateWayAppSecret' => 'gateWayAppSecret',
        'gateWayDomain'    => 'gateWayDomain',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->customDomain) {
            $res['customDomain'] = $this->customDomain;
        }
        if (null !== $this->deployStage) {
            $res['deployStage'] = $this->deployStage;
        }
        if (null !== $this->gateWayAppKey) {
            $res['gateWayAppKey'] = $this->gateWayAppKey;
        }
        if (null !== $this->gateWayAppSecret) {
            $res['gateWayAppSecret'] = $this->gateWayAppSecret;
        }
        if (null !== $this->gateWayDomain) {
            $res['gateWayDomain'] = $this->gateWayDomain;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeployFunctionCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['customDomain'])) {
            $model->customDomain = $map['customDomain'];
        }
        if (isset($map['deployStage'])) {
            $model->deployStage = $map['deployStage'];
        }
        if (isset($map['gateWayAppKey'])) {
            $model->gateWayAppKey = $map['gateWayAppKey'];
        }
        if (isset($map['gateWayAppSecret'])) {
            $model->gateWayAppSecret = $map['gateWayAppSecret'];
        }
        if (isset($map['gateWayDomain'])) {
            $model->gateWayDomain = $map['gateWayDomain'];
        }

        return $model;
    }
}
