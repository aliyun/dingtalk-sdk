<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateVersionAcrossBundleRequest extends Model
{
    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description sourceVersion
     *
     * @var string
     */
    public $sourceVersion;

    /**
     * @description sourceBundleId
     *
     * @var string
     */
    public $sourceBundleId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @description bundleId
     *
     * @var string
     */
    public $bundleId;

    /**
     * @description version
     *
     * @var string
     */
    public $version;

    /**
     * @var string
     */
    public $dingClientId;

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
    public $miniAppId;
    protected $_name = [
        'dingTokenGrantType' => 'dingTokenGrantType',
        'sourceVersion'      => 'sourceVersion',
        'sourceBundleId'     => 'sourceBundleId',
        'dingOrgId'          => 'dingOrgId',
        'dingCorpId'         => 'dingCorpId',
        'bundleId'           => 'bundleId',
        'version'            => 'version',
        'dingClientId'       => 'dingClientId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'miniAppId'          => 'miniAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->sourceVersion) {
            $res['sourceVersion'] = $this->sourceVersion;
        }
        if (null !== $this->sourceBundleId) {
            $res['sourceBundleId'] = $this->sourceBundleId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->bundleId) {
            $res['bundleId'] = $this->bundleId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateVersionAcrossBundleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['sourceVersion'])) {
            $model->sourceVersion = $map['sourceVersion'];
        }
        if (isset($map['sourceBundleId'])) {
            $model->sourceBundleId = $map['sourceBundleId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['bundleId'])) {
            $model->bundleId = $map['bundleId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }

        return $model;
    }
}
