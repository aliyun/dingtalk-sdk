<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeployFunctionCallbackRequest extends Model
{
    /**
     * @description 云应用id
     *
     * @var string
     */
    public $appId;

    /**
     * @description 自定义域名
     *
     * @var string
     */
    public $customDomain;

    /**
     * @description 部署阶段
     *
     * @var string
     */
    public $deployStage;

    /**
     * @description api网关实例的AppKey
     *
     * @var string
     */
    public $gateWayAppKey;

    /**
     * @description api网关实例的APPSecret
     *
     * @var string
     */
    public $gateWayAppSecret;

    /**
     * @description api网关二级域名
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
