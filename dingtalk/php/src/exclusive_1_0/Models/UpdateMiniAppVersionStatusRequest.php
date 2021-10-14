<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateMiniAppVersionStatusRequest extends Model
{
    /**
     * @description 版本类型
     *
     * @var int
     */
    public $versionType;

    /**
     * @description 版本
     *
     * @var string
     */
    public $version;

    /**
     * @description 小程序id
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @var string
     */
    public $dingClientId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var string
     */
    public $dingCorpId;
    protected $_name = [
        'versionType'        => 'versionType',
        'version'            => 'version',
        'miniAppId'          => 'miniAppId',
        'dingClientId'       => 'dingClientId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingCorpId'         => 'dingCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->versionType) {
            $res['versionType'] = $this->versionType;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMiniAppVersionStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['versionType'])) {
            $model->versionType = $map['versionType'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }

        return $model;
    }
}
