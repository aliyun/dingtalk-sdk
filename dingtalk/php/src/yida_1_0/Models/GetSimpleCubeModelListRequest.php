<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSimpleCubeModelListRequest extends Model
{
    /**
     * @example APP_Q7D2TFJZWNMDS145Z7DP
     *
     * @var string
     */
    public $appType;

    /**
     * @example ding5d17e3add038d44535c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @example FORM_MT866EA17HGCUHIV7GROU72YO499257KRS0KLB
     *
     * @var string
     */
    public $cubeCode;

    /**
     * @example ding5d17e3add038d44535c2f4657eb6378f
     *
     * @var string
     */
    public $cubeTenantId;

    /**
     * @example U66663B1LLGCVCVPAF76H6955VYG2408RS0KL0
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example 1160440651754805
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'      => 'appType',
        'corpId'       => 'corpId',
        'cubeCode'     => 'cubeCode',
        'cubeTenantId' => 'cubeTenantId',
        'systemToken'  => 'systemToken',
        'userId'       => 'userId',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->cubeCode) {
            $res['cubeCode'] = $this->cubeCode;
        }
        if (null !== $this->cubeTenantId) {
            $res['cubeTenantId'] = $this->cubeTenantId;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSimpleCubeModelListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['cubeCode'])) {
            $model->cubeCode = $map['cubeCode'];
        }
        if (isset($map['cubeTenantId'])) {
            $model->cubeTenantId = $map['cubeTenantId'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
