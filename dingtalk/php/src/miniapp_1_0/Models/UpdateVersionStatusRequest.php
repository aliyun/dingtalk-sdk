<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateVersionStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bundleId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @var string
     */
    public $version;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $versionType;
    protected $_name = [
        'bundleId' => 'bundleId',
        'miniAppId' => 'miniAppId',
        'version' => 'version',
        'versionType' => 'versionType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bundleId) {
            $res['bundleId'] = $this->bundleId;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->versionType) {
            $res['versionType'] = $this->versionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateVersionStatusRequest
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
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['versionType'])) {
            $model->versionType = $map['versionType'];
        }

        return $model;
    }
}
