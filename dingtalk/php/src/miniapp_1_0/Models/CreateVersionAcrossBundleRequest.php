<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateVersionAcrossBundleRequest extends Model
{
    /**
     * @description bundleId
     *
     * @var string
     */
    public $bundleId;

    /**
     * @var string
     */
    public $miniAppId;

    /**
     * @description sourceBundleId
     *
     * @var string
     */
    public $sourceBundleId;

    /**
     * @description sourceVersion
     *
     * @var string
     */
    public $sourceVersion;

    /**
     * @description version
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'bundleId'       => 'bundleId',
        'miniAppId'      => 'miniAppId',
        'sourceBundleId' => 'sourceBundleId',
        'sourceVersion'  => 'sourceVersion',
        'version'        => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bundleId) {
            $res['bundleId'] = $this->bundleId;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->sourceBundleId) {
            $res['sourceBundleId'] = $this->sourceBundleId;
        }
        if (null !== $this->sourceVersion) {
            $res['sourceVersion'] = $this->sourceVersion;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
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
        if (isset($map['bundleId'])) {
            $model->bundleId = $map['bundleId'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['sourceBundleId'])) {
            $model->sourceBundleId = $map['sourceBundleId'];
        }
        if (isset($map['sourceVersion'])) {
            $model->sourceVersion = $map['sourceVersion'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
